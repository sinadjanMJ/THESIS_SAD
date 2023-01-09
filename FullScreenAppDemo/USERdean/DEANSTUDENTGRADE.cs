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
    public partial class DEANSTUDENTGRADE : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        int classID = 0;
        int subjectID = 0;
        int instructorID = 0;
        int a_ID = 0;
        public DEANSTUDENTGRADE()
        {
            InitializeComponent();
        }

        private void DEANSTUDENTGRADE_Load(object sender, EventArgs e)
        {
            dgvStudentLoad.Columns[0].Visible = false;

            classID = Int32.Parse(DeanClassList.classID.ToString());
            a_ID = Int32.Parse(DeanClassList.a_ID.ToString());
            subjectID = Int32.Parse(DeanClassList.subjectID.ToString());
            instructorID = Int32.Parse(DeanClassList.instructorID.ToString());

            loadLabels();
            loadGradeList();
        }
        private void loadLabels()
        {
            var resClass = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
            if (resClass != null)
            {
                lblClass.Text = resClass.ClassName;
            }

            var resSubject = _context.S_Subject.Where(q => q.SubjectID == subjectID).FirstOrDefault();
            if (resSubject != null)
            {
                lblSubject.Text = resSubject.SubjectName;
            }

            var resInstructor = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();
            if (resInstructor != null)
            {
                lblInstructor.Text = resInstructor.Instructor_fname + " " + resInstructor.Instructor_mname + " " + resInstructor.Instructor_lname;
            }

            var feedback = _context.transactionGrades.Where(q => q.a_ID == a_ID.ToString()).FirstOrDefault();
            if (feedback != null)
            {
                lblInstructorFeedback.Text = feedback.feedback_Instructor;
            }
        }

        private void loadGradeList()
        {
           

            var res = (
                from ai in _context.Student_Profile
                join stud in _context.studentBackgrounds on ai.StudentID equals stud.StudentID.ToString()

                where ai.ClassID == classID.ToString() && ai.InstructorID == instructorID.ToString()
                && ai.SubjectID == subjectID.ToString()

                select new studentLoadwithInst
                {
                    studentID = stud.StudentID,
                    schoolID = stud.S_SchoolID,
                    STUDENT = stud.S_fname + " " + stud.S_mname + " " + stud.S_lname,
                    GRADE = ai.Grade
                }

                ).ToList();

            dgvStudentLoad.DataSource = res;
        }

        private void dgvStudentLoad_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            var transactionGrade = _context.transactionGrades.Where(q => q.a_ID == a_ID.ToString()).FirstOrDefault();
            if (transactionGrade != null)
            {
                transactionGrade.feedback_Dean = textDeanFeedback.Text.Trim();
                transactionGrade.status_Dean = "rejected";
                _context.SaveChanges();

                DeanformDH mj = new DeanformDH();
                mj.TopLevel = false;
                uipanel.Controls.Clear();
                uipanel.Controls.Add(mj);
                mj.Show();
            }
            else
            {
                MessageBox.Show("Entity not found");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DeanClassList mj = new DeanClassList();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
