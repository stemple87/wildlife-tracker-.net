using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildlife_tracker.Models
{
    [Table("Animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
    }
}