using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TICKETS.Entities
{
    public class Ticket
    {
       public int id { get; set; }
       public string usuario { get; set; }
       public DateTime fcreacion { get; set; } 
        public DateTime factualizacion { get; set; }
        public string  idestado { get; set; }
    }
}
