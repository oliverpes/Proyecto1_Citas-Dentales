using System;
using System.Windows.Input;
using Entities;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Generic;

using System.Linq;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace BusinessLogic
{
    public static class Business
    {

        //nuevas cadenas de variables globales
        public static List<QueryType> queryTypes = new List<QueryType>();
        public static List<Client> clients = new List<Client>();
        public static List<Doctor> doctors = new List<Doctor>();
        public static List<Appointment> appointments = new List<Appointment>();


        // Variable para almacenar el id del cliente de la fila seleccionada
        public static int selectedClientId;

        // Metodo para guardar un tipo de consulta
        public static Response SaveQueryType(string descripcion, int estado)
        {
            Response response = new() { Success = false };

            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();
                int newId = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener siguiente ID disponible
                    string selectMaxId = "SELECT MAX(Id) FROM TiposConsulta";
                    using (SqlCommand cmd = new SqlCommand(selectMaxId, connection))
                    {
                        var result = cmd.ExecuteScalar();
                        newId = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                    }

                    // Insertar nuevo tipo de consulta
                    string insertQuery = @"INSERT INTO TiposConsulta (Id, Descripcion, Estado) 
                                   VALUES (@Id, @Descripcion, @Estado)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", newId);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Estado", estado == 1);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            response.Success = true;
                            response.GeneratedId = newId;
                            response.Message = "Tipo de consulta guardado correctamente.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        //funcion para mostrar doctores en el DataGrid
        public static List<Doctor> GetDoctorsFromDatabase()
        {
            List<Doctor> doctors = new List<Doctor>();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT d.Id, d.Nombre, d.ApellidoPaterno, d.ApellidoMaterno, d.EstadoId
                         FROM Doctores d";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellidoPaterno = reader.GetString(2);
                        string apellidoMaterno = reader.GetString(3);
                        int estadoId = reader.GetInt32(4);

                        doctors.Add(new Doctor(id, nombre, apellidoPaterno, apellidoMaterno, estadoId));
                    }
                }
            }

            return doctors;
        }

        // Metodo para guardar un cliente
        public static Response SaveClient(string name, string lastName, string secondLastName, DateTime birthday, char gender)
        {
            Response response = new() { Success = false };

            try
            {
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException("El nombre del cliente no puede estar vacío.");

                if (string.IsNullOrEmpty(lastName))
                    throw new ArgumentException("El apellido paterno no puede estar vacío.");

                if (string.IsNullOrEmpty(secondLastName))
                    throw new ArgumentException("El apellido materno no puede estar vacío.");

                if (gender != 'M' && gender != 'F' && gender != 'N')
                    throw new ArgumentException("El género debe ser M, F o N.");

                if (birthday > DateTime.Now || birthday < new DateTime(1925, 1, 1))
                    throw new ArgumentException("La fecha de nacimiento debe estar entre 1925 y hoy.");

                string connectionString = File.ReadAllText("config.txt").Trim();
                int newId = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener siguiente ID disponible
                    string selectMaxId = "SELECT MAX(Id) FROM Clientes";
                    using (SqlCommand cmd = new SqlCommand(selectMaxId, connection))
                    {
                        var result = cmd.ExecuteScalar();
                        newId = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                    }

                    // Insertar cliente con EstadoId por defecto en 1 (activo)
                    string insertQuery = @"INSERT INTO Clientes 
                (Id, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Genero, EstadoId) 
                VALUES (@Id, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Genero, 1)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", newId);
                        cmd.Parameters.AddWithValue("@Nombre", name);
                        cmd.Parameters.AddWithValue("@ApellidoPaterno", lastName);
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", secondLastName);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", birthday);
                        cmd.Parameters.AddWithValue("@Genero", gender);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            response.Success = true;
                            response.GeneratedId = newId;
                            response.Message = "Cliente guardado correctamente.";
                        }
                        else
                        {
                            response.Message = "No se pudo guardar el cliente.";
                        }
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }


        // Metodo para guardar un doctor

        public static Response SaveDoctor(string name, string lastName, string secondLastName, int state)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                // Validaciones
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException("El nombre del cliente no puede estar vacío.");

                if (string.IsNullOrEmpty(lastName))
                    throw new ArgumentException("El apellido paterno del cliente no puede estar vacío.");

                if (string.IsNullOrEmpty(secondLastName))
                    throw new ArgumentException("El apellido materno del cliente no puede estar vacío.");

                if (state != 1 && state != 0)
                    throw new ArgumentException("El estado de consulta debe ser 'Activo' o 'Inactivo'.");

                // Leer la cadena de conexión desde el archivo config.txt
                string connectionString = File.ReadAllText("config.txt").Trim();
                Console.WriteLine(connectionString);

                int newId = 0;

                // Obtener el siguiente ID disponible
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MAX(Id) FROM Doctores";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        var result = cmd.ExecuteScalar();
                        newId = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                    }
                }

                // Insertar nuevo doctor en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Doctores (Id, Nombre, ApellidoPaterno, ApellidoMaterno, EstadoId) " +
                                   "VALUES (@Id, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @EstadoId)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", newId);
                        cmd.Parameters.AddWithValue("@Nombre", name);
                        cmd.Parameters.AddWithValue("@ApellidoPaterno", lastName);
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", secondLastName);
                        cmd.Parameters.AddWithValue("@EstadoId", state);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            response.Success = true;
                            response.GeneratedId = newId;
                            response.Message = $"El doctor se guardó correctamente en la base de datos con ID: {newId}.";
                        }
                        else
                        {
                            response.Message = "No se pudo guardar el doctor en la base de datos.";
                            return response;
                        }
                    }
                }

                // Guardar también en la lista local
                doctors.Add(new Doctor(newId, name, lastName, secondLastName, state));
                return response;
            }
            catch (ArgumentException ae)
            {
                response.Message = ae.Message;
                return response;
            }
            catch (InvalidOperationException ioe)
            {
                response.Message = ioe.Message;
                return response;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return response;
            }
        }


        // Método para cargar citas desde la base de datos
        public static void LoadAppointmentsFromDatabase()
        {
            appointments.Clear(); // Limpiar lista actual

            string connectionString = File.ReadAllText("config.txt").Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        c.Id AS CitaId, c.Fecha,
                        tc.Id AS TipoId, tc.Descripcion,
                        cl.Id AS ClienteId, cl.Nombre AS ClienteNombre, 
                        cl.ApellidoPaterno AS ClienteApellidoPaterno, cl.ApellidoMaterno AS ClienteApellidoMaterno, cl.FechaNacimiento, cl.Genero, cl.EstadoId AS ClienteEstadoId,
                        d.Id AS DoctorId, d.Nombre AS DoctorNombre, 
                        d.ApellidoPaterno AS DoctorApellidoPaterno, d.ApellidoMaterno AS DoctorApellidoMaterno, d.EstadoId AS DoctorEstadoId,
                        c.EstadoId AS CitaEstadoId, e.Nombre AS NombreEstado
                    FROM Citas c
                    JOIN TiposConsulta tc ON c.TipoConsultaId = tc.Id
                    JOIN Clientes cl ON c.ClienteId = cl.Id
                    JOIN Doctores d ON c.DoctorId = d.Id
                    JOIN EstadosCita e ON c.EstadoId = e.Id
                    ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("CitaId"));
                        DateTime fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));

                        // Tipo de consulta
                        int tipoId = reader.GetInt32(reader.GetOrdinal("TipoId"));
                        string tipoDesc = reader.GetString(reader.GetOrdinal("Descripcion"));
                        QueryType tipo = new QueryType(tipoId, tipoDesc, 'A');

                        // Cliente
                        int clientId = reader.GetInt32(reader.GetOrdinal("ClienteId"));
                        string clientName = reader.GetString(reader.GetOrdinal("ClienteNombre"));
                        string clientLast1 = reader.GetString(reader.GetOrdinal("ClienteApellidoPaterno"));
                        string clientLast2 = reader.GetString(reader.GetOrdinal("ClienteApellidoMaterno"));
                        DateTime clientBirth = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
                        char clientGender = reader.GetString(reader.GetOrdinal("Genero"))[0];
                        int clientState = reader.GetInt32(reader.GetOrdinal("ClienteEstadoId"));
                        Client client = new Client(clientId, clientName, clientLast1, clientLast2, clientBirth, clientGender, clientState);

                        // Doctor
                        int doctorId = reader.GetInt32(reader.GetOrdinal("DoctorId"));
                        string doctorName = reader.GetString(reader.GetOrdinal("DoctorNombre"));
                        string doctorLast1 = reader.GetString(reader.GetOrdinal("DoctorApellidoPaterno"));
                        string doctorLast2 = reader.GetString(reader.GetOrdinal("DoctorApellidoMaterno"));
                        int doctorState = reader.GetInt32(reader.GetOrdinal("DoctorEstadoId"));
                        Doctor doctor = new Doctor(doctorId, doctorName, doctorLast1, doctorLast2, doctorState);

                        // Estado de la cita
                        string stateName = reader.GetString(reader.GetOrdinal("NombreEstado"));

                        // Agregar a la lista incluyendo el estado
                        appointments.Add(new Appointment(id, fecha, tipo, client, doctor, stateName));
                    }
                }
            }
        }
        // Metodo para marcar que no asistio a su cita el paciente
        public static Response MarkAsNoShow(int citaId)
        {
            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Citas SET EstadoId = 3 WHERE Id = @Id"; // 3 = No asistió (nuevo estado)
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", citaId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            return new Response { Success = true, Message = "Cita marcada como No asistió" };
                        else
                            return new Response { Success = false, Message = "No se encontró la cita" };
                    }
                }
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = ex.Message };
            }
        }


        // Nuevo método para cancelar cita
        public static Response CancelAppointment(int citaId)
        {
            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Citas SET EstadoId = 2 WHERE Id = @Id"; // 2 = Cancelada
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", citaId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            return new Response { Success = true, Message = "Cita cancelada correctamente" };
                        else
                            return new Response { Success = false, Message = "No se encontró la cita a cancelar" };
                    }
                }
            }
            catch (Exception ex)
            {
                return new Response { Success = false, Message = "Error al cancelar la cita: " + ex.Message };
            }
        }



        //metodo para recargar datos desde la base de datos
        public static void LoadQueryTypes()
        {
            queryTypes.Clear();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            using SqlCommand cmd = new("SELECT Id, Descripcion FROM TiposConsulta WHERE Estado = 1", conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                queryTypes.Add(new QueryType
                {
                    Id = reader.GetInt32(0),
                    Description = reader.GetString(1)
                });
            }
        }

        public static void LoadClients()
        {
            clients.Clear();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            using SqlCommand cmd = new("SELECT Id, Nombre, Apellido FROM Clientes", conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clients.Add(new Client
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    LastName = reader.GetString(2)
                });
            }
        }

        public static void LoadDoctors()
        {
            doctors.Clear();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            using SqlCommand cmd = new("SELECT Id, Nombre, Apellido FROM Doctores WHERE EstadoId = 1", conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                doctors.Add(new Doctor
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    LastName = reader.GetString(2)
                });
            }
        }

        public static void LoadAppointments()
        {
            appointments.Clear();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            using SqlCommand cmd = new(
                @"SELECT c.Id, c.Fecha, c.TipoConsultaId, c.ClienteId, c.DoctorId
          FROM Citas c", conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                DateTime fecha = reader.GetDateTime(1);
                int tipoId = reader.GetInt32(2);
                int clienteId = reader.GetInt32(3);
                int doctorId = reader.GetInt32(4);

                QueryType qt = queryTypes.FirstOrDefault(q => q.Id == tipoId);
                Client cl = clients.FirstOrDefault(c => c.Id == clienteId);
                Doctor dr = doctors.FirstOrDefault(d => d.Id == doctorId);

                if (qt == null || cl == null || dr == null) continue;

                appointments.Add(new Appointment
                {
                    Id = id,
                    Date = fecha,
                    QueryType = qt,
                    Client = cl,
                    Doctor = dr
                });
            }
        }

        //cargar de la base de datos los horarios de los doctores 
        public static List<TimeSpan> GetAvailableHours(int doctorId, DateTime selectedDate)
        {
            var availableHours = new List<TimeSpan>();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();

            // 1. Obtener disponibilidad para ese día
            string queryHorario = @"
            SELECT HoraInicio, HoraFin 
            FROM HorariosDisponibles 
            WHERE DoctorId = @DoctorId AND DiaSemana = @DiaSemana";

            using SqlCommand cmdHorario = new(queryHorario, conn);
            cmdHorario.Parameters.AddWithValue("@DoctorId", doctorId);
            cmdHorario.Parameters.AddWithValue("@DiaSemana", (int)selectedDate.DayOfWeek);

            using SqlDataReader readerHorario = cmdHorario.ExecuteReader();

            if (!readerHorario.Read())
                return availableHours; // No hay disponibilidad

            TimeSpan horaInicio = readerHorario.GetTimeSpan(0);
            TimeSpan horaFin = readerHorario.GetTimeSpan(1);
            readerHorario.Close();

            // 2. Obtener horas ya ocupadas por citas
            string queryCitas = @"
            SELECT CONVERT(time, Fecha) 
            FROM Citas 
            WHERE DoctorId = @DoctorId AND CONVERT(date, Fecha) = @Fecha";

            var horasOcupadas = new List<TimeSpan>();
            using SqlCommand cmdCitas = new(queryCitas, conn);
            cmdCitas.Parameters.AddWithValue("@DoctorId", doctorId);
            cmdCitas.Parameters.AddWithValue("@Fecha", selectedDate.Date);

            using SqlDataReader readerCitas = cmdCitas.ExecuteReader();
            while (readerCitas.Read())
                horasOcupadas.Add(readerCitas.GetTimeSpan(0));

            // 3. Generar lista de horas disponibles (cada 30 min)
            for (TimeSpan hora = horaInicio; hora < horaFin; hora = hora.Add(TimeSpan.FromMinutes(30)))
            {
                if (!horasOcupadas.Contains(hora))
                    availableHours.Add(hora);
            }

            return availableHours;
        }

        //validar conexion a la base de datos
        // Dentro de tu archivo en la capa BusinessLogic
        public static class ConnectionManager
        {
            public static SqlConnection Connection { get; private set; }

            public static void OpenConnection()
            {
                if (Connection == null)
                {
                    string connString = File.ReadAllText("config.txt").Trim();
                    Connection = new SqlConnection(connString);
                }

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
            }

            public static void CloseConnection()
            {
                if (Connection != null && Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }



        // Metodo para guardar una cita
        public static Response SaveAppointment(DateTime date, string queryTypeData, string clientData, string doctorData)
        {
            Response response = new() { Success = false };

            try
            {
                string[] infotype = queryTypeData.Split('-');
                string[] infoclient = clientData.Split('-');
                string[] infodoctor = doctorData.Split('-');

                int queryTypeId = int.Parse(infotype[0].Trim());
                int clientId = int.Parse(infoclient[0].Trim());
                int doctorId = int.Parse(infodoctor[0].Trim());

                if (date < DateTime.Now)
                    throw new ArgumentException("La fecha de la cita no puede ser menor a la fecha actual.");

                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verificar existencia de tipo de consulta activo
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TiposConsulta WHERE Id = @Id AND Estado = 1", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", queryTypeId);
                        if ((int)cmd.ExecuteScalar() == 0)
                            throw new InvalidOperationException("El tipo de consulta no existe.");
                    }

                    // Verificar existencia de cliente
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", clientId);
                        if ((int)cmd.ExecuteScalar() == 0)
                            throw new InvalidOperationException("El cliente no existe.");
                    }

                    // Verificar existencia de doctor activo
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Doctores WHERE Id = @Id AND EstadoId = 1", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", doctorId);
                        if ((int)cmd.ExecuteScalar() == 0)
                            throw new InvalidOperationException("El doctor no existe.");
                    }

                    // Validar que no haya conflicto de hora entre mismo doctor y cliente
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT COUNT(*) FROM Citas 
                  WHERE ClienteId = @ClienteId AND DoctorId = @DoctorId 
                  AND ABS(DATEDIFF(MINUTE, Fecha, @Fecha)) <= 59", conn))
                    {
                        cmd.Parameters.AddWithValue("@ClienteId", clientId);
                        cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                        cmd.Parameters.AddWithValue("@Fecha", date);
                        if ((int)cmd.ExecuteScalar() > 0)
                            throw new InvalidOperationException("El cliente ya tiene una cita con el mismo doctor en un rango de 59 minutos.");
                    }

                    // Insertar cita (sin especificar el ID)
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Citas (Fecha, TipoConsultaId, ClienteId, DoctorId)
                  VALUES (@Fecha, @TipoConsultaId, @ClienteId, @DoctorId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Fecha", date);
                        cmd.Parameters.AddWithValue("@TipoConsultaId", queryTypeId);
                        cmd.Parameters.AddWithValue("@ClienteId", clientId);
                        cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                        cmd.ExecuteNonQuery();
                    }
                }

                response.Success = true;
                response.Message = "Cita guardada correctamente.";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        




        // ****** TIPOS DE CONSULTA ****** //



        public static Response ChangeStatusQueryType(int id)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID de consulta debe ser un número positivo mayor que cero.");
                }

                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Obtener estado actual
                    string selectQuery = "SELECT Estado FROM TiposConsulta WHERE Id = @Id";
                    bool? estadoActual = null;

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@Id", id);
                        object result = selectCmd.ExecuteScalar();
                        if (result == null)
                        {
                            throw new InvalidOperationException("El tipo de consulta no existe.");
                        }

                        estadoActual = Convert.ToBoolean(result);
                    }

                    // Cambiar estado
                    bool nuevoEstado = !(estadoActual ?? true);

                    string updateQuery = "UPDATE TiposConsulta SET Estado = @NuevoEstado WHERE Id = @Id";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                        updateCmd.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            response.Success = true;
                            response.Message = "Estado actualizado correctamente.";
                        }
                        else
                        {
                            throw new InvalidOperationException("No se pudo actualizar el estado.");
                        }
                    }
                }

                return response;
            }
            catch (ArgumentException ae)
            {
                response.Message = ae.Message;
                return response;
            }
            catch (InvalidOperationException ioe)
            {
                response.Message = ioe.Message;
                return response;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return response;
            }
        }

        // Eliminar tipo de consulta
        public static Response DeleteQueryType(int id)
        {
            Response response = new() { Success = false };

            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM TiposConsulta WHERE Id = @Id";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@Id", id);

                        int rows = deleteCmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            response.Success = true;
                            response.Message = "Tipo de consulta eliminado correctamente.";
                        }
                        else
                        {
                            response.Message = "No se pudo eliminar el tipo de consulta.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        // ****** CLIENTES ****** //

        //cambiar estado cliente //
        public static Response ToggleClientStatus(int clientId)
        {
            Response response = new() { Success = false };

            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el estado actual
                    string getStatusQuery = "SELECT EstadoId FROM Clientes WHERE Id = @Id";
                    int currentStatus = 1;

                    using (SqlCommand getCmd = new SqlCommand(getStatusQuery, connection))
                    {
                        getCmd.Parameters.AddWithValue("@Id", clientId);
                        var result = getCmd.ExecuteScalar();
                        if (result == null)
                        {
                            response.Message = "Cliente no encontrado.";
                            return response;
                        }
                        currentStatus = Convert.ToInt32(result);
                    }

                    int newStatus = currentStatus == 1 ? 0 : 1;

                    // Actualizar el estado
                    string updateQuery = "UPDATE Clientes SET EstadoId = @EstadoId WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@EstadoId", newStatus);
                        cmd.Parameters.AddWithValue("@Id", clientId);

                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            response.Success = true;
                            response.Message = "Estado actualizado correctamente.";
                        }
                        else
                        {
                            response.Message = "No se pudo actualizar el estado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }


        // Actualizar datos del cliente
        public static Response UpdateClientData(DateTime birthday, char gender)
        {
            Response response = new() { Success = false };

            try
            {
                if (selectedClientId <= 0)
                    throw new ArgumentException("No se ha seleccionado ningún cliente.");

                if (gender != 'M' && gender != 'F' && gender != 'N')
                    throw new ArgumentException("El género debe ser M, F o N.");

                if (birthday > DateTime.Now || birthday < new DateTime(1925, 1, 1))
                    throw new ArgumentException("La fecha de nacimiento debe estar entre 1925 y hoy.");

                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Clientes SET FechaNacimiento = @FechaNacimiento, Genero = @Genero WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FechaNacimiento", birthday);
                        cmd.Parameters.AddWithValue("@Genero", gender);
                        cmd.Parameters.AddWithValue("@Id", selectedClientId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            response.Success = true;
                            response.Message = "Cliente actualizado correctamente.";
                        }
                        else
                        {
                            response.Message = "No se encontró el cliente para actualizar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        // Eliminar cliente
       public static Response DeleteClient()
        {
            var client = clients.FirstOrDefault(c => c != null && c.Id == selectedClientId);
            if (client != null)
            {
                clients.Remove(client);
                selectedClientId = 0;
                return new Response
                {
                    Success = true
                };
            }

            return new Response
            {
                Success = false,
                Message = "No se pudo eliminar el cliente"
            };
        }




        // ****** Doctores ****** //



        // Actualizar estado de doctor
        public static Response ChangeStatusDoctor(int id)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Seleccione la fila a modificar.");
                }

                // Leer cadena de conexión
                string connectionString = File.ReadAllText("config.txt").Trim();

                int currentState = -1;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el estado actual del doctor
                    string selectQuery = "SELECT EstadoId FROM Doctores WHERE Id = @Id";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                    {
                        selectCmd.Parameters.AddWithValue("@Id", id);
                        object result = selectCmd.ExecuteScalar();

                        if (result == null)
                        {
                            throw new InvalidOperationException("No se encontró el doctor.");
                        }

                        currentState = Convert.ToInt32(result);
                    }

                    // Cambiar el estado (1 -> 0, 0 -> 1)
                    int newState = currentState == 1 ? 0 : 1;

                    // Actualizar el estado
                    string updateQuery = "UPDATE Doctores SET EstadoId = @EstadoId WHERE Id = @Id";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@EstadoId", newState);
                        updateCmd.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            response.Success = true;
                            response.Message = "Estado actualizado correctamente.";
                        }
                        else
                        {
                            response.Message = "No se pudo actualizar el estado en la base de datos.";
                        }
                    }
                }

                return response;
            }
            catch (ArgumentException ae)
            {
                response.Message = ae.Message;
                return response;
            }
            catch (InvalidOperationException ioe)
            {
                response.Message = ioe.Message;
                return response;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return response;
            }
        }



        // Eliminar doctor
        public static Response DeleteDoctor(int id)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Seleccione la fila a eliminar.");
                }

                // Leer cadena de conexión
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Doctores WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            response.Success = true;
                            response.Message = "Doctor eliminado correctamente.";
                        }
                        else
                        {
                            response.Message = "No se encontró el doctor para eliminar.";
                        }
                    }
                }

                return response;
            }
            catch (ArgumentException ae)
            {
                response.Message = ae.Message;
                return response;
            }
            catch (InvalidOperationException ioe)
            {
                response.Message = ioe.Message;
                return response;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return response;
            }
        }




        // ****** Citas ****** //



        // Eliminar cita
        public static Response DeleteAppointment(int id)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID de consulta debe ser un número positivo mayor que cero.");
                }

                var appointment = appointments.FirstOrDefault(a => a != null && a.Id == id);
                if (appointment != null)
                {
                    appointments.Remove(appointment);
                    response.Success = true;
                    return response;
                }

                throw new InvalidOperationException("No se pudo eliminar la cita.");
            }
            catch (ArgumentException ae)
            {
                response.Message = ae.Message;
                return response;
            }
            catch (InvalidOperationException ioe)
            {
                response.Message = ioe.Message;
                return response;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                return response;
            }
        }
    }
}
