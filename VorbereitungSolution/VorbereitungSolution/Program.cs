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
            Artist a1 = new Artist(){
                Name = "Huber"
            };

            // equivalent zu

            Artist a2 = new Artist("Huber");




            Console.WriteLine(a1.Name);

            //Damit das Programm nicht sofort beendet.
            Console.ReadLine();
        }
    }
}
