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
    public partial class RegisStudent : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static string studentID = "";
        DepartmentValue dv = new DepartmentValue();
        courseValue cv = new courseValue();
        classValue cvs = new classValue();
       
        public RegisStudent()
        {
            InitializeComponent();
        }

        

        private void RegisStudent_Load(object sender, EventArgs e)
        {


            dgvStudentList.DataSource = _context.studentBackgrounds.ToList();

            openStudList();


            loadDepartment();
            dgvSubAssignment.Columns[0].Visible = false;
            dgvSubAssignment.Columns[5].Visible = false;
            dgvSubAssignment.Columns[6].Visible = false;
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
            cBDepartment.SelectedIndex = -1;
            //Department_ID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString()
        }
        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisDashboard mj = new RegisDashboard();
            mj.Show();
        }

        private void dgvStudentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudentList.SelectedRows.Count > 0)
            {
                studentID = dgvStudentList.SelectedRows[0].Cells[0].Value.ToString();

            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            saveDATA.Hide();
            studentdataPanel.Hide();
            addstudentPanel.Show();
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          

        }
        private void openStudList()
        {

            saveDATA.Hide();
            studentdataPanel.Show();
            addstudentPanel.Hide();
           

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            openStudList();

            Clear();

        }

        private void dgvStudentList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            UPDATESTUDENT mj = new UPDATESTUDENT();
            mj.TopLevel = false;
            studentdataPanel.Controls.Clear();
            studentdataPanel.Controls.Add(mj);
            mj.Show();
        }
        private void openSTList()
        {
            saveDATA.Show();
            studentdataPanel.Hide();
            addstudentPanel.Hide();
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int studID = Int32.Parse(studentID.ToString());
                var selectedRow = _context.studentBackgrounds.Where(q => q.StudentID == studID).FirstOrDefault();

                _context.studentBackgrounds.Remove(selectedRow);
                _context.SaveChanges();
                dgvStudentList.DataSource = _context.studentBackgrounds.ToList();
            }
            
        }


     
        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void cBCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadSection();
            loadStudentSubs();
        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }

        private void cBDepartment_SelectedIndexChanged_1(object sender, EventArgs e)
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
            loadSection();
            loadStudentSubs();
        }

        private void cBYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            loadSection();
            loadStudentSubs();
        }
        private void loadSection()
        {
            cBSection.Items.Clear();
            string Department_ID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString();
            string yearLevel = cBYear.Text.Trim();

            if (cBCourse.Text.Trim() != "")
            {
                string CourseID = (cBCourse.SelectedItem as courseValue).Value.ToString();
                var selectedClass = _context.Class_S.ToList();

                foreach (var item in selectedClass)
                {
                    if (item.DepartmentID == Department_ID && item.CourseID == CourseID && item.YearLevel == yearLevel)
                    {
                        classValue cvs = new classValue();
                        cvs.Text = item.ClassName;
                        cvs.Value = item.ClassID;

                        cBSection.Items.Add(cvs);
                    }
                }
                cBSection.SelectedIndex = -1;
            }
        }
        private void loadStudentSubs()
        {
            dgvSubAssignment.DataSource = null;
            this.dgvSubAssignment.Rows.Clear();
            labelUnits.Text = "0";
            if (cBSection.Text.Trim() != "")
            {
                string class_ID = (cBSection.SelectedItem as classValue).Value.ToString();
                //var selectedClass = _context.assignSubjects.ToList();
                string sems = cBSemester.Text.Trim();

                var res = (
                    from ai in _context.assignSubjects
                    join il in _context.Instructors on ai.a_instructorID equals il.InstructorID.ToString()
                    join sl in _context.S_Subject on ai.a_subjectID equals sl.SubjectID.ToString()
                    where ai.a_classID == class_ID && ai.a_semester == sems

                    select new studentAssignSub
                    {
                        SubjectID = sl.SubjectID,
                        CODE = sl.SubjectCode,
                        SUBJECT = sl.SubjectName,
                        INSTRUCTOR = il.Instructor_fname + ", " + il.Instructor_lname,
                        UNITS = sl.SubjectUnit,
                        instructor_id = il.InstructorID,
                        subject_id = sl.SubjectID
                    }

                ).ToList();

                dgvSubAssignment.DataSource = res;
                //dgvSubAssignment.Columns["instructor_id"].Visible = false;

                calculateUnit();
            }
        }
        private void calculateUnit()
        {
            int sum = 0;
            string hello = "";
            for (int i = 0; i < dgvSubAssignment.Rows.Count; ++i)
            {
                //sum += Convert.ToInt32(dgvSubAssignment.Rows[i].Cells[2].Value);
                hello = dgvSubAssignment.Rows[i].Cells[3].Value.ToString();
                if (hello != "")
                {
                    //sum = Int32.Parse(hello.ToString());
                    sum += Int32.Parse(hello.ToString());
                }
            }
            labelUnits.Text = sum.ToString();
        }
        private void saveProfile()
        {
            int sti = _context.studentBackgrounds.Count();
            int halu = _context.studentBackgrounds.Select(q => q.StudentID).DefaultIfEmpty(0).Max();
            for (int i = 0; i < dgvSubAssignment.Rows.Count; i++)
            {
                Student_Profile sp = new Student_Profile
                {
                    StudentID = halu.ToString(),
                    DepartmentID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString(),
                    CourseID = (cBCourse.SelectedItem as courseValue).Value.ToString(),
                    YearLevel = cBYear.Text.Trim(),
                    ClassID = (cBSection.SelectedItem as classValue).Value.ToString(),
                    Semester = cBSemester.Text.Trim(),
                    SubjectID = Convert.ToString(dgvSubAssignment.Rows[i].Cells[5].Value),
                    InstructorID = Convert.ToString(dgvSubAssignment.Rows[i].Cells[6].Value)
                };
                _context.Student_Profile.Add(sp);
                _context.SaveChanges();
            }


        }
        public void Clear()
        {

            textS_Fname.Clear();
            textS_Mname.Clear();
            textS_Lname.Clear();
            comboGender.SelectedIndex = -1;
            textS_MobileNumber.Clear();
            textS_EmailAdd.Clear();
            textS_Religion.Clear();
            textS_Citizenship.Clear();
            textS_Province.Clear();
            textS_Municipality.Clear();
            textS_Barangay.Clear();
            textS_Guardian_Fname.Clear();
            textS_Guardian_Mname.Clear();
            textS_Guardian_LName.Clear();
            textS_Guardian_Contact.Clear();
          


        }

        private void cBSemester_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadStudentSubs();
        }

        private void cBSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadStudentSubs();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (cBCourse.SelectedIndex == -1 || cBYear.SelectedIndex == -1 || cBSemester.SelectedIndex == -1 || cBDepartment.SelectedIndex == -1 || cBSection.SelectedIndex == -1)
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Save", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    studentBackground s = new studentBackground
                    {
                        S_fname = textS_Fname.Text.Trim(),
                        S_mname = textS_Mname.Text.Trim(),
                        S_lname = textS_Lname.Text.Trim(),
                        S_Sex = comboGender.Text.Trim(),
                        S_Birthdate = date_S_Birthdate.Text.Trim(),
                        S_mNumber = textS_MobileNumber.Text.Trim(),
                        S_emailAdd = textS_EmailAdd.Text.Trim(),
                        S_Religion = textS_Religion.Text.Trim(),
                        S_Citizenship = textS_Citizenship.Text.Trim(),
                        S_Province = textS_Province.Text.Trim(),
                        S_municipality = textS_Municipality.Text.Trim(),
                        S_barangay = textS_Barangay.Text.Trim(),
                        S_Guardian_fname = textS_Guardian_Fname.Text.Trim(),
                        S_Guardian_mname = textS_Guardian_Mname.Text.Trim(),
                        S_Guardian_lname = textS_Guardian_LName.Text.Trim(),
                        S_Guardian_contact = textS_Guardian_Contact.Text.Trim()
                    };

                    _context.studentBackgrounds.Add(s);
                    _context.SaveChanges();
                    saveProfile();
                    Clear();
                    MessageBox.Show("STUDENT ADDED SUCCESSFULLY");
                    openStudList();
                    dgvStudentList.DataSource = _context.studentBackgrounds.ToList();

                }
            }
           

        }

        private void PROCEED_Click(object sender, EventArgs e)
        {
            if(textS_Municipality.Text =="" || textS_Citizenship.Text == "" || textS_EmailAdd.Text == "" || textS_Mname.Text == "" || textS_Province.Text == "" || textS_Religion.Text == "" || textS_MobileNumber.Text == "" || comboGender.Text == "" || textS_Fname.Text == "" || textS_Barangay.Text == "" || textS_Lname.Text == "")
            {

                MessageBox.Show("Fill out the field first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                saveDATA.Show();
                studentdataPanel.Hide();
                addstudentPanel.Hide();
              
               

            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            dgvSubAssignment.Rows.Remove(dgvSubAssignment.CurrentRow);

            dgvSubAssignment.Refresh();
            calculateUnit();
        }
    }
}
