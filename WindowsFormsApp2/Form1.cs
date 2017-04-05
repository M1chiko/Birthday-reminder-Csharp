using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PrehledForm : Form
    {
        private SpravceOsob spravceOsob = new SpravceOsob();

        public PrehledForm()
        {
            InitializeComponent();

            dnesLabel.Text = DateTime.Now.ToLongDateString();
            osobyListBox.DataSource = spravceOsob.Osoby;
            this.ObnovNejblizsi();
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            Form2 osobaForm = new Form2(spravceOsob);
            osobaForm.ShowDialog();
            this.ObnovNejblizsi();
        }

        private void odebratButton_Click(object sender, EventArgs e)
        {
            if (osobyListBox.SelectedItem != null)
            {
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
                monthCalendar1.SelectionStart = vybrana.Narozeniny;
            }
        }
    }
}
