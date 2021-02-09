using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Create lava command class
    /// </summary>
    public class CreateLavaCommand : ICommand
    {
        /// <summary>
        /// Method to execute create lava command
        /// </summary>
        public void Execute()
        {
            // creating new formCreated
            FormCreated formCreated = new FormCreated();
            // setting labelCreated text 
            formCreated.labelCreated.Text = "LAVA CREATED!";
            // setting pictureBox size mode
            formCreated.pictureBoxCreated.SizeMode = PictureBoxSizeMode.CenterImage;
            // setting pictureBox image
            formCreated.pictureBoxCreated.Image = Properties.Resources.lava;
            // showing formCreated
            formCreated.ShowDialog();
        }
    }
}
