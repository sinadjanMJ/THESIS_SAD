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
        public uAcademicStudentList()
        {
            InitializeComponent();
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                schoolID = Int32.Parse(dgvStudentList.SelectedRows[0].Cells[0].Value.ToString());
                sem = cbSemester.Text.Trim();
            }
        }

        private void uAcademicStudentList_Load(object sender, EventArgs e)
        {
            loadClass();
            loadStudentList();
            cbSemester.SelectedIndex = 0;
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

        private void loadStudentList()
        {
            load1stSem();
        }

        private void load1stSem()
        {
            try
            {
                cbSemester.SelectedIndex = 0;
                string semester = "1st Semester";
                var res = (
                    from st in _context.Student_Profile
                    join sb in _context.studentBackgrounds on st.SchoolID equals sb.S_SchoolID.ToString()
                    where st.ClassID == classID.ToString() && st.Semester == semester

                    select new studentLoadwithInst
                    {
                        schoolID = st.SchoolID,
                        STUDENT = sb.S_lname + ", " + sb.S_fname
                    }

                    ).Distinct().ToList();

                dgvStudentList.DataSource = res;
            }
            catch
            {
                MessageBox.Show("Error occured loadStudentList()");
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string semester = cbSemester.Text.Trim();
                var res = (
                    from st in _context.Student_Profile
                    join sb in _context.studentBackgrounds on st.SchoolID equals sb.S_SchoolID.ToString()
                    where st.ClassID == classID.ToString() && st.Semester == semester

                    select new studentLoadwithInst
                    {
                        schoolID = st.SchoolID,
                        STUDENT = sb.S_lname + ", " + sb.S_fname
                    }

                    ).Distinct().ToList();

                dgvStudentList.DataSource = res;
            }
            catch
            {
                MessageBox.Show("Error occured loadStudentList()");
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            load1stSem();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            uAcademic mj = new uAcademic();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }
    }
}
