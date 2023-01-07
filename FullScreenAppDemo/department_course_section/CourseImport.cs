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
    public partial class CourseImport : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        DepartmentValue dv = new DepartmentValue();
        string choice = "";
        int courseID = 0;


        
        
        public CourseImport(RegisDean R)
        {
            InitializeComponent();
        }

        private void CourseImport_Load(object sender, EventArgs e)
        {
            courseID = RegisDean.courseID;
            choice = RegisDean.choicecourse.ToString();

           

            if (choice == "add")
            {
                var selected = _context.Departments.ToList();

                foreach (var item in selected)
                {
                    DepartmentValue dv = new DepartmentValue();
                    dv.Text = item.Department_Name; //Display name
                    dv.Value = item.Department_ID; //value inside the name

                    gunaComboBox1.Items.Add(dv);
                }
                gunaComboBox1.SelectedIndex = 0;
                insert();
            }
            else if (choice == "update")
            {
                var selected = _context.Departments.ToList();

                //int idCourseConvert = courseID;
                //var instructorIDs = _context.Instructors.FirstOrDefault(q => q.InstructorID == idInstructorConvert);
                var courseIDs = _context.Courses.FirstOrDefault(q => q.CourseID == courseID);
                string courseDepartment = courseIDs.DepartmentID.ToString();

                int departmentIDConvert = Int32.Parse(courseDepartment);
                var departmentIDs = _context.Departments.FirstOrDefault(q => q.Department_ID == departmentIDConvert);
                string departmentNames = departmentIDs.Department_Name.ToString();

                foreach (var item in selected)
                {
                    DepartmentValue dv = new DepartmentValue();
                    dv.Text = item.Department_Name; //Display name
                    dv.Value = item.Department_ID; //value inside the name

                    gunaComboBox1.Items.Add(dv);
                }

                gunaComboBox1.SelectedIndex = gunaComboBox1.FindString(departmentNames);

                //GET THE VALUE FROM COURSES
                var selectedCourse = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();
                textCourse_name.Text = selectedCourse.Course_name.ToString();

                insert();
                btnSave.Text = "UPDATE";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCourse_name.Text == "" || gunaComboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    //string getCourseName = textCourse_name.Text.Trim();
                    //string getDepID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                    //var originalCourse = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();
                    //string originalCourseName = originalCourse.Course_name.ToString();
                    //string originalDepID = originalCourse.DepartmentID.ToString();
                    string getCourseName = textCourse_name.Text.Trim();
                    string getDepID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                    string originalCourseName = "";
                    string originalDepID = "";
                    var originalCourse = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();
                    if (originalCourse != null)
                    {
                        originalCourseName = originalCourse.Course_name.ToString();
                        originalDepID = originalCourse.DepartmentID.ToString();
                    }

                    if (choice == "add")
                    {
                        if (MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            var setCondition = _context.Courses.Where(q => q.Course_name == getCourseName).FirstOrDefault();

                            if (setCondition == null)
                            {
                                var setCondition2 = _context.Courses.Where(q => q.DepartmentID == getDepID && q.Course_name == getCourseName).FirstOrDefault();
                                if (setCondition2 == null)
                                {
                                    Course c = new Course
                                    {
                                        Course_name = textCourse_name.Text.Trim(),
                                        DepartmentID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString()
                                    };

                                    _context.Courses.Add(c);
                                    _context.SaveChanges();
                                    insert();

                                    MessageBox.Show("Succesfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Close();
                                }
                                else
                                {

                                    MessageBox.Show("THE DATA ALREADY EXIST!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {

                                MessageBox.Show("COURSE NAME ALREADY EXIST!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }
                    else if (choice == "update")
                    {
                        var setCondition = _context.Courses.Where(q => q.Course_name == getCourseName).FirstOrDefault();
                        var selectedCourse = _context.Courses.Where(q => q.CourseID == courseID).FirstOrDefault();


                        if (MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            if (setCondition != null)
                            {
                                string conditionCourseName = setCondition.Course_name.ToString();
                                if (conditionCourseName == originalCourseName)
                                {
                                    var setCondition2 = _context.Courses.Where(q => q.DepartmentID == getDepID && q.Course_name == getCourseName).FirstOrDefault();
                                    if (setCondition2 != null)
                                    {
                                        conditionCourseName = setCondition2.Course_name.ToString();
                                        string conditionDepID = setCondition2.DepartmentID.ToString();

                                        if (conditionCourseName == originalCourseName && conditionDepID == originalDepID)
                                        {
                                            selectedCourse.Course_name = textCourse_name.Text.Trim();
                                            selectedCourse.DepartmentID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                                            _context.SaveChanges();
                                            insert();
                                            MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {

                                            MessageBox.Show("THE DATA ALREADY EXIST!");
                                        }
                                    }
                                    else
                                    {
                                        selectedCourse.Course_name = textCourse_name.Text.Trim();
                                        selectedCourse.DepartmentID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                                        _context.SaveChanges();
                                        insert();
                                        MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("COURSE NAME ALREADY EXIST!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                var setCondition2 = _context.Courses.Where(q => q.DepartmentID == getDepID && q.Course_name == getCourseName).FirstOrDefault();
                                if (setCondition2 != null)
                                {
                                    string conditionCourseName = setCondition2.Course_name.ToString();
                                    string conditionDepID = setCondition2.DepartmentID.ToString();

                                    if (conditionCourseName == originalCourseName && conditionDepID == originalDepID)
                                    {
                                        selectedCourse.Course_name = textCourse_name.Text.Trim();
                                        selectedCourse.DepartmentID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                                        _context.SaveChanges();
                                        insert();

                                        MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {

                                        MessageBox.Show("THE DATA ALREADY EXIST!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                }
                                else
                                {
                                    selectedCourse.Course_name = textCourse_name.Text.Trim();
                                    selectedCourse.DepartmentID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                                    _context.SaveChanges();
                                    insert();


                                    MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }


                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("THERE'S SOMETHING ERROR HAPPEN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public delegate void UpdatDelegate(object sender, UpdateEventArgs args);
        public event UpdatDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();

            }
        }
    }
}
