using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Osoba
    {
        public string Jmeno { get; set; }
        public DateTime Narozeniny { get; set; }
        public string Email { get; set; }

        public Osoba(string jmeno, DateTime narozeniny, string email)
        {
            Jmeno = jmeno;
            Narozeniny = narozeniny;
            Email = email;
        }

        public int SpoctiVek()
        {
            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - Narozeniny.Year;
            if (dnes < Narozeniny.AddYears(vek))
                vek--;
            return vek;
        }

        public int ZbyvaDni()
        {
            DateTime dnes = DateTime.Today;
            DateTime dalsiNarozeniny = Narozeniny.AddYears(SpoctiVek() + 1);

            TimeSpan rozdil = dalsiNarozeniny - DateTime.Today;
            return Convert.ToInt32(rozdil.TotalDays);
        }

        public override string ToString()
        {
            return Jmeno;
        }


    }
}
