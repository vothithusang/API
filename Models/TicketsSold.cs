using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TicketsSold
    {
        [Key]
        public string Ticket_ID { get; set; }
        public string Bill { get; set; }
        public string NumberOfSold { get; set; }
        public string Staff_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Flight_ID { get; set; }
    }
}
