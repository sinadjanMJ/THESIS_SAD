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
    public partial class InstructorImport : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        DepartmentValue dv = new DepartmentValue();
        public InstructorImport()
        {
            InitializeComponent();
        }

        private void InstructorImport_Load(object sender, EventArgs e)
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
            Instructor i = new Instructor
            {
                Instructor_fname = textInstructor_fname.Text.Trim(),
                Instructor_mname = textInstructor_mname.Text.Trim(),
                Instructor_lname = textInstructor_lname.Text.Trim(),
                Department_ID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString()
            };

            _context.Instructors.Add(i);
            _context.SaveChanges();

            RegisInstructor ii = new RegisInstructor();
            ii.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RegisInstructor ii = new RegisInstructor();
            ii.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();

            }
        }
    }
}
