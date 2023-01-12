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
    public partial class Class : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public static int instructorID = 0;
        public static int classID = 0;
        public static int subjectID = 0;
        public static int a_ID = 0;


        public static string sem = "";
        public Class()
        {
            InitializeComponent();
        }

        private void btnSetToPending_Click(object sender, EventArgs e)
        {

        }

        private void Class_Load(object sender, EventArgs e)
        {
            dgvAssignment.Columns[0].Visible = false;
            dgvAssignment.Columns[1].Visible = false;
            dgvAssignment.Columns[3].Visible = false;
            cbSemester.SelectedIndex = 0;
            //LOAD INSTRUCTOR'S DATA
            instructorID = loginInstructor.instructorID;

            var renderInstructor = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();

            if (renderInstructor != null) // IF FOUND
            {
                //lbl_InstructorID.Text = renderInstructor.InstructorID.ToString();
                //lbl_InstructorName.Text = renderInstructor.Instructor_fname + " " + renderInstructor.Instructor_mname + " " + renderInstructor.Instructor_lname;
                InstructorLoad();
            }

        }
        private void InstructorLoad()
        {
            string convertID = instructorID.ToString();
            var renderLoad = _context.assign_Instructor.Where(q => q.ai_instructorID == convertID).ToList();

            var res = (
                from ai in _context.assignSubjects
                join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
                join sli in _context.S_Subject on ai.a_subjectID equals sli.SubjectID.ToString()
                where ai.a_instructorID == instructorID.ToString() && ai.a_status == "edit"

                select new userInWithClassList
                {
                    a_ID = ai.a_id.ToString(),
                    ClassID = cl.ClassID,
                    Class_name = cl.ClassName,
                    SubjectID = sli.SubjectID,
                    Subject = sli.SubjectName,
                    yearLevel = cl.YearLevel,
                    SEMESTER = ai.a_semester
                }
                ).ToList();

            dgvAssignment.DataSource = res;
        }

        private void PROCEED_Click(object sender, EventArgs e)
        {

            string sem = cbSemester.Text.Trim();

            var res = (
                from ai in _context.assignSubjects
                join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
                join sli in _context.S_Subject on ai.a_subjectID equals sli.SubjectID.ToString()
                where ai.a_instructorID == instructorID.ToString() && ai.a_semester == sem.ToString() &&
                ai.a_status == "edit"

                select new userInWithClassList
                {
                    a_ID = ai.a_id.ToString(),
                    ClassID = cl.ClassID,
                    Class_name = cl.ClassName,
                    SubjectID = sli.SubjectID,
                    Subject = sli.SubjectName,
                    yearLevel = cl.YearLevel,
                    SEMESTER = ai.a_semester
                }
                ).ToList();

            dgvAssignment.DataSource = res;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            InstructorLoad();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to Send it to Pending", "Sending", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var res = _context.assignSubjects.Where(q => q.a_id == a_ID).FirstOrDefault();
                if (res != null)
                {
                    res.a_status = "pending";
                    _context.SaveChanges();
                    InstructorLoad();
                }
            }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a_ID = Convert.ToInt32(dgvAssignment.SelectedRows[0].Cells[0].Value.ToString());
            classID = Convert.ToInt32(dgvAssignment.SelectedRows[0].Cells[1].Value.ToString());
            subjectID = Convert.ToInt32(dgvAssignment.SelectedRows[0].Cells[3].Value.ToString());
            sem = dgvAssignment.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dgvAssignment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentLoad mj = new StudentLoad();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
