using ContosoUniversityTARpe21.Models;

namespace ContosoUniversityTARpe21.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student() {FirstName="Kaarel-Martin",LastName="Noole",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student() {FirstName="Marcus",LastName="Toman",EnrollmentDate=DateTime.Parse("2020-09-01")},
                new Student() {FirstName="Rasmus",LastName="Jalakas",EnrollmentDate=DateTime.Parse("2020-09-01")},
                new Student() {FirstName="Erik",LastName="Vilumaa",EnrollmentDate=DateTime.Parse("2020-09-01")},
                new Student() {FirstName="Genri",LastName="Valrusmann",EnrollmentDate=DateTime.Parse("2020-09-01")},
            };
            /*context.Students.AddRange(students);*/
            foreach (Student s in students) 
            { 
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course() {CourseId=1050,Title="Programmeerimine",Credits=160},
                new Course() {CourseId=6900,Title="Keemia",Credits=160},
                new Course() {CourseId=1420,Title="Matemaatika",Credits=160},
                new Course() {CourseId=6666,Title="Testimine",Credits=160},
                new Course() {CourseId=1234,Title="Riigikaitse",Credits=160},
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();
        }

    }
}
