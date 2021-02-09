using System;
using System.Windows.Forms;

namespace HalszkaCiesielskaWyk
{
    /// <summary>
    /// FormMain class
    /// </summary>
    public partial class FormMain : Form
    {
        // creating new invoker
        Invoker invoker = new Invoker();
        /// <summary>
        /// FormMain constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating new item using button create connected with checkedListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateFromCheckBox_Click(object sender, EventArgs e)
        {

            if (checkedListBoxResources.CheckedItems.Count != 2)
            {
                // showing selection failed message box
                MessageBox.Show("You have to choose 2 resources!", "Selection failed");
            }
            else if (checkedListBoxResources.CheckedItems.Contains("Air") && checkedListBoxResources.CheckedItems.Contains("Earth"))
            {
                // creating dust when air and earth are checked
                invoker.Invoke(new CreateDustCommand());
            }
            else if (checkedListBoxResources.CheckedItems.Contains("Air") && checkedListBoxResources.CheckedItems.Contains("Fire"))
            {
                // creating energy when air and fire are checked
                invoker.Invoke(new CreateEnergyCommand());
            }
            else if (checkedListBoxResources.CheckedItems.Contains("Fire") && checkedListBoxResources.CheckedItems.Contains("Earth"))
            {
                // creating lava when fire and earth are checked
                invoker.Invoke(new CreateLavaCommand());
            }
            else if (checkedListBoxResources.CheckedItems.Contains("Water") && checkedListBoxResources.CheckedItems.Contains("Earth"))
            {
                // creating mud when water and earth are checked
                invoker.Invoke(new CreateMudCommand());
            }
            else if (checkedListBoxResources.CheckedItems.Contains("Air") && checkedListBoxResources.CheckedItems.Contains("Water"))
            {
                // creating rain when air and water are checked
                invoker.Invoke(new CreateRainCommand());
            }
            else if (checkedListBoxResources.CheckedItems.Contains("Water") && checkedListBoxResources.CheckedItems.Contains("Fire"))
            {
                // creating steam when water and fire are checked
                invoker.Invoke(new CreateSteamCommand());
            }
            // unchecking all items in checkedListBox
            foreach (int checkedItemIndex in checkedListBoxResources.CheckedIndices)
            {
                checkedListBoxResources.SetItemChecked(checkedItemIndex, false);
            }
        }
        /// <summary>
        /// Creating new item using button create connected with comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateFromComboBox_Click(object sender, EventArgs e)
        {
            if (comboBoxCreate.Text == "Dust")
            {
                // creating dust when dust is selected in combo box
                invoker.Invoke(new CreateDustCommand());
            }
            else if (comboBoxCreate.Text == "Energy")
            {
                // creating energy when energy is selected in combo box
                invoker.Invoke(new CreateEnergyCommand());
            }
            else if (comboBoxCreate.Text == "Lava")
            {
                // creating lava when lava is selected in combo box
                invoker.Invoke(new CreateLavaCommand());
            }
            else if (comboBoxCreate.Text == "Mud")
            {
                // creating mud when mud is selected in combo box
                invoker.Invoke(new CreateMudCommand());
            }
            else if (comboBoxCreate.Text == "Rain")
            {
                // creating rain when rain is selected in combo box
                invoker.Invoke(new CreateRainCommand());
            }
            else if (comboBoxCreate.Text == "Steam")
            {
                // creating steam when steam is selected in combo box
                invoker.Invoke(new CreateSteamCommand());
            }
            else if (comboBoxCreate.Text == "")
            {
                // showing selection failed message box
                MessageBox.Show("You have to choose item!", "Selection failed");
            }
            else
            {
                // showing selection failed message box
                MessageBox.Show("Wrong item name!", "Selection failed");
            }
            // clearing combo box 
            comboBoxCreate.Text = ""; 
        }
    }
}
