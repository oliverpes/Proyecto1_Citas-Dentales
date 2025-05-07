using System;
using System.Windows.Input;
using Entities;
using System;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace BusinessLogic
{
    public static class Business
    {
        // Variables globales
        public static QueryType[] queryTypes = new QueryType[10];
        public static Client[] clients = new Client[20];
        public static Doctor[] doctors = new Doctor[20];
        public static Appointment[] appointments = new Appointment[20];

        // Variable para almacenar el id del cliente de la fila seleccionada
        public static int selectedClientId;

        // Metodo para guardar un tipo de consulta
        public static Response SaveQueryType(int id, string description, char state)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                // Validaciones
                if (id <= 0)
                {
                    throw new ArgumentException("El ID de consulta debe ser un número positivo mayor que cero.");
                }
                if (string.IsNullOrEmpty(description))
                {
                    throw new ArgumentException("La descripción de consulta no puede estar vacía.");
                }
                if (state != 'A' && state != 'I')
                {
                    throw new ArgumentException("El estado de consulta debe ser 'Activo' o 'Inactivo'.");
                }

                // Verificar que el ID no exista en la lista
                for (int i = 0; i < queryTypes.Length; i++)
                {
                    if (queryTypes[i] != null && queryTypes[i].Id == id)
                    {
                        throw new InvalidOperationException("El ID de consulta ya existe.");
                    }
                }

                // Agregar el tipo de consulta si es posible
                for (int i = 0; i < queryTypes.Length; i++)
                {
                    if (queryTypes[i] == null)
                    {
                        queryTypes[i] = new QueryType(id, description, state);
                        response.Success = true;
                        return response;
                    }
                }

                throw new InvalidOperationException("No se pueden agregar más tipos de consulta.");
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

                    string insertQuery = "INSERT INTO Clientes (Id, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Genero) " +
                                         "VALUES (@Id, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Genero)";

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

                // Insertar nuevo doctor
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
                        }
                    }
                }

                // Guardar también en el arreglo local (si aplica)
                for (int i = 0; i < doctors.Length; i++)
                {
                    if (doctors[i] == null)
                    {
                        doctors[i] = new Doctor(newId, name, lastName, secondLastName, state);
                        return response;
                    }
                }

                throw new InvalidOperationException("No se pueden agregar más doctores.");
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


        // Metodo para guardar una cita
        public static Response SaveAppointment(string id, DateTime date, string queryTypeData, string clientData, string doctorData)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                string[] infotype = queryTypeData.Split('-');
                string[] infoclient = clientData.Split('-');
                string[] infodoctor = doctorData.Split('-');

                int queryTypeId = int.Parse(infotype[0]);
                int clientId = int.Parse(infoclient[0]);
                int doctorId = int.Parse(infodoctor[0]);

                // Validaciones
                int idInt;
                if (!int.TryParse(id, out idInt) || idInt <= 0)
                {
                    throw new ArgumentException("El ID de consulta debe ser un número positivo mayor que cero.");
                }
                if (date < DateTime.Now)
                {
                    throw new ArgumentException("La fecha de la cita no puede ser menor a la fecha actual.");
                }

                // Verificar que exista el tipo de consulta
                bool queryTypeExists = false;
                QueryType? queryType = null;
                for (int i = 0; i < queryTypes.Length; i++)
                {
                    if (queryTypes[i] != null && queryTypes[i].Id == queryTypeId)
                    {
                        queryTypeExists = true;
                        queryType = queryTypes[i];
                        break;
                    }
                }
                if (!queryTypeExists)
                {
                    throw new InvalidOperationException("El tipo de consulta no existe.");
                }

                // Verificar que exista el cliente
                bool clientExists = false;
                Client? client = null;
                for (int i = 0; i < clients.Length; i++)
                {
                    if (clients[i] != null && clients[i].Id == clientId)
                    {
                        clientExists = true;
                        client = clients[i];
                        break;
                    }
                }
                if (!clientExists)
                {
                    throw new InvalidOperationException("El cliente no existe.");
                }

                // Verificar que exista el doctor
                bool doctorExists = false;
                Doctor? doctor = null;
                for (int i = 0; i < doctors.Length; i++)
                {
                    if (doctors[i] != null && doctors[i].Id == doctorId)
                    {
                        doctorExists = true;
                        doctor = doctors[i];
                        break;
                    }
                }
                if (!doctorExists)
                {
                    throw new InvalidOperationException("El doctor no existe.");
                }

                // Verificar que el ID no exista en la lista
                for (int i = 0; i < appointments.Length; i++)
                {
                    if (appointments[i] != null && appointments[i].Id == idInt)
                    {
                        throw new InvalidOperationException("El ID de cita ya existe.");
                    }
                }

                // Validar que el cliente no tenga otra cita en la misma fecha y hora con el mismo doctor
                TimeSpan margen = TimeSpan.FromMinutes(59);
                DateTime fechaHoraSeleccionada = date;

                for (int i = 0; i < appointments.Length; i++)
                {
                    if (appointments[i] != null && appointments[i].Client.Id == clientId && appointments[i].Doctor.Id == doctorId)
                    {
                        // Calcular la diferencia en minutos entre la fecha y hora seleccionada y la cita existente
                        TimeSpan diferencia = fechaHoraSeleccionada - appointments[i].Date;

                        // Si la diferencia en minutos absolutos es menor o igual al margen, lanza una excepción
                        if (Math.Abs(diferencia.TotalMinutes) <= margen.TotalMinutes)
                        {
                            throw new InvalidOperationException("El cliente ya tiene una cita con el mismo doctor en un rango de 59 minutos de diferencia.");
                        }
                    }
                }

                // Agregar la cita si es posible
                if (queryType != null && client != null && doctor != null)
                {
                    for (int i = 0; i < appointments.Length; i++)
                    {
                        if (appointments[i] == null)
                        {
                            appointments[i] = new Appointment(idInt, date, queryType, client, doctor);
                            response.Success = true;
                            return response;
                        }
                    }
                }

                throw new InvalidOperationException("No se pueden agregar más citas.");
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



        // ****** TIPOS DE CONSULTA ****** //



        // Actualizar estado de tipo de consulta
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

                // Verificar que exista el tipo de consulta
                bool queryTypeExists = false;
                QueryType? queryType = null;
                for (int i = 0; i < queryTypes.Length; i++)
                {
                    if (queryTypes[i] != null && queryTypes[i].Id == id)
                    {
                        queryTypeExists = true;
                        queryType = queryTypes[i];
                        break;
                    }
                }
                if (!queryTypeExists)
                {
                    throw new InvalidOperationException("El tipo de consulta no existe.");
                }

                // Cambiar el estado del tipo de consulta
                if (queryType != null)
                {
                    if (queryType.State == 'A')
                    {
                        queryType.State = 'I';
                    }
                    else
                    {
                        queryType.State = 'A';
                    }
                    response.Success = true;
                    return response;
                }

                throw new InvalidOperationException("No se pudo cambiar el estado del tipo de consulta.");
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

                // Verificar que exista el tipo de consulta
                bool queryTypeExists = false;
                // QueryType? queryType = null;
                for (int i = 0; i < queryTypes.Length; i++)
                {
                    if (queryTypes[i] != null && queryTypes[i].Id == id)
                    {
                        // Eliminar el tipo de consulta
                        queryTypeExists = true;
                        queryTypes[i] = null;
                        response.Success = true;
                        return response;
                    }
                }
                if (!queryTypeExists)
                {
                    throw new InvalidOperationException("El tipo de consulta no existe.");
                }

                throw new InvalidOperationException("No se pudo eliminar el tipo de consulta.");
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


        // ****** CLIENTES ****** //



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
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i] != null && clients[i].Id == selectedClientId)
                {
                    clients[i] = null;
                    selectedClientId = 0;
                    return new Response
                    {
                        Success = true
                    };
                }
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

                for (int i = 0; i < appointments.Length; i++)
                {
                    if (appointments[i] != null && appointments[i].Id == id)
                    {
                        appointments[i] = null;
                        response.Success = true;
                        return response;
                    }
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
