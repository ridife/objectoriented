using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectCarApp
{
    public sealed class F1car : Mobil
    {
        string namaTim;
        

        public F1car(string namaTim, string merk, string model):base(1600,model,merk,1)
        {
            this.namaTim = namaTim;
        }

        public override string ToString()
        {
            return base.merk + base.model + namaTim;
        }

        public override void Bergerak()
        {
            var soundLocation = Environment.CurrentDirectory + @"\";

            SoundPlayer player = new SoundPlayer
            {
                SoundLocation = soundLocation + "f1.wav",
            };
            player.Play();

        }

        public override void Berhenti()
        {
            base.Berhenti();
        }
    }
}
