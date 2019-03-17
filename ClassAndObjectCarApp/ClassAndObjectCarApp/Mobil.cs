using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectCarApp
{
    public class Mobil : Kendaraan
    {
        protected int kapasitasMesin;

        public Mobil(int kapasitasMesin, string model, string merk, int jumlahPenumpang) : base(merk, model, true, 4, jumlahPenumpang)
        {
            this.kapasitasMesin = kapasitasMesin;
        }

        public override void Bergerak()
        {
            Console.WriteLine("The wheels on the car go round and round Round and round, " +
                "round and round The wheels on the car go round and round All through the town");
        }

        public override void Berhenti()
        {
            Console.WriteLine("The door on the car open and shut");
        }

        
    }
}
