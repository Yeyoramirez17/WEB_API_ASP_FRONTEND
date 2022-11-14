using System.ComponentModel.DataAnnotations;

namespace WEB_API_FRONTEND.Models
{
    public class Faculty
    {
        public int IdFaculty { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(100, ErrorMessage = "Max. 100 Carateres")]
        public string NameFaculty { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(80, ErrorMessage = "Max. 80 Carateres")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(80, ErrorMessage = "Max. 80 Carateres")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(80, ErrorMessage = "Max. 80 Carateres")]
        public string Email { get; set; } = string.Empty;

        public Faculty() {}
        public Faculty(int idFaculty, string nameFaculty, string address, string phone, string email){
            IdFaculty = idFaculty;
            NameFaculty = nameFaculty;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}