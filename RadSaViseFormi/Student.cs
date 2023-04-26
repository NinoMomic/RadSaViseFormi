using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaViseFormi
{
    internal class Student
    {
        private string ime;
        private string prezime;
        private string brojIndeksa;
        private DateTime datumRodjenja;
        private string smjer;

        private string Ime { get => ime; set => ime = value; }
        private string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value;}
        private DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        private string Prezime { get => prezime; set => prezime = value; }
        private string Smjer { get => smjer; set => smjer = value; }

        public override string ToString()
        {
            
        }

    }
}
