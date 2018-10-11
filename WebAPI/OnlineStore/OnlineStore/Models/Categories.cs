using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Categories
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Ett kategorinamn")]
        public string Name { get; set; }
    }
}
