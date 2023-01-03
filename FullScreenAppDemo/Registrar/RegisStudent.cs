using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        public static string schoolID = "";

        string choice = "";
        string sschoolID = "";

        DepartmentValue dv = new DepartmentValue();
        courseValue cv = new courseValue();
        classValue cvs = new classValue();
        studentAssignSub sb = new studentAssignSub();

        List<studentAssignSub> res;

        public RegisStudent()
        {
            InitializeComponent();
        }

        

        private void RegisStudent_Load(object sender, EventArgs e)
        {


          

            openStudList();
            loadfpStudentList();

            loadDepartment();
            dgvSubAssignment.Columns[0].Visible = false;
            dgvSubAssignment.Columns[5].Visible = false;
            dgvSubAssignment.Columns[6].Visible = false;

            choice = UPDATESTUDENT.updateChoice.ToString();

            if (choice == "addExisting")
            {
                loadExisting();
                savepanel();


            }
            else
            {
                openStudList();
            }


        }
        private void loadExisting()
        {
            //RENDER USING SCHOOL ID PROVIDED
            sschoolID = UPDATESTUDENT.schoolID.ToString();

            var studentBack = _context.studentBackgrounds.Where(q => q.S_SchoolID == sschoolID).FirstOrDefault();

            if (studentBack != null)
            {
                txtS_SchoolID.Text = studentBack.S_SchoolID.ToString().Trim();
                textS_Fname.Text = studentBack.S_fname.ToString().Trim();
                textS_Mname.Text = studentBack.S_mname.ToString().Trim();
                textS_Lname.Text = studentBack.S_lname.ToString().Trim();
                comboGender.Text = studentBack.S_Sex.ToString().Trim();
                date_S_Birthdate.Value = Convert.ToDateTime(studentBack.S_Birthdate.ToString());
                textS_MobileNumber.Text = studentBack.S_mNumber.ToString().Trim();
                textS_EmailAdd.Text = studentBack.S_emailAdd.ToString().Trim();
                textS_Religion.Text = studentBack.S_Religion.ToString().Trim();
                textS_Citizenship.Text = studentBack.S_Citizenship.ToString().Trim();
                textS_Province.Text = studentBack.S_Province.ToString().Trim();
                textS_Municipality.Text = studentBack.S_municipality.ToString().Trim();
                textS_Barangay.Text = studentBack.S_barangay.ToString().Trim();
                textS_Guardian_Fname.Text = studentBack.S_Guardian_fname.ToString().Trim();
                textS_Guardian_Mname.Text = studentBack.S_Guardian_mname.ToString().Trim();
                textS_Guardian_LName.Text = studentBack.S_Guardian_lname.ToString().Trim();
                textS_Guardian_Contact.Text = studentBack.S_Guardian_contact.ToString().Trim();

                txtS_SchoolID.Enabled = false;
                textS_Fname.Enabled = false;
                textS_Mname.Enabled = false;
                textS_Lname.Enabled = false;
                comboGender.Enabled = false;
                date_S_Birthdate.Enabled = false;
                textS_MobileNumber.Enabled = false;
                textS_EmailAdd.Enabled = false;
                textS_Religion.Enabled = false;
                textS_Citizenship.Enabled = false;
                textS_Province.Enabled = false;
                textS_Municipality.Enabled = false;
                textS_Barangay.Enabled = false;
                textS_Guardian_Fname.Enabled = false;
                textS_Guardian_Mname.Enabled = false;
                textS_Guardian_LName.Enabled = false;
                textS_Guardian_Contact.Enabled = false;
            }
        }

        private void loadfpStudentList()
        {


            var res = (
                from hel in _context.studentBackgrounds
                select new { hel.S_SchoolID, hel.S_fname, hel.S_mname, hel.S_lname }
                ).Distinct();

            dgvStudentList.DataSource = res.ToList();

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
                studentLoad();
                //studentID = dgvStudentList.SelectedRows[0].Cells[0].Value.ToString();
                schoolID = dgvStudentList.SelectedRows[0].Cells[0].Value.ToString();
                //var selectedRow = _context.userAccs.Where(q => q.id == selectedRowID).FirstOrDefault();
            }
            btnDelete.Visible = true;

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
           
            //UPDATESTUDENT mj = new UPDATESTUDENT();
            //mj.TopLevel = false;
            //studentdataPanel.Controls.Clear();
            //studentdataPanel.Controls.Add(mj);
            //mj.Show();
        }
        private void savepanel()
        {
            saveDATA.Hide();
            studentdataPanel.Hide();
            addstudentPanel.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int studID = Int32.Parse(studentID.ToString());
                var selectedRow = _context.studentBackgrounds.Where(q => q.StudentID == studID).FirstOrDefault();

                _context.studentBackgrounds.Remove(selectedRow);
                _context.SaveChanges();
                loadfpStudentList();
                btnDelete.Visible = false;
                MessageBox.Show("Succesfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
            //dgvSubAssignment.DataSource = null;
            //this.dgvSubAssignment.Rows.Clear();
            //labelUnits.Text = "0";
            //if (cBSection.Text.Trim() != "")
            //{
            //    string class_ID = (cBSection.SelectedItem as classValue).Value.ToString();
            //    //var selectedClass = _context.assignSubjects.ToList();
            //    string sems = cBSemester.Text.Trim();

            //    var res = (
            //        from ai in _context.assignSubjects
            //        join il in _context.Instructors on ai.a_instructorID equals il.InstructorID.ToString()
            //        join sl in _context.S_Subject on ai.a_subjectID equals sl.SubjectID.ToString()
            //        where ai.a_classID == class_ID && ai.a_semester == sems

            //        select new studentAssignSub
            //        {
            //            SubjectID = sl.SubjectID,
            //            CODE = sl.SubjectCode,
            //            SUBJECT = sl.SubjectName,
            //            INSTRUCTOR = il.Instructor_fname + ", " + il.Instructor_lname,
            //            UNITS = sl.SubjectUnit,
            //            instructor_id = il.InstructorID,
            //            subject_id = sl.SubjectID
            //        }

            //    ).ToList();

            //    ListtoDataTableConverter converter = new ListtoDataTableConverter();
            //    DataTable dt = converter.ToDataTable(res);
            //    //SqlDataReader da = new SqlDataReader(res);

            //    dgvSubAssignment.DataSource = dt;
            //    //dgvSubAssignment.Columns["instructor_id"].Visible = false;

            //    calculateUnit();
            //}
            dgvSubAssignment.DataSource = null;
            this.dgvSubAssignment.Rows.Clear();
            labelUnits.Text = "0";
            if (cBSection.Text.Trim() != "")
            {
                string class_ID = (cBSection.SelectedItem as classValue).Value.ToString();
                //var selectedClass = _context.assignSubjects.ToList();
                string sems = cBSemester.Text.Trim();

                res = new List<studentAssignSub>(
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



                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(res);


                dgvSubAssignment.DataSource = dt;


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

            //GET THE LATEST VALUE FROM THE STUDENT BACKGROUND
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
                    InstructorID = Convert.ToString(dgvSubAssignment.Rows[i].Cells[6].Value),
                    SchoolID = txtS_SchoolID.Text.Trim()
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
            txtS_SchoolID.Clear();
          


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

            string schoolID = txtS_SchoolID.Text.Trim();
            var studentBack = _context.studentBackgrounds.Where(q => q.S_SchoolID == schoolID).FirstOrDefault();

            if (studentBack == null)
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
                    S_Guardian_contact = textS_Guardian_Contact.Text.Trim(),
                    S_SchoolID = txtS_SchoolID.Text.Trim()
                };

                _context.studentBackgrounds.Add(s);
                _context.SaveChanges();
                saveProfile();
                MessageBox.Show("STUDENT ADDED SUCCESSFULLY");
                Clear();
                loadfpStudentList();
                openStudList();
            }
            else
            {
                if (choice == "addExisting")
                {
                    //RENDER IF THERE IS ALREADY AN EXISITNG DATA UNDER THE SELECTED SCHOOL ID
                    //GET THE SELECTED COMBO BOXES
                    string departmentID = (cBDepartment.SelectedItem as DepartmentValue).Value.ToString();
                    string courseID = (cBCourse.SelectedItem as courseValue).Value.ToString();
                    string yearLevel = cBYear.Text.Trim();
                    string classID = (cBSection.SelectedItem as classValue).Value.ToString();
                    string semester = cBSemester.Text.Trim();


                    var render = _context.Student_Profile.Where(q => q.SchoolID == schoolID
                    && q.DepartmentID == departmentID && q.CourseID == courseID && q.YearLevel == yearLevel
                    && q.ClassID == classID && q.Semester == semester).FirstOrDefault();

                    if (render == null)
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
                            S_Guardian_contact = textS_Guardian_Contact.Text.Trim(),
                            S_SchoolID = txtS_SchoolID.Text.Trim()
                        };

                        /*_CONTEXT.STUDENTBACKGROUNDS.ADD(S);
                        _CONTEXT.SAVECHANGES();
                        SAVEPROFILE();*/

                        _context.studentBackgrounds.Add(s);
                        _context.SaveChanges();
                        saveProfile();
                        Clear();
                        loadfpStudentList();


                        //saveNewProfile();
                        MessageBox.Show("NEW RECORD ADDED SUCCESSFULLY");
                        openStudList();
                    }
                    else
                    {
                        MessageBox.Show("THERE IS ALREADY AN EXISTING PROFILE RECORDS");
                    }
                }
                else
                {
                    MessageBox.Show("There is already an existing SCHOOL ID in the records.");
                }
            }


        }

        private void PROCEED_Click(object sender, EventArgs e)
        {
            choice = UPDATESTUDENT.updateChoice.ToString();

            if (choice == "addExisting")
            {

                saveDATA.Show();
                studentdataPanel.Hide();
                addstudentPanel.Hide();

            }
            else
            {
                if (textS_Municipality.Text == "" || textS_Citizenship.Text == "" || textS_EmailAdd.Text == "" || textS_Mname.Text == "" || textS_Province.Text == "" || textS_Religion.Text == "" || textS_MobileNumber.Text == "" || comboGender.Text == "" || textS_Fname.Text == "" || textS_Barangay.Text == "" || textS_Lname.Text == "" || txtS_SchoolID.Text == "")
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
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            dgvSubAssignment.Rows.Remove(dgvSubAssignment.CurrentRow);

            dgvSubAssignment.Refresh();
            calculateUnit();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            saveDATA.Hide();
            studentdataPanel.Hide();
            addstudentPanel.Show();
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            studentLoad();
        }
        private void studentLoad()
        {
            schoolID = dgvStudentList.SelectedRows[0].Cells[0].Value.ToString();
            var res = (
                from sp in _context.Student_Profile
                join hel in _context.studentBackgrounds on sp.SchoolID equals hel.S_SchoolID
                join dep in _context.Departments on sp.DepartmentID equals dep.Department_ID.ToString()
                join cor in _context.Courses on sp.CourseID equals cor.CourseID.ToString()
                where sp.SchoolID == schoolID

                select new fPStudentList
                {

                    STUDENT_ID = sp.StudentID.ToString(),
                    SCHOOL_ID = hel.S_SchoolID,
                    DEPARTMENT = dep.Department_Name,
                    COURSE = cor.Course_name,
                    yearLevel = sp.YearLevel,
                    semester = sp.Semester

                }
                ).Distinct();

            dgvStudentLoad.DataSource = res.ToList();
        }

        private void dgvStudentLoad_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudentLoad.SelectedRows.Count > 0)
            {
                studentID = dgvStudentLoad.SelectedRows[0].Cells[0].Value.ToString();
                schoolID = dgvStudentLoad.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void txtSearchSID_TextChanged(object sender, EventArgs e)
        {
            var res = (
            from hel in _context.studentBackgrounds
            .Where(q => DbFunctions.Like(q.S_SchoolID, "%" + txtSearchSID.Text + "%"))

            select new { hel.S_SchoolID, hel.S_fname, hel.S_mname, hel.S_lname }
            ).Distinct();

            dgvStudentList.DataSource = res.ToList();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            var res = from c in _context.Student_Profile
                      where c.StudentID == studentID.ToString()
                      select c;

            if (res == null)
            {
                MessageBox.Show("THERE IS SOMETHING WRONG");
            }
            else
            {
                // Remove the matching customers from the database.
                _context.Student_Profile.RemoveRange(res);
                _context.SaveChanges();
            }
            loadfpStudentList();
        }

        private void dgvStudentLoad_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            UPDATESTUDENT mj = new UPDATESTUDENT();
            mj.TopLevel = false;
            studentdataPanel.Controls.Clear();
            studentdataPanel.Controls.Add(mj);
            mj.Show();
        }
    }
}
