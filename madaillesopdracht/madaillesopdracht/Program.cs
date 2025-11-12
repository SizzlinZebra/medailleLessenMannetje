using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madaillesopdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("yo");
            Console.WriteLine("hoe heet jij?: ");
            string Input = Console.ReadLine();
            Console.WriteLine("hoe oud ben jij??: ");
            int leeftijdInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoi " + Input + " je bent " + leeftijdInput + " jaar oud");

            



        }
    }
}
