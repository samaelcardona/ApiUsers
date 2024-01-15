using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUsers.Domain.Model
{
    public class Users
    {
        [Key]
        public double Id { get; set; }

        [MaxLength(50)]
        [Required]
        public required string Name { get; set; }

        public int Age { get; set; }

        public bool Active { get; set; }

        [MaxLength(50)]
        public string? Role { get; set; }
    }
}
