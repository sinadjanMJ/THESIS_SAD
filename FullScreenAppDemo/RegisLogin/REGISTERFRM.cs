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
    public partial class REGISTERFRM : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public REGISTERFRM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "" )
            {
                MessageBox.Show("Username and Password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == txtComPassword.Text)
            {
                login c = new login
                {
                    username = txtUsername.Text.Trim(),
                    password = txtPassword.Text.Trim()

                };

                _context.logins.Add(c);
                _context.SaveChanges();

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Password did not match, Please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmlogin bantag = new frmlogin();
            bantag.Show();
            this.Hide();
        }

        private void REGISTERFRM_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
