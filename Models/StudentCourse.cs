namespace WEB_API_FRONTEND.Models
{
    public class StudentCourse
    {
        public int IdStudent { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string Identification { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Course> Courses { get; set; } = new List<Course>();

    }
}