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



        string mouseClicked = "";
        int classID = 0;
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
            loadData();
            loadDepartment();
            loadSubs();
            CANC.Visible = false;

        }
        private void loadData()
        {
            var res = (
                from sec in _context.Class_S
                join dep in _context.Departments on sec.DepartmentID equals dep.Department_ID.ToString()
                join cor in _context.Courses on sec.CourseID equals cor.CourseID.ToString()

                select new sectionWithDepWithCourse
                {
                    classID = sec.ClassID,
                    className = sec.ClassName,
                    departmentName = dep.Department_Name,
                    courseName = cor.Course_name
                }
                ).ToList();

            gunaDataGridView1.DataSource = res;
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

        private void btnAddSection_Click(object sender, EventArgs e)
        {

            if (textC_name.Text == "" || cBDepartment.SelectedIndex == -1 || cBCourse.SelectedIndex == -1 || cBYear.Text == "")
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string className = textC_name.Text.Trim();
                if (btnAddSection.Text == "ADD SECTION")
                {
                    //QUERY IF THERE IS AN EXISTING CLASS NAME
                    var section = _context.Class_S.Where(q => q.ClassName == className).FirstOrDefault();

                    if (section == null) //IF THERE IS NO EXISITNG CLASS NAME
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
                        MessageBox.Show("Successfully Added");

                        loadData();
                        CANC.Visible = false;
                        CLEAR();
                    }
                    else
                    {
                        MessageBox.Show("THERE IS ALREADY AN EXISTING CLASS NAME");
                    }

                }
                else if (btnAddSection.Text == "UPDATE SECTION")
                {
                    //QUERY THE ORIGINAL DATA FIRST
                    var selected = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
                    string oClassName = selected.ClassName.ToString();

                    //QUERY IF CLASS NAME ALREADY EXIST
                    var section = _context.Class_S.Where(q => q.ClassName == className).FirstOrDefault();
                    if (section != null) //IF THERE IS AN EXISTING CLASS NAME
                    {
                        string qClassName = section.ClassName.ToString();
                        if (oClassName == qClassName) //IF IT'S BECAUSE OF ORIGINAL DATA THEN PROCEED TO UPDATE
                        {
                            selected.ClassName = textC_name.Text.Trim();
                            selected.YearLevel = cBYear.Text.Trim();
                            selected.DepartmentID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString();
                            selected.CourseID = (cBCourse.SelectedItem as courseValue).Value.ToString();

                            _context.SaveChanges();
                            MessageBox.Show("Successfully Updated");
                            btnAddSection.Text = "ADD SECTION";
                            CANC.Text = "CANCEL";
                            loadData();
                            CANC.Visible = false;
                            CLEAR();
                           


                        }
                        else // IF IT'S NOT BECAUSE OF ORIGINAL DATA
                        {
                            MessageBox.Show("THERE IS ALREADY AN EXISTING CLASS NAME");
                        }
                    }
                    else // IF THERE IS NO EXISTING CLASS NAME FOUND
                    {
                        selected.ClassName = textC_name.Text.Trim();
                        selected.YearLevel = cBYear.Text.Trim();
                        selected.DepartmentID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString();
                        selected.CourseID = (cBCourse.SelectedItem as courseValue).Value.ToString();

                        _context.SaveChanges();
                        MessageBox.Show("Successfully Updated");
                        loadData();
                        btnAddSection.Text = "ADD SECTION";
                        CANC.Text = "CANCEL";
                        CLEAR();

                    }
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
            cBCourse.SelectedIndex = -1;
            cBYear.SelectedIndex = -1;
           
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
            if (selected != null)
            {
                _context.Class_S.Remove(selected);
                _context.SaveChanges();
            }
            btnDelete.Visible = false;
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mouseClicked = "yes";
            if (mouseClicked == "yes")
            {
                loadUpdateInfo();
            }
            btnAddSection.Text = "UPDATE SECTION";
            CANC.Text = "CANCEL UPDATE";
            btnDelete.Visible = true;
        }
        private void loadUpdateInfo()
        {
            //GET THE VALUE FROM THE ORIGINAL DATA
            var render = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();
            string className = render.ClassName.ToString();
            string yearLevel = render.YearLevel.ToString();
            int departmentID = Convert.ToInt32(render.DepartmentID.ToString());
            int courseID = Convert.ToInt32(render.CourseID.ToString());

            loadUpdateDepartment(departmentID);
            loadUpdateCourse(courseID);

            textC_name.Text = className.ToString();
            cBYear.SelectedIndex = cBYear.FindString(yearLevel);
        }
        private void loadUpdateDepartment(int departmentID)
        {
            //QUERY IF THERE IS DEPARTMENT NAME FOUND
            var dp = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();
            if (dp != null)
            {
                string departmentName = dp.Department_Name.ToString();
                cBDepartment.SelectedIndex = cBDepartment.FindString(departmentName);
            }
        }

        private void loadUpdateCourse(int courseID)
        {
            //QUERY IF THERE IS COURSE NAME FOUND
            var cp = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();
            if (cp != null)
            {
                string courseName = cp.Course_name.ToString();
                cBCourse.SelectedIndex = cBCourse.FindString(courseName);
            }
        }

        private void gunaDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            CANC.Visible = true;
            if (gunaDataGridView1.SelectedRows.Count > 0)
            {
                classID = Convert.ToInt32(gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (mouseClicked == "yes")
                {
                    loadUpdateInfo();
                }
            }
        }

        private void CANC_Click(object sender, EventArgs e)
        {
            if (CANC.Text == "CANCEL")
            {
                CLEAR();
                CANC.Visible = false;
            }
            else if (CANC.Text == "CANCEL UPDATE")
            {
                CLEAR();
                CANC.Visible = false;
                btnAddSection.Text = "ADD SECTION";
                CANC.Text = "CANCEL";

            }
          
        }

        private void textC_name_TextChanged(object sender, EventArgs e)
        {
            CANC.Visible = true;
        }
    }
}
