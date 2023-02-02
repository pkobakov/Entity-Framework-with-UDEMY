﻿using System;
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
            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }

            
        }
    }
}
