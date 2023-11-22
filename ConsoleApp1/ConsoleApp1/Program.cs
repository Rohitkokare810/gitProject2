using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        
        List<Student> students = ReadStudentData("F:\\mphasis\\practice projects\\2nd project\\student.txt");

        
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
        }
        Console.ReadKey();
    }

    static List<Student> ReadStudentData(string filePath)
    {
        List<Student> students = new List<Student>();

        try
        {
            
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                
                string[] parts = line.Split(',');

                
                Student student = new Student
                {
                    Name = parts[0],
                    Age = int.Parse(parts[1]),
                    Department = parts[2]
                };

                
                students.Add(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return students;
    }
}
