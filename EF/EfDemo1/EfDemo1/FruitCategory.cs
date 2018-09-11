
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDemo1
{
    public class FruitCategory
    {
        // [Table("FruktKatten")] byter namn på tabellen
        public int Id { get; set; }

        [Required] // Blir NOT NULL i databasen
        [StringLength(20)] // Blir nvarchar(20) i databasen. Om för många tecken läggs in i namnet så kraschar databasen
        [RegularExpression("abc")] // Påverkar inte databasen
        public string Name { get; set; }

        public List<Fruit> Fruits { get; set; } // påverkar inte migreringen att denna läggs till

        [NotMapped]
        public string Hej { get; set; } // skickas inte till databasen

    }
}
