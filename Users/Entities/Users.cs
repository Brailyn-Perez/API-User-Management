using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Users.Core;

namespace Users.Entities
{
    public sealed class Users : AuditoryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
