using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace WindowsFormsApp2
{
    public partial class PrehledForm : Form
    {
        //public databaze databaze = new databaze();
        private Databaze databaze;

        public PrehledForm()
        {
            InitializeComponent();
            databaze = new Databaze("osoby.csv");
            osobyListBox.DataSource = databaze.Osoby;
            dnesLabel.Text = DateTime.Now.ToLongDateString();
            ObnovNejblizsi();
            nejblizsiLabel.Text = "";
            narozeninyLabel.Text = "";
            vekLabel.Text = "";
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            try
            {
                osobyListBox.DataSource = databaze.Osoby;
                databaze.Pridej(jmeno: jmenoTextBox.Text, datumNarozeni: datumNarozeniDateTimePicker.Value, email: emailTextBox.Text);
                databaze.Pridej(jmeno: jmenoTextBox.Text, datumNarozeni: datumNarozeniDateTimePicker.Value, email: emailTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ObnovNejblizsi();
        }

        private void odebratButton_Click(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {
                osobyListBox.DataSource = databaze.Osoby;
                databaze.Odeber((Osoba)osobyListBox.SelectedItem);
                ObnovNejblizsi();
            }
        }

        private void ObnovNejblizsi()
        {
            if (databaze.Osoby.Count > 0)
            {
                Osoba nejblizsi = databaze.NajdiNejblizsi();
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
                narozeninyLabel.Text = vybrana.Narozeniny.ToShortDateString();
                vekLabel.Text = vybrana.SpoctiVek().ToString();
                prijemceTextBox.Text = vybrana.Email;
            }
            ObnovNejblizsi();
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
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Datábázi se nepodařilo načíst, soubor pravděpodobně neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //ObnovNejblizsi();
        }

        public void OdesliEmail()
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
                ZobrazitNotifikaci("Přání k narozeninám odesláno", "E-mail s přáním k" +
                    " narozeninám byl odeslán vybranému příjemci");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            OdesliEmail();
        }

        public void ZobrazitNotifikaci(string nadpis, string zprava)
        {
            PopupNotifier upozorneni = new PopupNotifier();
            upozorneni.TitleText = nadpis;
            upozorneni.ContentText = zprava;
            upozorneni.Popup();
        }
    }
}
