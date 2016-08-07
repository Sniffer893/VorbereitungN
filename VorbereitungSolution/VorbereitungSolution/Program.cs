using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VorbereitungSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist a1 = new Artist();
            a1.Name = "Geht das?";

            Console.WriteLine(a1.Name);

            //Damit das Programm nicht sofort beendet.
            Console.ReadLine();
        }
    }
}
