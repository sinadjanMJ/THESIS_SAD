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
    public partial class uAcademicStudentLoad : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        int classID = 0;
        int schoolID = 0;
        string sem = "";
        int studentID = 0;
        public uAcademicStudentLoad()
        {
            InitializeComponent();
        }

        private void uAcademicStudentLoad_Load(object sender, EventArgs e)
        {
            dgvSubjectList.Columns[0].Visible = false;

            studentID = uAcademicStudentList.studentID;
            classID = uAcademicStudentList.classID;
            schoolID = uAcademicStudentList.schoolID;
            sem = uAcademicStudentList.sem;
            loadPerips();
            loadSub();
        }
        private void loadPerips()
        {
            var resClass = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
            if (resClass != null)
            {
                lblClass.Text = resClass.ClassName.ToString();
            }

            var resStudent = _context.studentBackgrounds.Where(q => q.S_SchoolID == schoolID.ToString()).FirstOrDefault();
            if (resStudent != null)
            {
                lblStudentName.Text = resStudent.S_fname + " " + resStudent.S_mname + " " + resStudent.S_lname;
                lblSchoolID.Text = resStudent.S_SchoolID.ToString();
            }

            lblSemester.Text = sem;
        }

        private void loadSub()
        {
            try
            {
                var res = (
                from cl in _context.Class_S
                join st in _context.Student_Profile on cl.ClassID.ToString() equals st.ClassID
                join sub in _context.S_Subject on st.SubjectID equals sub.SubjectID.ToString()
                join ins in _context.Instructors on st.InstructorID equals ins.InstructorID.ToString()
                where st.StudentID == studentID.ToString() && st.SchoolID == schoolID.ToString() && st.status == "accepted"
                && st.Semester == sem

                select new uStudentLoadSubs
                {
                    SubjectID = sub.SubjectID,
                    SUBJECT = sub.SubjectName,
                    INSTRUCTOR = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname,
                    GRADE = st.Grade
                }
                ).ToList();

                dgvSubjectList.DataSource = res;
                loadSetGrades();
            }
            catch
            {
                MessageBox.Show("There is something wrong");
            }
        }
        private void loadSetGrades()
        {
            for (int i = 0; i < dgvSubjectList.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dgvSubjectList.Rows[i].Cells[3].Value as string))
                {
                    dgvSubjectList.Rows[i].Cells[3].Value = "N/A";
                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            uAcademicStudentList mj = new uAcademicStudentList();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }
    }
}
