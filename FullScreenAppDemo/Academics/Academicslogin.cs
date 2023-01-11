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
using FullScreenAppDemo.perips;

namespace FullScreenAppDemo
{
    public partial class Academicslogin : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public Academicslogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_context.academicslogins.Where(q => q.username == txtUsername.Text && q.password == textBox1.Text).Count() > 0)
                {
                    MessageBox.Show("Successfully Loging in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new AcademicsDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUsername.Text = "";
                    textBox1.Text = "";
                    txtUsername.Focus();
                }
            }
            catch
            {
              
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                textBox1.PasswordChar = '\0';

            }
            else
            {
                textBox1.PasswordChar = '•';

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            textBox1.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AcdemicsRegisterAccount bantag = new AcdemicsRegisterAccount();
            bantag.Show();
            this.Hide();
        }

        private void Academicslogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
