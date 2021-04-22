using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            switch (averageGrade)
            {
                case double d when d >= 80:
                    return 'A';
                case double d when d >= 60 && d < 80:
                    return 'B';
                case double d when d >= 40 && d < 60:
                    return 'C';
                case double d when d >= 20 && d < 40:
                    return 'D';

            }
            return 'F';
        }
    }
}
