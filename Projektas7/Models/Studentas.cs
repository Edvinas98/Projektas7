using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas7.Models
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int Pazymys { get; set; }

        public Studentas(string vardas, int pazymys)
        {
            Vardas = vardas;
            Pazymys = pazymys;
        }

        public bool CheckArIslaike()
        {
            return Pazymys >= 5;
        }
    }
}
