using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Plane
    {
        [Key]
        public string Plane_ID { get; set; }
        public string PlaneName { get; set; }
        public string PlaneManufacturer { get; set; }
        public string PlaneSize { get; set; }
        public string FistClassSeats { get; set; }
        public string SecondClassSeats { get; set; }
        public string Total { get; set; }
    }
}
