using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int? GeneratedId { get; set; } // Nuevo campo para el ID generado
    }

}
