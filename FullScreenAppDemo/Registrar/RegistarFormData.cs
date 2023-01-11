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
    public partial class RegistarFormData : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public RegistarFormData()
        {
            InitializeComponent();
        }

        private void RegistarFormData_Load(object sender, EventArgs e)
        {
            int student = _context.studentBackgrounds.Count();
            int dean = _context.Deans.Count();
            int instructor = _context.Instructors.Count();
            int dep = _context.Departments.Count();

            label7.Text = student.ToString();
            label9.Text = dean.ToString();
            label12.Text = instructor.ToString();
            label15.Text = dep.ToString();
        }
    }
}
