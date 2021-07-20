using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DetailTicket
    {
        [Key]
        public string Ticket_ID { get; set; }
        public string Flight_ID { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
        public string RemainAmount { get; set; }
        public string Price { get; set; }
    }
}
