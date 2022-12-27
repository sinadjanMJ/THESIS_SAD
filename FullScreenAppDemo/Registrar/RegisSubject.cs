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
    public partial class RegisSubject : Form
    {
       
   
        studentPortalEntities _context = new studentPortalEntities();

        DepartmentValue dv = new DepartmentValue();
        courseValue cv = new courseValue();

        public static string departmentID = "";
        public static string courseID = "";
        //int departID;

        public RegisSubject()
        {
            InitializeComponent();
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
          
      

        private void RegisSubject_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.DataSource = _context.Class_S.ToList();
            loadDepartment();
            loadSubs();

        }
        private void loadDepartment()
        {
            var selected = _context.Departments.ToList();

            foreach (var item in selected)
            {

                DepartmentValue dv = new DepartmentValue();
                dv.Text = item.Department_Name; //Display name
                dv.Value = item.Department_ID; //value inside the name

                cBDepartment.Items.Add(dv);
            }
            cBDepartment.SelectedIndex = 0;


        }


       

        private void btnCreateSub_Click(object sender, EventArgs e)
        {

        }
        private void loadSubs()
        {
            dgvSubList.DataSource = _context.S_Subject.ToList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {

            if (textC_name.Text == "" || cBDepartment.SelectedIndex == -1 || cBCourse.SelectedIndex == -1 || cBYear.Text == "")
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Class_S cs = new Class_S
                    {
                        ClassName = textC_name.Text.Trim(),
                        DepartmentID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString(),
                        CourseID = (cBCourse.SelectedItem as courseValue).Value.ToString(),
                        YearLevel = cBYear.Text.Trim()
                    };

                    _context.Class_S.Add(cs);
                    _context.SaveChanges();
                    CLEAR();

                    gunaDataGridView1.DataSource = _context.Class_S.ToList();
                }
            }

          
        }

        private void cBDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBCourse.Items.Clear();
            string depID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString();
            var selectedC = _context.Courses.ToList();

            foreach (var item in selectedC)
            {
                if (item.DepartmentID == depID)
                {
                    courseValue cv = new courseValue();
                    cv.Text = item.Course_name; //Display name
                    cv.Value = item.CourseID; //value inside the name

                    cBCourse.Items.Add(cv);
                }
            }
            cBCourse.SelectedIndex = -1;
        }
        private void CLEAR()
        {
            cBCourse.Items.Clear();
            cBYear.Items.Clear();
            cBDepartment.Items.Clear();
            textC_name.Clear();
        }

        private void btnAssignSub_Click(object sender, EventArgs e)
        {
          
            assignSubject mj = new assignSubject();
            mj.Show();

        }

        private void BTNCreateSub_Click_1(object sender, EventArgs e)
        {
            S_Subject s = new S_Subject
            {
                SubjectCode = textSubjectCode.Text.Trim(),
                SubjectName = textSubjectName.Text.Trim(),
                SubjectUnit = textSubjectUnits.Text.Trim()
            };

            _context.S_Subject.Add(s);
            _context.SaveChanges();

            loadSubs();
        }

        private void BTNAssignSub_Click_1(object sender, EventArgs e)
        {
            assignSubject mj = new assignSubject();
            mj.Show();
        }
    }
}
