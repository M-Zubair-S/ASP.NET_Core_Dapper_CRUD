using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentData.Models.Domain
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string? Product { get; set; }
        public string? Discription { get; set; }
        public DateTime? Created { get; set; }
    }
}
