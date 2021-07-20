using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class FlightRoute
    {
        [Key, Column(Order = 0)]
        public string Route_ID { get; set; }
        public string Location { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Status { get; set; }
    }
}
