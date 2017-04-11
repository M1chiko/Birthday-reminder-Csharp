using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Databaze
    {
        private SpravceOsob spravceOsob = new SpravceOsob();
        private string soubor;
        

        public Databaze(string soubor)
        {
            this.soubor = soubor;
        }

        public void PridejOsobu(string jmeno, DateTime datumNarozeni, string email)
        {
            spravceOsob.Pridej(jmeno, datumNarozeni, email);
        }

        public Osoba[] VratVsechny()
        {
            return spravceOsob.Osoby.ToArray();
        }

        public void Uloz()
        {
            // otevření souboru pro zápis
            using (StreamWriter sw = new StreamWriter(soubor))
            {
                // projetí osob
                foreach (Osoba o in spravceOsob.Osoby)
                {
                    // vytvoření pole hodnot
                    string[] hodnoty = { o.Jmeno, o.Narozeniny.ToShortDateString(), o.Email};
                    // vytvoření řádku
                    string radek = String.Join(";", hodnoty);
                    // zápis řádku
                    sw.WriteLine(radek);
                }
                // vyprázdnění bufferu
                sw.Flush();
            }
        }

        public void Nacti()
        {
            spravceOsob.Osoby.Clear();
            // Otevře soubor pro čtení
            using (StreamReader sr = new StreamReader(soubor))
            {
                string s;
                // čte řádek po řádku
                while ((s = sr.ReadLine()) != null)
                {
                    // rozdělí string řádku podle středníků
                    string[] rozdeleno = s.Split(';');
                    string jmeno = rozdeleno[0];
                    DateTime narozeniny = DateTime.Parse(rozdeleno[1]);
                    string email = rozdeleno[2]; 
                    // přidá uživatele s danými hodnotami
                    PridejOsobu(jmeno, narozeniny, email);
                }
            }
        }
    }
}
