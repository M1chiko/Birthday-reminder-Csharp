﻿using System;
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
        private Databaze databaze;
        

        public PrehledForm()
        {
            InitializeComponent();
            databaze = new Databaze("osoby.csv");
            osobyListBox.DataSource = spravceOsob.Osoby;
            dnesLabel.Text = DateTime.Now.ToLongDateString();
            this.ObnovNejblizsi();
        }

        private void pridatButton_Click(object sender, EventArgs e)
        {
            try
            {
                osobyListBox.DataSource = spravceOsob.Osoby;
                spravceOsob.Pridej(jmeno: jmenoTextBox.Text, datumNarozeni: datumNarozeniDateTimePicker.Value);
                databaze.PridejOsobu(jmeno: jmenoTextBox.Text, datumNarozeni: datumNarozeniDateTimePicker.Value);
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
    }
}
