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

        public Form2(SpravceOsob spravceOsob)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                spravceOsob.Pridej(jmeno: jmenoTextBox.Text, datumNarozeni: narozeninyDateTimePicker.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
