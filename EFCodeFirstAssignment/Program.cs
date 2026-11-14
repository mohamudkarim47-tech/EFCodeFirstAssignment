using System;
using System.Data.Entity;

namespace EFCodeFirstAssignment
{
    // 1. The Student Class (Entity)
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    // 2. The Context Class
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
    }

    // 3. The Main Application
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                // Create a new Student
                var stud = new Student() { StudentName = "John Doe" };

                // Add the student to the DbSet
                ctx.Students.Add(stud);

                // Save changes to the database
                ctx.SaveChanges();

                Console.WriteLine("Student added successfully to the Code-First database!");
                Console.ReadLine();
            }
        }
    }
}