using System;

namespace OOP_Class
{
    class Program
    {
        Console.WriteLine("I changed something here");
        static void Main(string[] args)
        {
            var student = GetStudent();
            Print(student);
        }
        static void Print(Student student)
        {
            Console.WriteLine(student.firstName);
            Console.WriteLine(student.lastName);
            Console.WriteLine(student.age);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.favouriteColor);
        }
        static Student GetStudent()
        {
            Student student = new Student();

            student.age = 15;
            student.firstName = "Xakimbekov";
            student.lastName = "Doniyorbek";
            student.Id = Guid.NewGuid();
            student.favouriteColor = Color.Orange.ToString();
            return student;
        }
    }
}
