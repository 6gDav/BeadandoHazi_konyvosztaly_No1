using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BeadandoHazi_konyvosztaly_No1
{
    internal class Konyv
    {
        private string _cim { get; set; }
        private string _szerzo { get; set; }
        private int _oldalszam { get; set; }
        private double _ar { get; set; }

        public string Cim
        { 
            get => _cim;
            set => _cim = value;
        }

        public string Szerzo
        { 
            get => _szerzo;
            set => _szerzo = value;
        }

        public int Oldalszam
        {
            get => _oldalszam;
            set => _oldalszam = value;
        }

        public double Ar
        {
            get => _ar;
            set => _ar = value;
        }

        public Konyv(string cim, string szerzo, int oldalszam, double ar)
        {
            this.Cim = cim;
            this.Szerzo = szerzo;
            this.Oldalszam = oldalszam;
            this.Ar = ar;
        }

        public Konyv(string cim, string szerzo, int oldalszam) : this(cim, szerzo, oldalszam, 3_000)
        {

        }

        public override string ToString()
        {
            return $"Cim: {this.Cim}, Szezo: {this.Szerzo}, Oldalszam: {this.Oldalszam}, Ar: {this.Ar}";
        }

        public void Vastag_e()
        {
            if (this.Oldalszam > 500) Console.WriteLine("Vastag");
        }

        public void Draga_e() 
        {
            if (this.Ar > 5_000) Console.WriteLine("Draga");
        }
    }
}
