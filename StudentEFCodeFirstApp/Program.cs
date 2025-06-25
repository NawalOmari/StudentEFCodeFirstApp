using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                // Add student to context
                context.Students.Add(student);

                // Save to database
                context.SaveChanges();

                Console.WriteLine("Student added successfully.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
