using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirLineAPI.Models
{
    public class Location
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
