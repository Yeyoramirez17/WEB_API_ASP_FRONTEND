using System.ComponentModel.DataAnnotations;

namespace WEB_API_FRONTEND.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(15, ErrorMessage = "Maximo 15 Caracteres")]
        public string Identification { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Student() {}
    }
}