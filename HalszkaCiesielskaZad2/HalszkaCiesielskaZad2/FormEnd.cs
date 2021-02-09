using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad2
{
    public partial class FormEnd : Form
    {
        // definition of formMain
        FormMain formMain;
        public FormEnd()
        {
            InitializeComponent();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            // creating new formMain to play again
            formMain = new FormMain();
            // hiding formEnd
            this.Hide();
            // showing formMain
            formMain.ShowDialog();
            // closing formEnd
            this.Close();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            // closing all application
            this.Close();
        }
    }
}
