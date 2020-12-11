using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad3
{
    public partial class FormLogin : Form
    {
        LoginsRepository loginsRepository; 
        public FormLogin()
        {
            InitializeComponent();
            loginsRepository = new LoginsRepository();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            int employeeId = 0; 
            employeeId = loginsRepository.Login(login, password);

            if (employeeId > 0)
            {
                Program.EmployeeId = employeeId;
                Close();
            }

            MessageBox.Show("Wrong login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
