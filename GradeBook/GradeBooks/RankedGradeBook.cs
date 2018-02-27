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
            var count = Students.Count;
            if(count < 5)
            {
                throw new InvalidOperationException("You cannot grade with less than 5 students.");

                
            }
            return grade;
        }
    }
}
