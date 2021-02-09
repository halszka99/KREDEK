using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad1
{
    public partial class FormStartWindow : Form
    {
        // definition of formSimulatorWindow
        FormSimulatorWindow formSimulatorWindow;
        // variable to storage player name
        string yourName = ""; 
        
        public FormStartWindow()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Starting game - opening new window with game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            
            // variable with player name
            yourName = textBoxYourName.Text;
            // creating formSimulatorWindow
            formSimulatorWindow = new FormSimulatorWindow();
            // displaying welcome text
            formSimulatorWindow.textToDisplay = "Welcome " + yourName + "! Enjoy your game!";
            // hiding main window
            this.Hide();
            // showing formSimulatorWindow
            formSimulatorWindow.ShowDialog();
            // closing main window 
            this.Close();

        }

    }
}
