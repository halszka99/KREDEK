using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Create steam command class
    /// </summary>
    public class CreateSteamCommand : ICommand
    {
        /// <summary>
        /// Method to execute create steam command
        /// </summary>
        public void Execute()
        {
            // creating new formCreated
            FormCreated formCreated = new FormCreated();
            // setting labelCreated text 
            formCreated.labelCreated.Text = "STEAM CREATED!";
            // setting pictureBox size mode
            formCreated.pictureBoxCreated.SizeMode = PictureBoxSizeMode.StretchImage;
            // setting pictureBox image
            formCreated.pictureBoxCreated.Image = Properties.Resources.water_steam; 
            // showing formCreated
            formCreated.ShowDialog(); 
        }
    }
}
