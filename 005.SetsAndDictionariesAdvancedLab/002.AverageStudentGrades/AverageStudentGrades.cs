using System;
using System.Collections.Generic;
using System.Linq;

public class AverageStudentGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

        for(int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split();
            string studentName = tokens[0];
            decimal studentGrade = decimal.Parse(tokens[1]);

            if(!students.ContainsKey(studentName))
            {
                students[studentName] = new List<decimal>();
            }

            students[studentName].Add(studentGrade);
        }

        foreach(var (student, studentGrades) in students)
        {
            decimal avg = studentGrades.Average();

            Console.Write($"{student} -> ");

            foreach(var grade in studentGrades)
            {
                Console.Write($"{grade:F2} ");
            }

            Console.WriteLine($"(avg: {avg:F2})");
        }
    }
}