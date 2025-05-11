using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Client : Person
    {
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public int StateId { get; set; }
        //constructor vacio
        public Client() { }

        //constructores para el data grid 
        public Client(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = "";
            BirthDate = DateTime.MinValue;
            Gender = 'M';
            StateId = 1;
        }


        //constructor con parametros


        public Client(int id, string name, string lastName, string secondLastName, DateTime birthDate, char gender, int stateId)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            BirthDate = birthDate;
            Gender = gender;
            StateId = stateId;
        }
    }
}

