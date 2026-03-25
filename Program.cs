using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentEntity())
            {
                // Create a new student
                var student = new Student
                {
                    Id = 1,
                    firstName = "John",
                    lastName = "Doe",
                    DoB = new DateTime(2000, 1, 15),
                    address = "123 Main Street",
                    AverageScore = 85
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Name: {student.firstName} {student.lastName}");
                Console.WriteLine($"ID: {student.Id}");
                
                Console.ReadLine();
            }
        }
    }
}
