using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public QueryType QueryType { get; set; }
        public Client Client { get; set; }
        public Doctor Doctor { get; set; }
        public string State { get; set; } // <- Nueva propiedad

        // Constructor vacío
        public Appointment() { }

        // Constructor original sin estado
        public Appointment(int id, DateTime date, QueryType queryType, Client client, Doctor doctor)
        {
            Id = id;
            Date = date;
            QueryType = queryType;
            Client = client;
            Doctor = doctor;
        }

        // Nuevo constructor con estado
        public Appointment(int id, DateTime date, QueryType queryType, Client client, Doctor doctor, string state)
        {
            Id = id;
            Date = date;
            QueryType = queryType;
            Client = client;
            Doctor = doctor;
            State = state;
        }
    }
}
