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
    public partial class Form2 : Form
    {
        private SpravceOsob spravceOsob;
        private Databaze databaze;

        public Form2(SpravceOsob spravceOsob)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
            databaze = new Databaze("osoby.csv");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                spravceOsob.Pridej(jmeno: jmenoTextBox.Text, datumNarozeni: narozeninyDateTimePicker.Value);
                databaze.PridejOsobu(jmeno: jmenoTextBox.Text, datumNarozeni: narozeninyDateTimePicker.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
