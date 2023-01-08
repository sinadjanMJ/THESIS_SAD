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
    public partial class StudentLoad : Form
    {

        int classID = 0;
        int instructorID = 0;
        int subjectID = 0;

        studentPortalEntities _context = new studentPortalEntities();
        public StudentLoad()
        {
            InitializeComponent();
        }

        private void StudentLoad_Load(object sender, EventArgs e)
        {
            dgvStudentLoad.Columns[0].Visible = false;

            classID = Class.classID;
            instructorID = loginInstructor.instructorID;
            subjectID = Class.subjectID;

            var res = (
                from ai in _context.Student_Profile
                    /*join cl in _context.Class_S on ai.ClassID equals classID.ToString()
                    join ins in _context.Instructors on ai.InstructorID equals ins.InstructorID.ToString()
                    join sub in _context.S_Subject on ai.SubjectID equals sub.SubjectID.ToString()*/
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

            loadOther();
        }
        private void loadOther()
        {
            //GET THE NAME OF INSTRUCTOR, SUBJECT AND CLASS NAME
            var qInstructor = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();
            if (qInstructor != null)
            {
               // lblInstructor.Text = qInstructor.Instructor_fname + " " + qInstructor.Instructor_mname + " " + qInstructor.Instructor_lname;
            }

            var qClass = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
            if (qClass != null)
            {
                lblClass.Text = qClass.ClassName;
            }

            var qSubject = _context.S_Subject.Where(q => q.SubjectID == subjectID).FirstOrDefault();
            if (qSubject != null)
            {
                lblSubject.Text = qSubject.SubjectName;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Class mj = new Class();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }

        private void PROCEED_Click(object sender, EventArgs e)
        {
            ChangeStudentLoad mj = new ChangeStudentLoad();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
