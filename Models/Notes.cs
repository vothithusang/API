using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Notes
    {
        [Key]
        public string Note_ID { get; set; }
        public string Staff_ID { get; set; }
        public string Note { get; set; }
        public string Time { get; set; }
        public string CheckMaster{ get; set; }
        public string CheckStation { get; set; }
    }
}
