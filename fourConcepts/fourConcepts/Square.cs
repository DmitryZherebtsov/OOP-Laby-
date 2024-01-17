using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourConcepts
{
    internal class Square : IShape
    {
        public double SideLength { get; set; } 

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
