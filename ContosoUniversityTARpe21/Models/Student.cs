namespace ContosoUniversityTARpe21.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int MyProperty { get; set; }
       
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
