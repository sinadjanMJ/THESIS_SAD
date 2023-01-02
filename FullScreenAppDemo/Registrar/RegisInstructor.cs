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
    public partial class RegisInstructor : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public static string instructorID = "";
        public static string choice = "";
        public RegisInstructor()
        {
            InitializeComponent();
        }

        

        private void F2_UpdateEventHandler1(object sender, InstructorImport.UpdateEventArgs args)
        {
            loadins();
        }
        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            choice = "add";
            InstructorImport std = new InstructorImport(this);
            std.UpdateEventHandler += F2_UpdateEventHandler1;
            std.ShowDialog();
        }

        private void RegisInstructor_Load(object sender, EventArgs e)
        {
            loadins();
        }

        public void loadins()
        {
            var res1 = (
                           from ins in _context.Instructors
                           join deps in _context.Departments
                           on ins.Department_ID equals deps.Department_ID.ToString()

                           select new InstructorWithDept
                           {
                               InstructorID = ins.InstructorID,
                               Instructor_Name = ins.Instructor_fname + ", " + ins.Instructor_lname,
                               Department_Name = deps.Department_Name
                           }

                           ).ToList();

            dgvInstructorList.DataSource = res1;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            int convertInstructorID = Int32.Parse(instructorID.ToString());
            var selectedRow = _context.Instructors.Where(q => q.InstructorID == convertInstructorID).FirstOrDefault();

            //MessageBox.Show("Are you sure you want to delete?",)
            _context.Instructors.Remove(selectedRow);
            _context.SaveChanges();

            loadins();
            btnDELETE.Visible = false;
        }

        private void dgvInstructorList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstructorList.SelectedRows.Count > 0)
            {
                instructorID = dgvInstructorList.SelectedRows[0].Cells[0].Value.ToString();
            }
            btnDELETE.Visible = true;
        }

        private void dgvInstructorList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            choice = "update";
            InstructorImport std = new InstructorImport(this);
            std.UpdateEventHandler += F2_UpdateEventHandler1;
            std.ShowDialog();
        }
    }
}
