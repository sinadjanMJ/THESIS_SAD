using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FullScreenAppDemo.db;

namespace FullScreenAppDemo
{
    public partial class frmlogin : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
              
            }
            else
            {
                txtPassword.PasswordChar = '•';
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (_context.logins.Where(q=>q.username==txtUsername.Text && q.password == txtPassword.Text).Count()>0)
            {
                MessageBox.Show("Successfully Loging in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new RegisDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            REGISTERFRM bantag = new REGISTERFRM();
            bantag.Show();
            this.Hide();
        }
    }
}
