using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudentID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Firstname { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string Middlename { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Lastname { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        [Required]
        public string Gender { get; set; } = "";

        [Column(TypeName = "int")]
        [Required]
        public int Age { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateTime Birthdate { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateTime CreatedON { get; set; }

        [Column(TypeName = "varchar(11)")]
        [Required]
        public string StudentCode { get; set; } = "";

        [Required]
        public int Createdby { get; set; }

        [ForeignKey(nameof(Createdby))]
        public User User { get; set; }
    }
}
