using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2Form_Cs
{
    public partial class StartForm : Form
    {
        private Form2 myForm;
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStartForm2_Click(object sender, EventArgs e)
        {
            tbxInfo.Text = "myForm gestartet";
            myForm = new Form2();
            myForm.Show();
            // Event abonieren
            myForm.DatenForm2 += MyForm_DatenForm2;
            //myForm.Close(); 

        }

        // Ereignisbehandler -> Event abarbeiten
        private void MyForm_DatenForm2(string[] Result)
        {

            if (Result.Length > 0 )
            {
                foreach (string Werte in Result)
                {
                    tbxInfo.Text = "Arry[" + (Result.Length) + "] Einträge";
                    lbxAntwort.Items.Add(Werte);
                }
                myForm.Close();

            }
            else
            {
                tbxInfo.Text = "Keine Antwortdaten";
            }
        }
    }
}
