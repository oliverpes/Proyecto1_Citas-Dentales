using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities
{
    public class Doctor : Person
    {
        public int State { get; set; }

        //constructor vacio
        public Doctor() { }

        //constructores para el data grid 


        //Constructor con parametros

        public Doctor(int id, string name, string lastName, string secondLastName, int stateId)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            State = stateId;
        }

    }
    
    
    }
