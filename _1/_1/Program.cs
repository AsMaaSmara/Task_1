using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());

            List<Student> Students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                Console.WriteLine($"Enter the name of student {i + 1}: ");
                student.Name = Console.ReadLine();

                int score = int.Parse(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine($"Enter the score of student {i + 1} (0-100): ");
                    if (score >= 0 && score <= 100)
                    {
                        student.Score = score;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid score! Please enter a value between 0 and 100.");
                    }
                }
                Students.Add(student);
            }

            ScoreProcessor.ScoreProcessorFilter(Students,student => student.Score >= 50);
            ScoreProcessor.ScoreProcessorFilter(Students, student => student.Score < 50);
        }
    }
}
