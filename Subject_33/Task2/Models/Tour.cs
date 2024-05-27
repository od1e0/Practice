using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        public string TourName { get; set; }

        [InverseProperty("Tour")]
        public virtual ICollection<Tourist> Tourists { get; set; }
    }
}
