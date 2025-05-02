using System;
using System.Windows.Input;
using Entities;
using System;
using System.IO;
using System.Data.SqlClient;


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

        // Metodo para guardar un cliente
        public static Response SaveClient(string id, string name, string lastName, string secondLastName, DateTime birthday, char gender)
        {
            Response response = new()
            {
                Success = false
            };

            try
            {
                int idInt;
                if (!int.TryParse(id, out idInt) || idInt <= 0)
                {
                    throw new ArgumentException("El ID de consulta debe ser un número positivo mayor que cero.");
                }
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("El nombre del cliente no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new ArgumentException("El apellido paterno del cliente no puede estar vacío.");
                }
                if (string.IsNullOrEmpty(secondLastName))
                {
                    throw new ArgumentException("El apellido materno del cliente no puede estar vacío.");
                }
                if (gender != 'M' && gender != 'F' && gender != 'N')
                {
                    throw new ArgumentException("El género del cliente debe ser 'Masculino', 'Femenino' o 'No especificado'.");
                }
                if (birthday > DateTime.Now || birthday < new DateTime(1925, 1, 1))
                {
                    throw new ArgumentException("La fecha de nacimiento del cliente no puede ser mayor a la fecha actual o menor a 1925.");
                }

                // Verificar que el ID no exista en la lista
                for (int i = 0; i < clients.Length; i++)
                {
                    if (clients[i] != null && clients[i].Id == idInt)
                    {
                        throw new InvalidOperationException("El ID de cliente ya existe.");
                    }
                }

                // Agregar el cliente si es posible
                for (int i = 0; i < clients.Length; i++)
                {
                    if (clients[i] == null)
                    {
                        clients[i] = new Client(idInt, name, lastName, secondLastName, birthday, gender);
                        response.Success = true;
                        return response;
                    }
                }

                throw new InvalidOperationException("No se pueden agregar más clientes.");
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

        // Metodo para guardar un doctor

        public static Response SaveDoctor(string id, string name, string lastName, string secondLastName, int state)
            {
                Response response = new()
                {
                    Success = false
                };

                try
                {
                    // Validaciones
                    int idInt;
                    if (!int.TryParse(id, out idInt) || idInt <= 0)
                    {
                        throw new ArgumentException("El ID de consulta debe ser un número positivo mayor que cero.");
                    }
                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ArgumentException("El nombre del cliente no puede estar vacío.");
                    }
                    if (string.IsNullOrEmpty(lastName))
                    {
                        throw new ArgumentException("El apellido paterno del cliente no puede estar vacío.");
                    }
                    if (string.IsNullOrEmpty(secondLastName))
                    {
                        throw new ArgumentException("El apellido materno del cliente no puede estar vacío.");
                    }
                    if (state != 1 && state != 0)
                    {
                        throw new ArgumentException("El estado de consulta debe ser 'Activo' o 'Inactivo'.");
                    }

                    // Verificar que el ID no exista en la lista (puedes eliminar esto si solo quieres guardar en la base de datos)
                    for (int i = 0; i < doctors.Length; i++)
                    {
                        if (doctors[i] != null && doctors[i].Id == idInt)
                        {
                            throw new InvalidOperationException("El ID de doctor ya existe.");
                        }
                    }

                    // Leer la cadena de conexión desde el archivo config.txt
                    string connectionString = File.ReadAllText("config.txt").Trim(); // Asegúrate de que el archivo esté en el directorio correcto
                    Console.WriteLine(connectionString); // Asegúrate de que apunte a la base de datos correcta

                // Guardar en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                    //esta es el query que conecta savedoctors con la base de datos
                        string query = "INSERT INTO Doctores (Id, Nombre, ApellidoPaterno, ApellidoMaterno, EstadoId) " +
                                       "VALUES (@Id, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @EstadoId)";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Id", idInt);
                            cmd.Parameters.AddWithValue("@Nombre", name);
                            cmd.Parameters.AddWithValue("@ApellidoPaterno", lastName);
                            cmd.Parameters.AddWithValue("@ApellidoMaterno", secondLastName);
                            cmd.Parameters.AddWithValue("@EstadoId", state);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                response.Success = true;
                                response.Message = "El doctor se guardó correctamente en la base de datos.";
                            }
                            else
                            {
                                response.Message = "No se pudo guardar el doctor en la base de datos.";
                            }
                        }
                    }

                    // Si deseas guardar también en la lista de doctores (opcional)
                    for (int i = 0; i < doctors.Length; i++)
                    {
                        if (doctors[i] == null)
                        {
                            doctors[i] = new Doctor(idInt, name, lastName, secondLastName, state);
                            return response;
                        }
                    }

                    throw new InvalidOperationException("No se pueden agregar más doctores.");
                }
                catch (ArgumentException 
                ae)
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
            Response response = new()
            {
                Success = false
            };

            try
            {
                if (selectedClientId <= 0)
                {
                    throw new ArgumentException("No se ha seleccionado ningun cliente.");
                }
                for (int i = 0; i < clients.Length; i++)
                {
                    if (clients[i] != null && clients[i].Id == selectedClientId)
                    {
                        clients[i].BirthDate = birthday;
                        clients[i].Gender = gender;
                        response.Success = true;
                        return response;
                    }
                }

                throw new InvalidOperationException("No se pudo actualizar los datos del cliente.");
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
                    throw new ArgumentException("Seleccione la fila a modificar");
                }

                for (int i = 0; i < doctors.Length; i++)
                {
                    if (doctors[i] != null && doctors[i].Id == id)
                    {
                        if (doctors[i].State == 'A')
                        {
                            doctors[i].State = 'I';
                        }
                        else
                        {
                            doctors[i].State = 'A';
                        }
                        response.Success = true;
                        return response;
                    }
                }

                throw new InvalidOperationException("No se pudo cambiar el estado del doctor.");
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

                for (int i = 0; i < doctors.Length; i++)
                {
                    if (doctors[i] != null && doctors[i].Id == id)
                    {
                        doctors[i] = null;
                        response.Success = true;
                        return response;
                    }
                }

                throw new InvalidOperationException("No se pudo eliminar el doctor.");
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
