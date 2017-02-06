using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wikipages.Models;

namespace Wikipages.Models
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            this.Businesses = new HashSet<Business>();
        }

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }
    }
}