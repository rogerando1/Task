using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Sample.Models
{
    public class User
    {
        [Key]
        [AllowNull] 
        public int userID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Fullname { get; set; } = "";

        [Column(TypeName = "varchar(10)")]
        public string Gender { get; set; } = "";

        [Column(TypeName = "int")]
        public int Age { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Username { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; } = "";
    }
}
