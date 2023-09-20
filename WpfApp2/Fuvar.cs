using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Fuvar
    {
        int taxiAzon;
        string indulasIdopont;
        int utazasTartam;
        double megtettTavolsag;
        double viteldij;
        double borravalo;
        string fizetésMod;
        public Fuvar(string csvSor)
        {
            var mezo = csvSor.Split(";");
            this.taxiAzon = int.Parse(mezo[0]);
            this.IndulasIdopont = mezo[1];
            this.utazasTartam = int.Parse(mezo[2]);
            this.megtettTavolsag = double.Parse(mezo[3]);
            this.viteldij = double.Parse(mezo[4]);
            this.borravalo = double.Parse(mezo[5]);
            this.fizetésMod = mezo[6];

        }
        public int TaxiAzon { get => taxiAzon; set => taxiAzon = value; }
        public string IndulasIdopont { get => indulasIdopont; set => indulasIdopont = value; }
        public int UtazasTartam { get => utazasTartam; set => utazasTartam = value; }
        public double MegtettTavolsag { get => megtettTavolsag; set => megtettTavolsag = value; }
        public double Viteldij { get => viteldij; set => viteldij = value; }
        public double Borravalo { get => borravalo; set => borravalo = value; }
        public string FizetésMod { get => fizetésMod; set => fizetésMod = value; }
    }

}
