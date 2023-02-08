using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = CourseLevel.Intermideate;
            Console.WriteLine((int)course.Level);

            
        }
    }
}
