using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities
{
    public class QueryType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public char State { get; set; }

        public QueryType(int id, string description, char state)
        {
            Id = id;
            Description = description;
            State = state;
        }
    }
}
