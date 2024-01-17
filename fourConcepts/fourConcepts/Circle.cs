using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourConcepts
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }
}
