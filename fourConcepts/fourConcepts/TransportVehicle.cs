using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourConcepts
{
    public class TransportVehicle
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("Перемiщення зi швидiстю " + Speed + " км/год");
        }
    }
}
