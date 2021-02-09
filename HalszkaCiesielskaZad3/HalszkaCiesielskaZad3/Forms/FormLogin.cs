using System;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Login form class.
    /// </summary>
    public partial class FormLogin : Form
    {
        /// <summary>
        /// Declaration of class to process data connected with Logins table. 
        /// </summary>
        LoginsRepository loginsRepository; 
        /// <summary>
        /// FormLogin constructor. 
        /// </summary>
        public FormLogin()
        {
            // initializing loginsRepository 
            loginsRepository = new LoginsRepository();
            // initializing component
            InitializeComponent();
        }
        /// <summary>
        /// Method called after clicking buttonLogin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // extracting login data from text boxes
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            // declaration of variable to storage employee id
            int employeeId; 
            // setting logged employee id by calling login method
            employeeId = loginsRepository.Login(login, password);
            // checking if employeeId is higher than 0
            if (employeeId > 0)
            {
                // setting static variable in class Program to employeeId
                Program.EmployeeId = employeeId;
                // closing this form
                Close();
            }
            // showing message about wrong login or password in case of login failure
            MessageBox.Show("Wrong login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // clearing text boxes
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
