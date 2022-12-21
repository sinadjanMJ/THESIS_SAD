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


namespace FullScreenAppDemo
{
    public partial class RegisStudent : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static string studentID = "";
        public RegisStudent()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();

            }
        }

        private void MinimizedBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisDashboard mj = new RegisDashboard();
            mj.Show();
        }

        private void StudentBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisStudent mj = new RegisStudent();
            mj.Show();
        }

        private void InstructorBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisInstructor mj = new RegisInstructor();
            mj.Show();
        }

        private void AcademicsBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisAcademics mj = new RegisAcademics();
            mj.Show();
        }

        private void DeanBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisDean mj = new RegisDean();
            mj.Show();
        }

        private void RegisStudent_Load(object sender, EventArgs e)
        {
            dgvStudentList.DataSource = _context.studentBackgrounds.ToList();
            
            tabControl1.Hide();
            studentdataPanel.Show();
            addstudentPanel.Hide();
            updatePanel.Hide();
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
            tabControl1.Hide();
            studentdataPanel.Hide();
            addstudentPanel.Show();
            updatePanel.Hide();

        }

        private void btnSave_Click(object sender, EventArgs e)
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
            MessageBox.Show("STUDENT ADDED SUCCESSFULLY");
            openStudList(); 
            dgvStudentList.DataSource = _context.studentBackgrounds.ToList();

        }
        private void openStudList()
        {

            tabControl1.Hide();
            studentdataPanel.Show();
            addstudentPanel.Hide();
            updatePanel.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            studentdataPanel.Show();
            addstudentPanel.Hide();
            updatePanel.Hide();

        }
    }
}
