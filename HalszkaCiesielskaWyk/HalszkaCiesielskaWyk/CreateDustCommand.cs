using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Create dust command class
    /// </summary>
    public class CreateDustCommand : ICommand
    {
        /// <summary>
        /// Method to execute create dust command
        /// </summary>
        public void Execute()
        {
            // creating new formCreated
            FormCreated formCreated = new FormCreated();
            // setting labelCreated text 
            formCreated.labelCreated.Text = "DUST CREATED!";
            // setting pictureBox size mode
            formCreated.pictureBoxCreated.SizeMode = PictureBoxSizeMode.CenterImage;
            // setting pictureBox image
            formCreated.pictureBoxCreated.Image = Properties.Resources.dust;
            // showing formCreated
            formCreated.ShowDialog();
        }
    }
}
