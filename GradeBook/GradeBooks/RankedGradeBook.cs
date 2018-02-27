using System;
using System.Collections.Generic;
using System.Linq;
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
            

            var count = Students.Count;
            var bracketsize = (int)Math.Ceiling(count * 0.2);
            var averagegrades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            if (count < 5)
            {
                throw new InvalidOperationException("You cannot grade with less than 5 students.");        
            }

            if (averagegrades[bracketsize-1] <= averageGrade)
            {
                return 'A';
            }
            if (averagegrades[(bracketsize*2) - 1] <= averageGrade)
            {
                return 'B';
            }
            if (averagegrades[(bracketsize*3) - 1] <= averageGrade)
            {
                return 'C';
            }
            if (averagegrades[(bracketsize*4) - 1] <= averageGrade)
            {
                return 'D';
            }


            
            return 'F';
        }
    }
}
