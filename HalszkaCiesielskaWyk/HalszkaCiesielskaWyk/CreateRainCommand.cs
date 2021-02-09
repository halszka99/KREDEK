using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Create rain command class
    /// </summary>
    public class CreateRainCommand : ICommand
    {
        /// <summary>
        /// Method to execute create rain command
        /// </summary>
        public void Execute()
        {
            // creating new formCreated
            FormCreated formCreated = new FormCreated();
            // setting labelCreated text 
            formCreated.labelCreated.Text = "RAIN CREATED!";
            // setting pictureBox size mode
            formCreated.pictureBoxCreated.SizeMode = PictureBoxSizeMode.StretchImage;
            // setting pictureBox image
            formCreated.pictureBoxCreated.Image = Properties.Resources.rain;
            // showing formCreated
            formCreated.ShowDialog();
        }
    }
}
