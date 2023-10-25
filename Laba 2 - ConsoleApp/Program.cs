using Laba_2___ConsoleApp.Construction;
using System;


namespace Laba2
{
    class Program
    {

        static void Main(string[] args)
        {
            var constr = new Construction(75, 32, 20, 15, 7, "Wood");
            Console.WriteLine(constr.Builders);
            Console.WriteLine(constr.BuildMaterial);
        }
    }
}

