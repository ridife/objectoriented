using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            F1car f1 = new F1car("Red Bull Racing", "Aston Martin", "RB12");
            f1.Bergerak();
            f1.Berhenti();
            Console.ReadKey();

        }
    }
}
