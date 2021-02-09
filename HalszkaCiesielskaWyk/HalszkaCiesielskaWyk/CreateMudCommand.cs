using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Create mud command class
    /// </summary>
    public class CreateMudCommand : ICommand
    {
        /// <summary>
        /// Method to execute create mud command
        /// </summary>
        public void Execute()
        {
            // creating new formCreated
            FormCreated formCreated = new FormCreated();
            // setting labelCreated text 
            formCreated.labelCreated.Text = "MUD CREATED!";
            // setting pictureBox size mode
            formCreated.pictureBoxCreated.SizeMode = PictureBoxSizeMode.CenterImage;
            // setting pictureBox image
            formCreated.pictureBoxCreated.Image = Properties.Resources.mud;
            // showing formCreated
            formCreated.ShowDialog();
        }
    }
}
