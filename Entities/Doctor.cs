using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities
{
    public class Doctor : Person
    {
        public char State { get; set; }

        public Doctor(int id, string name, string lastName, string secondLastName, char state)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            State = state;
        }
    }
    
    
    }
