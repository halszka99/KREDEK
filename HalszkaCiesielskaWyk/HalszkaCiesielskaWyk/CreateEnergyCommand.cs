using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// Create energy command class
    /// </summary>
    public class CreateEnergyCommand : ICommand
    {
        /// <summary>
        /// Method to execute create energy command
        /// </summary>
        public void Execute()
        {
            // creating new formCreated
            FormCreated formCreated = new FormCreated();
            // setting labelCreated text 
            formCreated.labelCreated.Text = "ENERGY CREATED!";
            // setting pictureBox size mode
            formCreated.pictureBoxCreated.SizeMode = PictureBoxSizeMode.CenterImage;
            // setting pictureBox size
            formCreated.pictureBoxCreated.Size = new System.Drawing.Size(150,100);
            // setting pictureBox location
            formCreated.pictureBoxCreated.Location = new System.Drawing.Point(85,100);
            // setting pictureBox image
            formCreated.pictureBoxCreated.Image = Properties.Resources.energy;
            // showing formCreated
            formCreated.ShowDialog();
        }
    }
}
