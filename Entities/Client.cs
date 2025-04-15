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

        public Client(int id, string name, string lastName, string secondLastName, DateTime birthDate, char gender)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            BirthDate = birthDate;
            Gender = gender;
        }

    }
}
