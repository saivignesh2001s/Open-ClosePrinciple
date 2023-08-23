using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal abstract class Course
    {
        public int courseid { get; set; }
        public string coursename { get; set; }
        public abstract void subscribe(Student std,Course cs);
    }
    internal class onlinecourse : Course
    {
       
        public override void subscribe(Student std,Course cs)
        {
            Console.WriteLine($"{std.Name} registered the online course {cs.coursename}");
        }
    }
    internal class offlinecourse : Course {
        public override void subscribe(Student std, Course cs)
        {
            Console.WriteLine($"{std.Name} registered the offline course {cs.coursename}");
        }

    }

}
