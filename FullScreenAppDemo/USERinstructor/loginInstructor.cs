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
    public partial class loginInstructor : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int instructorID = 0;
        public loginInstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_InstructorID.Text != "")
                {
                    instructorID = Convert.ToInt32(txt_InstructorID.Text.Trim());
                }

                var renderInstructor = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();
                if (renderInstructor != null) // IF THERE IS INSTRUCTOR EXISTING
                {
                 
                  MessageBox.Show("WELCOME!", "Successfully ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  new InstructorDashboard().Show();
                  this.Hide();


                }
                else
                {
                    MessageBox.Show("INSTRUCTOR NOT FOUND");
                }
            }
            catch
            {
                MessageBox.Show("ERROR HAPPENS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
