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
    public partial class InstructorDashboard : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public static int instructorID = 0;
        public InstructorDashboard()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.Close();

                this.Hide();
                SelectUserForm mj = new SelectUserForm();
                mj.Show();



            }
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            instructorDSHBRD mj = new instructorDSHBRD();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            Class mj = new Class();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }

        private void ValidateBTN_Click(object sender, EventArgs e)
        {
            GradeSenderInstructor mj = new GradeSenderInstructor();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }

        private void InstructorDashboard_Load(object sender, EventArgs e)
        {
            instructorDSHBRD mj = new instructorDSHBRD();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();



            instructorID = loginInstructor.instructorID;

            var renderInstructor = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();

            if (renderInstructor != null) // IF FOUND
            {
              
                label1.Text = renderInstructor.Instructor_fname + " " + renderInstructor.Instructor_mname + " " + renderInstructor.Instructor_lname;
              
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            RejectedGrades mj = new RejectedGrades();
            mj.TopLevel = false;
            instructordashoardpanel.Controls.Clear();
            instructordashoardpanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
