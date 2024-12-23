using DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNASYSTEM
{
    public partial class frmLogin : Form
    {
        public int userID = 0;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }
        private bool ValidateInfo()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInfo())
            {
                return;
            }
            DataResultSet m_set = new DataResultSet();
            m_set.Query = @"SELECT * from users where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            if (m_set.Execute())
            {
                if(m_set.Read())
                {
                    int user_Id = m_set.GetInt(0);
                    
                    frmMain formMain = new frmMain();
                    formMain.m_user_ID = user_Id;
                    formMain.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }

            m_set.Close();

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tgleShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (tgleShowPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnAppMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
