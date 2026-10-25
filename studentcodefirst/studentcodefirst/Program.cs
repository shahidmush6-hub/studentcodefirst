using studentcodefirst.Data;
using studentcodefirst.Models;

using var context = new SchoolContext();

context.Database.EnsureCreated();

Student student = new Student
{
    Name = "John Smith",
    Age = 20
};

context.Students.Add(student);

context.SaveChanges();

Console.WriteLine("Student saved successfully!");
Console.ReadKey();