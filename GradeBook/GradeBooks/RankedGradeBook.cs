using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) :base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            char grade = new char();
            int position = new int();
            List<double> averageGrades = new List<double>();

            var count = Students.Count;
            var bracketsize = count / 5;
            if (count < 5)
            {
                throw new InvalidOperationException("You cannot grade with less than 5 students.");        
            }

            foreach (var student in Students)
            {
                averageGrades.Add(student.AverageGrade);


            }

            averageGrades.Sort();

            for (int i = 0; i <= averageGrades.Count; i++)
            {
                if (averageGrade < averageGrades[i])
                {
                    continue;
                }
                else
                {
                    position = i; 
                }
            }

            if(position <= bracketsize)
            {
                grade =  'A';
            }
            if (position <= bracketsize*2)
            {
                grade = 'B';
            }
            if (position <= bracketsize*3)
            {
                grade = 'C';
            }
            if (position <= bracketsize*4)
            {
                grade = 'D';
            }



            return grade;
        }
    }
}
