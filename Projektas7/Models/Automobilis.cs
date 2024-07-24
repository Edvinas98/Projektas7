using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas7.Models
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public int Metai { get; set; }

        public Automobilis(string marke, int metai)
        {
            Marke = marke;
            Metai = metai;
        }

        public override string ToString()
        {
            return $"Marke: {Marke}, Metai: {Metai}";
        }
    }
}
