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
    public partial class loginDean : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public static int deanID = 0;
        public loginDean()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_DeanID.Text != "")
                {
                    deanID = Int32.Parse(txt_DeanID.Text.Trim());
                }

                var res = _context.Deans.Where(q => q.DeanID == deanID).FirstOrDefault();
                if (res != null)
                {
                    //MessageBox.Show("Welcome, " );
                    MessageBox.Show("Welcome," + res.Dean_fname, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeanDashboard ud = new DeanDashboard();
                    ud.Show();
                    this.Hide();
                }
                else
                {
                   
                    MessageBox.Show("DEAN NOT FOUND", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
