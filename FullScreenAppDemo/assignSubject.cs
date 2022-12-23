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
        public assignSubject()
        {
            InitializeComponent();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAssign_Click(object sender, EventArgs e)
        {
            db.assignSubject halu = new db.assignSubject
            {
                a_subjectID = (cBSubject.SelectedItem as subjectValue).Value.ToString(),
                a_classID = (cBSection.SelectedItem as classValue).Value.ToString(),
                a_semester = cBSemester.Text.Trim(),
                a_instructorID = (cBInstructor.SelectedItem as instructorValue).Value.ToString()
            };

            _context.assignSubjects.Add(halu);
            _context.SaveChanges();

            loadAssignment();

            this.Hide();
            RegisSubject mj = new RegisSubject();
            mj.Show();
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
        }

        private void cBYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSection();
        }
    }
}
