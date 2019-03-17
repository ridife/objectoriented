using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectCarApp
{
    public static class Bengkel
    {
        public static void Servis(Kendaraan kendaraan)
        {
            Console.WriteLine("Services rutin:" + kendaraan.ToString());
        }

        
    }
}
