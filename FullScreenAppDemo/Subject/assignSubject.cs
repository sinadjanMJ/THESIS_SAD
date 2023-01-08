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
    public partial class assignSubject : Form

    {
        studentPortalEntities _context = new studentPortalEntities();
        DepartmentValue dv = new DepartmentValue();
        subjectValue sv = new subjectValue();
        instructorValue iv = new instructorValue();

      //public  int assignsubjectid = 0;
      //public  string mouseclicked = "";

        int assignSubjectID = 0;
        string mouseClicked = "";

        public assignSubject()
        {
            InitializeComponent();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAssign_Click(object sender, EventArgs e)
        {
            try
            {
                //GET THE NECESSARY DATA FROM COMBO BOX
                string classID = (cBSection.SelectedItem as classValue).Value.ToString();
                string semester = cBSemester.Text.Trim();
                string subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString();
                string instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString();

                if (cBCourse.SelectedIndex == -1 || cBYear.SelectedIndex == -1 || cBSemester.SelectedIndex == -1 || cBDepartment.SelectedIndex == -1 || cBSection.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (btnSaveAssign.Text == "ADD SUBJECT")
                    {

                        if (MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //RENDER IF THERE IS ANY EXISTING DATA
                            var classInfo = _context.assignSubjects.Where(q =>
                        q.a_classID == classID && q.a_semester == semester && q.a_subjectID == subjectID && q.a_instructorID == instructorID).FirstOrDefault();

                            if (classInfo == null) //IT MEANS THERE IS NO EXISTING DATA
                            {
                                //RENDER IF THERE IS ALREADY AN EXISTING SUBJECT IN THE SECTION
                                var subSec = _context.assignSubjects.Where(q => q.a_classID == classID && q.a_subjectID == subjectID).FirstOrDefault();

                                if (subSec == null) //IT MEANS THERE IS NO EXISITNG SUBJECT IN THE SECTION
                                {
                                    db.assignSubject halu = new db.assignSubject
                                    {
                                        a_subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString(),
                                        a_classID = (cBSection.SelectedItem as classValue).Value.ToString(),
                                        a_semester = cBSemester.Text.Trim(),
                                        a_instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString(),
                                        a_status = "edit"
                                    };

                                    _context.assignSubjects.Add(halu);
                                    _context.SaveChanges();

                                    loadAssignment();
                                    clear();
                                    MessageBox.Show("Succesfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }
                                else // IT MEANS THERE IS AN EXISTING SUBJECT IN THE SECTION FOUND
                                {
                                    int convertID = Convert.ToInt32(classID.ToString());
                                    var secName = _context.Class_S.Where(q => q.ClassID == convertID).FirstOrDefault();
                                    string className = secName.ClassName.ToString();

                                    MessageBox.Show("THERE IS ALREADY AN EXISTING SUBJECT IN CLASS : " + className.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else // IT MEANS THERE IS NO EXISTING DATA FOUND
                            {

                                MessageBox.Show("THERE IS ALREADY AN EXISTING DATA", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (btnSaveAssign.Text == "UPDATE")
                    {
                        if (MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //GET YOUR ORIGINAL DATA FROM THE SELECTED CELL
                            var assignSub = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();
                            string oClassID = assignSub.a_classID.ToString();
                            string oSemester = assignSub.a_semester.ToString();
                            string oSubjectID = assignSub.a_subjectID.ToString();
                            string oInstructorID = assignSub.a_instructorID.ToString();

                            //GET THE NECESSARY DATA FROM COMBO BOX
                            classID = (cBSection.SelectedItem as classValue).Value.ToString();
                            semester = cBSemester.Text.Trim();
                            subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString();
                            instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString();

                            //RENDER IF THERE IS ANY EXISTING DATA
                            var classInfo = _context.assignSubjects.Where(q =>
                            q.a_classID == classID && q.a_semester == semester && q.a_subjectID == subjectID && q.a_instructorID == instructorID).FirstOrDefault();

                            if (classInfo != null)
                            {
                                //IF THERE IS AN EXISITNG DATA. CHECK IF IT'S BECAUSE OF YOUR SELECTED CELL
                                string ciClassID = classInfo.a_classID.ToString();
                                string ciSemester = classInfo.a_semester.ToString();
                                string ciSubjectID = classInfo.a_subjectID.ToString();
                                string ciInstructorID = classInfo.a_instructorID.ToString();

                                if (oClassID == ciClassID && oSemester == ciSemester && oSubjectID == ciSubjectID && oInstructorID == ciInstructorID) // IF IT'S BECAUSE OF THE ORIGINAL DATA. THEN PROCEED
                                {
                                    //RENDER IF THERE'S AN EXISTING SUBJECT IN THE SECTION
                                    var subSec = _context.assignSubjects.Where(q => q.a_classID == classID && q.a_subjectID == subjectID).FirstOrDefault();
                                    if (subSec != null) //EXISTING SUBJECT FOUND
                                    {
                                        //IF THERE IS AN EXISITNG SUBJECT. CHECK IF IT'S BECAUSE OF YOUR SELECTED CELL
                                        if (oClassID == ciClassID && oSubjectID == ciSubjectID) // IT'S BECAUSE OF THE SELECTED CELL. PROCEED
                                        {
                                            var updateASub = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();
                                            updateASub.a_classID = (cBSection.SelectedItem as classValue).Value.ToString();
                                            updateASub.a_semester = cBSemester.Text.Trim();
                                            updateASub.a_subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString();
                                            updateASub.a_instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString();

                                            _context.SaveChanges();
                                            loadAssignment();
                                            clear();
                                            btnSaveAssign.Text = "ADD SUBJECT";
                                            btnBack.Text = "GO BACK";

                                            MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            btnDelete.Visible = false;



                                        }
                                        else
                                        {
                                            int convertID = Convert.ToInt32(classID.ToString());
                                            var secName = _context.Class_S.Where(q => q.ClassID == convertID).FirstOrDefault();
                                            string className = secName.ClassName.ToString();
                                            MessageBox.Show("THERE IS ALREADY AN EXISTING SUBJECT IN CLASS : " + className.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                                        }
                                    }
                                    else // IF THERE IS NO EXISTING SUBJECT FOUND
                                    {
                                        var updateASub = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();
                                        updateASub.a_classID = (cBSection.SelectedItem as classValue).Value.ToString();
                                        updateASub.a_semester = cBSemester.Text.Trim();
                                        updateASub.a_subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString();
                                        updateASub.a_instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString();

                                        _context.SaveChanges();
                                        loadAssignment();

                                        clear();
                                        MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnSaveAssign.Text = "ADD SUBJECT";
                                        btnBack.Text = "GO BACK";
                                        btnDelete.Visible = false;



                                    }
                                }
                                else // NOT BECAUSE OF ORIGINAL DATA
                                {

                                    MessageBox.Show("THERE IS ALREADY AN EXISTING DATA", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                //RENDER IF THERE'S AN EXISTING SUBJECT IN THE SECTION
                                var subSec = _context.assignSubjects.Where(q => q.a_classID == classID && q.a_subjectID == subjectID).FirstOrDefault();
                                if (subSec != null) //EXISTING SUBJECT FOUND
                                {
                                    string ciClassID = subSec.a_classID.ToString();
                                    string ciSubjectID = subSec.a_subjectID.ToString();

                                    //IF THERE IS AN EXISITNG SUBJECT. CHECK IF IT'S BECAUSE OF YOUR SELECTED CELL
                                    if (oClassID == ciClassID && oSubjectID == ciSubjectID) // IT'S BECAUSE OF THE SELECTED CELL. PROCEED
                                    {
                                        var updateASub = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();
                                        updateASub.a_classID = (cBSection.SelectedItem as classValue).Value.ToString();
                                        updateASub.a_semester = cBSemester.Text.Trim();
                                        updateASub.a_subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString();
                                        updateASub.a_instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString();

                                        _context.SaveChanges();

                                        loadAssignment();
                                        clear();
                                        MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        btnSaveAssign.Text = "ADD SUBJECT";
                                        btnBack.Text = "GO BACK";
                                        btnDelete.Visible = false;
                                    }
                                    else
                                    {
                                        int convertID = Convert.ToInt32(classID.ToString());
                                        var secName = _context.Class_S.Where(q => q.ClassID == convertID).FirstOrDefault();
                                        string className = secName.ClassName.ToString();

                                        MessageBox.Show("THERE IS ALREADY AN EXISTING SUBJECT IN CLASS : " + className.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else // IF THERE IS NO EXISTING SUBJECT FOUND
                                {
                                    var updateASub = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();
                                    updateASub.a_classID = (cBSection.SelectedItem as classValue).Value.ToString();
                                    updateASub.a_semester = cBSemester.Text.Trim();
                                    updateASub.a_subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString();
                                    updateASub.a_instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString();

                                    _context.SaveChanges();
                                    loadAssignment();
                                    clear();
                                    MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    btnSaveAssign.Text = "ADD SUBJECT";
                                    btnBack.Text = "GO BACK";
                                    btnDelete.Visible = false;


                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR HAPPENS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void assignSubject_Load(object sender, EventArgs e)
        {
            loadAssignment();
            loadDepartment();
            loadSubject();
            loadInstructor();
        }
        private void loadAssignment()
        {
            var res = (
                from ais in _context.assignSubjects
                join cl in _context.Class_S on ais.a_classID equals cl.ClassID.ToString()
                join sl in _context.S_Subject on ais.a_subjectID equals sl.SubjectID.ToString()
                join il in _context.Instructors on ais.a_instructorID equals il.InstructorID.ToString()

                select new assignWithClassSubInstructor
                {
                    ID = ais.a_id,
                    Class_Name = cl.ClassName,
                    Subject_Name = sl.SubjectName,
                    Instructor_Name = il.Instructor_fname + ", " + il.Instructor_lname,
                    Semester = ais.a_semester
                }
                ).ToList();

            dgvAssignInstructor.DataSource = res;
        }

        private void loadInstructor()
        {
            var selected = _context.Instructors.ToList();

            foreach (var item in selected)
            {
                instructorValue iv = new instructorValue();
                iv.Text = item.Instructor_fname + ", " + item.Instructor_lname;
                iv.Value = item.InstructorID;
                cBInstructor.Items.Add(iv);
            }
            cBInstructor.SelectedIndex = -1;
        }

        private void loadSubject()
        {
            var selected = _context.S_Subject.ToList();

            foreach (var item in selected)
            {

                subjectValue sv = new subjectValue();
                sv.Text = item.SubjectName; //Display name
                sv.Value = item.SubjectID; //value inside the name

                cBSubject.Items.Add(sv);
            }
            cBSubject.SelectedIndex = -1;

            //Department_ID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString()
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
                        classValue cv = new classValue();
                        cv.Text = item.ClassName;
                        cv.Value = item.ClassID;

                        cBSection.Items.Add(cv);
                    }
                }
                cBSection.SelectedIndex = -1;
            }
        }

        private void cBCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSection();
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
            loadSection();
            cBYear.SelectedIndex = -1;
        }

        private void cBYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Text == "GO BACK")
            {
                this.Close();
                
            }
            else if (btnBack.Text == "CANCEL UPDATE")
            {
                btnSaveAssign.Text = "ADD SUBJECT";
                btnBack.Text = "GO BACK";
                btnDelete.Visible = false;
                clear();



            }
        }

        public void clear()
        {
           
            cBSubject.SelectedIndex = -1;
        }

        private void dgvAssignInstructor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignInstructor.SelectedRows.Count > 0)
            {
                 assignSubjectID = Convert.ToInt32(dgvAssignInstructor.SelectedRows[0].Cells[0].Value.ToString());
                if (mouseClicked == "yes")
                {
                    loadInfo();
                }
            }
        }
        private void loadInfo()
        {
            if (mouseClicked == "yes")
            {
                loadUpdateInfo();
            }
        }
        private void loadUpdateInfo()
        {
            var assignSub = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();

            int subjectID = Convert.ToInt32(assignSub.a_subjectID.ToString());
            int classID = Convert.ToInt32(assignSub.a_classID.ToString());
            string semester = assignSub.a_semester.ToString();
            int instructorID = Convert.ToInt32(assignSub.a_instructorID.ToString());

            loadUpdateClass(classID);
            loadUpdateSubject(subjectID);
            loadUpdateInstructor(instructorID);
            loadUpdateSemester(semester);
        }
        private void loadUpdateClass(int classID)
        {
            //GET THE DEPARTMENT ID AND COURSE ID AND YEAR LEVEL FROM CLASS ID
            var section = _context.Class_S.Where(q => q.ClassID == classID).FirstOrDefault();

            int departmentID = Convert.ToInt32(section.DepartmentID.ToString());
            int courseID = Convert.ToInt32(section.CourseID.ToString());
            string yearLevel = section.YearLevel.ToString();

            //GET THE DEPARTMENT NAME FROM CONVERTED DEPARTMENT ID
            var department = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();
            if (department != null)
            {
                string departmentName = department.Department_Name.ToString();
                cBDepartment.SelectedIndex = cBDepartment.FindString(departmentName);
            }

            //GET THE COURSE NAME FROM CONVERTED COURSE ID
            var course = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();
            if (course != null)
            {
                string courseName = course.Course_name.ToString();
                cBCourse.SelectedIndex = cBCourse.FindString(courseName);
            }

            //FIND THE YEAR LEVEL STRING
            cBYear.SelectedIndex = cBYear.FindString(yearLevel);

            //GET THE CLASS NAME FROM CLASS ID
            string className = section.ClassName.ToString();
            cBSection.SelectedIndex = cBSection.FindString(className);
        }

        private void loadUpdateSubject(int subjectID)
        {
            var subject = _context.S_Subject.Where(q => q.SubjectID == subjectID).FirstOrDefault();

            if (subject != null)
            {
                string subjectName = subject.SubjectName.ToString();
                cBSubject.SelectedIndex = cBSubject.FindString(subjectName);
            }
        }

        private void loadUpdateInstructor(int instructorID)
        {
            var instructor = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();

            if (instructor != null)
            {
                string instructorName = instructor.Instructor_fname + ", " + instructor.Instructor_lname;
                cBInstructor.SelectedIndex = cBInstructor.FindString(instructorName);
            }
        }
        private void loadUpdateSemester(string semester)
        {
            cBSemester.SelectedIndex = cBSemester.FindString(semester);
        }

        private void dgvAssignInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mouseClicked = "yes";
            btnSaveAssign.Text = "UPDATE";
            btnBack.Text = "CANCEL UPDATE";
            btnDelete.Visible = true;
            loadInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedData = _context.assignSubjects.Where(q => q.a_id == assignSubjectID).FirstOrDefault();

                _context.assignSubjects.Remove(selectedData);
                _context.SaveChanges();
                loadAssignment();

                clear();
                MessageBox.Show("Succesfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveAssign.Text = "ADD SUBJECT";
                btnBack.Text = "GO BACK";
                btnDelete.Visible = false;

            }
        }
    }
}
