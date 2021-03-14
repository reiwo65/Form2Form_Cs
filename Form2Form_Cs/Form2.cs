using System;
using System.Windows.Forms;

namespace Form2Form_Cs
{
    public partial class Form2 : Form
    {
        public delegate void DatenForm2_EventHandler(string[] Result);
        public event DatenForm2_EventHandler DatenForm2; // event = spezieller Zugriffsmodifizierer

        public Form2()
        {
            InitializeComponent();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string[] TextArray = new string[] { textBox1.Text , "info" };

            // Event starten wenn es einen Abonnenten gibt
            if (DatenForm2 != null)
            {
                DatenForm2(TextArray);
            }
        }
    }
}
