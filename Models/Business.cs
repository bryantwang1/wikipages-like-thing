using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wikipages.Models
{
    [Table("Businesses")]
    public class Business
    {
        [Key]
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessDescription { get; set; }
        public string BusinessPhone { get; set; }
        public string BusinessStreet { get; set; }
        public string BusinessCity { get; set; }
        public string BusinessState { get; set; }
        public string BusinessZip { get; set; }
        public int CategoryId { get; set; } 
    }

}
