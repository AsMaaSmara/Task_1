using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public static class StudentExtensions
    {
        public static void PrintStudentList(this List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} score {student.Score}");
            }
        }

        public static Student studentTopScorer(this List<Student> students)
        {
            return students.OrderByDescending(s => s.Score).First();
        }
    }
}
