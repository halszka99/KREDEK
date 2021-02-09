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
 
    public partial class FormEndGame : Form
    {
        // definition of formSimulatorWindow
        FormSimulatorWindow formSimulatorWindow;
        // variable to storage text to display at the end of the game
        public string textEndToDisplay = "";
        public FormEndGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loading formEndGame 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEndGame_Load(object sender, EventArgs e)
        {
            // assigning text to display to labelEndGame
            labelEndGame.Text = textEndToDisplay;

        }
        /// <summary>
        /// Launching a new game. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            // creating new formSimulatorWindow to play again
            formSimulatorWindow = new FormSimulatorWindow();
            // hiding formEndGame
            this.Hide();
            // showing formSimulatorWindow
            formSimulatorWindow.ShowDialog();
            // closing formEndGame
            this.Close();

        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            // closing formEndGame and the whole game 
            this.Close(); 
        }
    }
}
