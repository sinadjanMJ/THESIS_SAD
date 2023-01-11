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
    public partial class uAcademicPendings : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        int departmentID = 0;
        int courseID = 0;
        public static int classID = 0;
        public uAcademicPendings()
        {
            InitializeComponent();
        }

        private void uAcademicPendings_Load(object sender, EventArgs e)
        {
            dgvDepartmentList.Columns[0].Visible = false;
            dgvCourseList.Columns[0].Visible = false;
            dgvClass.Columns[0].Visible = false;
            dgvPendingList.Columns[0].Visible = false;
            loadDepartment();
            pendingLog();
        }
        private void pendingLog()
        {
            var res = (
                /*from st in _context.Student_Profile
                join ai in _context.assignSubjects on st.ClassID equals ai.a_classID
                join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
                join cl in _context.Class_S on st.ClassID equals cl.ClassID.ToString()
                where tg.status_Registrar == "pending" && tg.status_Dean == "accepted"*/

                from ai in _context.assignSubjects
                join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
                join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
                where tg.status_Registrar == "pending" && tg.status_Dean == "accepted"

                select new uAcademicPendingsClass
                {
                    classID = cl.ClassID,
                    CLASS = cl.ClassName,
                    yearLevel = cl.YearLevel,
                    semester = ai.a_semester
                }

                ).ToList();

            dgvPendingList.DataSource = res;
        }

        private void loadDepartment()
        {
            var res = _context.Departments.ToList();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(res);
            dgvDepartmentList.DataSource = dt;
        }

        private void loadCourse()
        {
            try
            {
                var res = (
                    from cor in _context.Courses
                    where cor.DepartmentID == departmentID.ToString()

                    select new
                    {
                        CourseID = cor.CourseID,
                        Course_name = cor.Course_name
                    }
                    ).ToList();

                dgvCourseList.DataSource = res;
            }
            catch
            {
                MessageBox.Show("Error occured at loadCourse()");
            }
        }

        private void dgvDepartmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvDepartmentList.SelectedRows.Count > 0)
                {
                    departmentID = Int32.Parse(dgvDepartmentList.SelectedRows[0].Cells[0].Value.ToString());
                }
                /*dgvCourseList.AllowUserToAddRows = false;
                dgvCourseList.Rows.Clear();
                dgvCourseList.AllowUserToAddRows = true;*/
                loadCourse();
            }
            catch
            {
                MessageBox.Show("Error occured at dgvDepartmentList_CellClick");
            }
        }

        private void dgvCourseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCourseList.SelectedRows.Count > 0)
                {
                    courseID = Int32.Parse(dgvCourseList.SelectedRows[0].Cells[0].Value.ToString());
                }
                loadSection();
            }
            catch
            {
                MessageBox.Show("Error occured at CourseList_CellClick");
            }
        }
        private void loadSection()
        {
            try
            {
                var res = _context.Class_S.Where(q => q.CourseID == courseID.ToString()).ToList();
                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(res);
                dgvClass.DataSource = dt;
            }
            catch { MessageBox.Show("Error occured at loadSection()"); }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClass.SelectedRows.Count > 0)
                {
                    classID = Int32.Parse(dgvClass.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch { MessageBox.Show("Error occured at dgvClass_CellClick"); }
        }

        private void dgvClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                uAcademicGradePendings mj = new uAcademicGradePendings();
                mj.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(mj);
                mj.Show();
            }
            catch 
            {
            }
        }
    }
}
