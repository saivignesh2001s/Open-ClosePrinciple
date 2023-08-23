namespace Open_ClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Ranga";
            Course course = new onlinecourse();
            course.courseid = 1;
            course.coursename = "C++";
            course.subscribe(student, course);
            Course course1 = new offlinecourse();
            course1.courseid = 2;
            course1.coursename = "C#";
            course1.subscribe(student, course1);
        }
    }
}