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
        public CourseImport(RegisSubject R)
        {
            InitializeComponent();
        }

        private void CourseImport_Load(object sender, EventArgs e)
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (textCourse_name.Text == "" || gunaComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Course c = new Course
                    {
                        Course_name = textCourse_name.Text.Trim(),
                        DepartmentID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString()
                    };

                    _context.Courses.Add(c);
                    _context.SaveChanges();
                    insert();

                    TabControl dl = new TabControl();
                    dl.Show();
                    this.Hide();
                }
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabControl de = new TabControl();
            de.Show();
            this.Hide();
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
