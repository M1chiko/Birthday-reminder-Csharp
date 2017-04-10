using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PrehledForm : Form
    {
        private SpravceOsob spravceOsob = new SpravceOsob();
        private Databaze databaze;
        

        public PrehledForm()
        {
            InitializeComponent();
            databaze = new Databaze("osoby.csv");
            osobyListBox.DataSource = spravceOsob.Osoby;
            dnesLabel.Text = DateTime.Now.ToLongDateString();
            this.ObnovNejblizsi();
            dnesLabel.Text = "";
            nejblizsiLabel.Text = "";
            narozeninyLabel.Text = "";
            vekLabel.Text = "";
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            try
            {
                osobyListBox.DataSource = spravceOsob.Osoby;
                spravceOsob.Pridej(jmeno: jmenoTextBox.Text, datumNarozeni: datumNarozeniDateTimePicker.Value, email: emailTextBox.Text);
                databaze.PridejOsobu(jmeno: jmenoTextBox.Text, datumNarozeni: datumNarozeniDateTimePicker.Value, email: emailTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.ObnovNejblizsi();
        }

        private void odebratButton_Click(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {
                osobyListBox.DataSource = spravceOsob.Osoby;
                spravceOsob.Odeber((Osoba)osobyListBox.SelectedItem);
                this.ObnovNejblizsi();
            }
        }

        private void ObnovNejblizsi()
        {
            if (spravceOsob.Osoby.Count > 0)
            {
                Osoba nejblizsi = spravceOsob.NajdiNejblizsi();
                int vek = nejblizsi.SpoctiVek();
                if (DateTime.Today != nejblizsi.Narozeniny)
                    vek++;
                nejblizsiLabel.Text = nejblizsi.Jmeno + " (" + vek + " let) za " + nejblizsi.ZbyvaDni() + " dni";
            }
            else
                nejblizsiLabel.Text = "Žádné osoby v seznamu";
        }

        private void osobyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {
                Osoba vybrana = (Osoba)osobyListBox.SelectedItem;
                narozeninyLabel.Text = vybrana.Narozeniny.ToLongDateString();
                vekLabel.Text = vybrana.SpoctiVek().ToString();
                prijemceTextBox.Text = vybrana.Email;
            }
        }

        private void ulozitButton_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Uloz();
            }
            catch
            {
                MessageBox.Show("Databázi se nepodařilo uložit, zkontrolujte přístupová práva k souboru.", "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nacistButton_Click(object sender, EventArgs e)
        {
            try
            {
                databaze.Nacti();
                osobyListBox.DataSource = null;
                osobyListBox.Items.Clear();
                osobyListBox.Items.AddRange(databaze.VratVsechny());
                this.ObnovNejblizsi();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Datábázi se nepodařilo načíst, soubor pravděpodobně neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sendEmail()
        {
            try
            {
                var mail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com", 587);
                mail.From = new MailAddress("martinlearncsharp@gmail.com", "Martin Novotný");
                mail.To.Add(prijemceTextBox.Text);
                mail.Subject = "Všechno nejlepší k narozeninám";
                mail.Body = "Ahoj, přeji ti vše nejlepší k narozeninám";
                //smtpServer.UseDefaultCredentials = false;
                smtpServer.Credentials = new NetworkCredential("martinlearncsharp@gmail.com", "YY__YSWAQ");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            sendEmail();
        }
    }
}
