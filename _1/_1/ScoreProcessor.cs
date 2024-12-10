using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public static class ScoreProcessor
    {
        public delegate bool ScoreCriteria(Student student);

        public static List<Student> ScoreProcessorFilter(List<Student> students,ScoreCriteria scoreCriteria)
        {
            List<Student> filteredStudents = new List<Student>();  

            foreach (var student in students)  
            {
                if (scoreCriteria(student))  
                {
                    filteredStudents.Add(student);  
                }
            }

            return filteredStudents;
        }
    }
}
