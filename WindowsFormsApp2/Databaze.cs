using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Databaze
    {
        private string soubor;
        public BindingList<Osoba> Osoby { get; set; }
        

        public Databaze(string soubor)
        {
            Osoby = new BindingList<Osoba> ();
            this.soubor = soubor;
        }

        public void Pridej(string jmeno, DateTime datumNarozeni, string email)
        {
            if (jmeno.Length < 3)
                throw new ArgumentException("Jméno je příliš krátké");
            if (datumNarozeni.Date > DateTime.Today)
                throw new ArgumentException("Datum narození nesmí být v budoucnosti");
            if (PlatnyEmail(email) == false)
                throw new ArgumentException("Emailová adresa není zadaná ve správném formátu");
            Osoba osoba = new Osoba(jmeno, datumNarozeni.Date, email);
            Osoby.Add(osoba);
        }

        public void Odeber(Osoba osoba)
        {
            Osoby.Remove(osoba);
        }

        public Osoba NajdiNejblizsi()
        {
            var serazeneOsoby = Osoby.OrderBy(o => o.ZbyvaDni());
            return serazeneOsoby.First();
        }

        public bool PlatnyEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public Osoba[] VratVsechny()
        {
            return Osoby.ToArray();
        }

        public void Uloz()
        {
            // otevření souboru pro zápis
            using (StreamWriter sw = new StreamWriter(soubor))
            {
                // projetí osob
                foreach (Osoba o in Osoby)
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
            Osoby.Clear();
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
                    Pridej(jmeno, narozeniny, email);
                }
            }
        }
    }
}
