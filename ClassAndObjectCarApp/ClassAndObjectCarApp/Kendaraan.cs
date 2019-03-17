using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectCarApp
{
    abstract public class Kendaraan
    {
        protected int jumlahRoda;
        protected int jumlahPenumpang;
        protected bool memilikiMesin;
        protected string merk;
        protected string model;

        abstract public void Bergerak();
        abstract public void Berhenti();

        public override string ToString()
        {
            return this.merk + this.model;
        }

        public Kendaraan(string merk, string model, bool memilikiMesin, int jumlahRoda, int jumlahPenumpang)
        {
            this.merk = merk;
            this.model = model;
            this.memilikiMesin = memilikiMesin;
            this.jumlahRoda = jumlahRoda;
            this.jumlahPenumpang = jumlahPenumpang;
        }

        public Kendaraan()
        {

        }
    }
}
