using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Flight
    {
        [Key]
        public string Flight_ID { get; set; }
        public string Location { get; set; }
        public string LocationTo { get; set; }
        public string StartTime { get; set; }
        public string Route_ID { get; set; }
        public string Plane_ID { get; set; }
        public string EndDate { get; set; }
        public string Note { get; set; }
        public string StartDate { get; set; }
        public string FlightTime { get; set; }
    }
}
