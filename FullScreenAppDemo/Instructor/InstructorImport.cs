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
        public InstructorImport(RegisInstructor R)
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
            if (textInstructor_fname.Text == "" || textInstructor_lname.Text == "" || textInstructor_mname.Text == "" || gunaComboBox1.Text == "")
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    insert();
                    MessageBox.Show("Succesfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
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

    }
}
