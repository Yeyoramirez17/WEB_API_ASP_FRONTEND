using System.ComponentModel.DataAnnotations;

namespace WEB_API_FRONTEND.Models
{
    public class Course
    {
        public int IdCourse { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(20, ErrorMessage = "Maximo 20 Caracteres")]
        public string NameCourse { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Hours { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int IdFaculty { get; set; }
    }
}