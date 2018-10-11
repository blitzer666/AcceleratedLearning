using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter product name")]
        [MaxLength(40, ErrorMessage = "Name cannot be longer than 40 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter 0-1000")]
        [Range(1,1000, ErrorMessage = "Price must be between 1 och 1000")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Use digits")]
        [Display(Name="Price")]
        public Decimal Price { get; set; }
        public bool Forsales { get; set; }


        [Display(Name = "Category")]

        public Categories Category { get; set; }
        public int CategoryId { get; set; }
       




    }
}
