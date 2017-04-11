using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class SpravceOsob
    {
        public BindingList<Osoba> Osoby { get; set; }

        public SpravceOsob()
        {
            Osoby = new BindingList<Osoba>();
        }

        public void Pridej (string jmeno, DateTime datumNarozeni, string email)
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

        public void Odeber (Osoba osoba)
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
    }
}
