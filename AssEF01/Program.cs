using AssEF01.Contexts;
using AssEF01.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssEF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyContext enteroriseDbContext = new MyContext();

            // Create a new student
            var newStudent = new Student
            {
                FName = "John",
                LName = "Doe",
                Address = "123 Main St",
                Age = 22,
                Dep_Id = 1
            };
            enteroriseDbContext.Students.Add(newStudent);
            enteroriseDbContext.SaveChanges();

            Console.WriteLine("Student added.");

            // Read the student
            var student = enteroriseDbContext.Students.Find(newStudent.ID);
            if (student != null)
            {
                Console.WriteLine($"Retrieved Student: {student.FName} {student.LName}, Age: {student.Age}");
            }


            // Update the student
            student.Address = "456 Elm St";
            enteroriseDbContext.Students.Update(student);
            enteroriseDbContext.SaveChanges(); 
            Console.WriteLine("Student updated.");

            // Get all students
            var allStudents = enteroriseDbContext.Students.ToList();
            Console.WriteLine("All students:");
            foreach (var s in allStudents)
            {
                Console.WriteLine($"{s.FName} {s.LName}, Address: {s.Address}");
            }

            // Delete the student

            var stu = enteroriseDbContext.Students.Find(student.ID);
            if (stu != null)
            {
                enteroriseDbContext.Students.Remove(student);
                enteroriseDbContext.SaveChanges();
            }
            Console.WriteLine("Student deleted.");

            // Display all students after deletion
            var allafterStudents = enteroriseDbContext.Students.ToList();
            Console.WriteLine("All students:");
            foreach (var s in allStudents)
            {
                Console.WriteLine($"{s.FName} {s.LName}, Address: {s.Address}");
            }

        }
    }
}
