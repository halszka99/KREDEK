using System;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad4.Forms
{
    public partial class FormLogin : Form
    {
        /// <summary>
        /// Declaration of class to process data connected with Logins table. 
        /// </summary>
        LoginsRepository loginsRepository;
        public FormLogin()
        {
            // initializing loginsRepository 
            loginsRepository = new LoginsRepository();
            // initializing component
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // extracting login data from text boxes
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            // setting logged employee id by calling login method
            int employeeId = loginsRepository.Login(login, password);
            
            // checking if employeeId is higher than 0
            if (employeeId > 0)
            {
                // setting static variable in class Program to employeeId
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
