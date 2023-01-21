using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var post = new Posts()
            { 
             PostID= 1,
             Title="My FirstDatabase Demo",
             Body="Body",
             DatePublishded= DateTime.Now,
            
            };

            context.Posts.Add(post);
            context.SaveChanges();  

        }
    }
}
