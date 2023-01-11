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
    public partial class uAcademicStudentList : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int schoolID = 0;
        public static int classID = 0;
        public static string sem = "";
        public static int studentID = 0;

        public uAcademicStudentList()
        {
            InitializeComponent();
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStud.SelectedRows.Count > 0)
            {
                studentID = Int32.Parse(dgvStud.SelectedRows[0].Cells[0].Value.ToString());
                schoolID = Int32.Parse(dgvStud.SelectedRows[0].Cells[1].Value.ToString());
                sem = dgvStud.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void uAcademicStudentList_Load(object sender, EventArgs e)
        {
            loadClass();
            //loadStudentList();
            loadStudent();
            cbSemester.SelectedIndex = 0;

            dgvStud.Columns[0].Visible = false;
        }
        private void loadClass()
        {
            try
            {
                classID = uAcademic.classID;
                var res = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
                if (res != null)
                {
                    lblSection.Text = res.ClassName;
                }
            }
            catch
            {
                MessageBox.Show("Error occured loadClass()");
            }
        }

        //private void loadStudentList()
        //{
        //    load1stSem();
        //}

       

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string sem = cbSemester.Text.Trim();
                var res = (
                    from sb in _context.studentBackgrounds
                    join st in _context.Student_Profile on sb.StudentID.ToString() equals st.StudentID
                    join cl in _context.Class_S on st.ClassID equals cl.ClassID.ToString()
                    where cl.ClassID == classID && st.Semester == sem

                    select new studentLoadwithInst
                    {
                        studentID = sb.StudentID,
                        schoolID = sb.S_SchoolID,
                        STUDENT = sb.S_lname + ", " + sb.S_fname,
                        CODE = st.Semester
                    }
                    ).Distinct().ToList();

                dgvStud.DataSource = res;
            }
            catch
            {
                MessageBox.Show("Error occured loadStudentList()");
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            loadStudent();
        }
        private void loadStudent()
        {
            try
            {
                var res = (
                    from sb in _context.studentBackgrounds
                    join st in _context.Student_Profile on sb.StudentID.ToString() equals st.StudentID
                    join cl in _context.Class_S on st.ClassID equals cl.ClassID.ToString()
                    where cl.ClassID == classID

                    select new studentLoadwithInst
                    {
                        studentID = sb.StudentID,
                        schoolID = sb.S_SchoolID,
                        STUDENT = sb.S_lname + ", " + sb.S_fname,
                        CODE = st.Semester
                    }
                    ).Distinct().ToList();

                dgvStud.DataSource = res;
            }
            catch
            {
                MessageBox.Show("Error occured loadStudentList()");
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            uAcademic mj = new uAcademic();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }

        private void dgvStud_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uAcademicStudentLoad mj = new uAcademicStudentLoad();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }
    }
}
