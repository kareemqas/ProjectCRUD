using System.ComponentModel.DataAnnotations;

namespace ProjectCRUD.Models
{
    public class Persons
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,100, ErrorMessage = "Out OF RANG")]
        public int Age { get; set; }
    }
}
