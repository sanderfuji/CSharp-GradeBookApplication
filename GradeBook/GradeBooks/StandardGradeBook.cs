using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isweighted) : base(name, isweighted)
        {
            Name = name;
            isWeighted = isweighted;
            Type = Enums.GradeBookType.Standard;
            isWeighted = isWeighted;
        }
    }
}
