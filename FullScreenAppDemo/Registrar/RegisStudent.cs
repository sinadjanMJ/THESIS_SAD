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
        int studID;
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

            loadList();
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

        private void dgvStudentList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            loadList();
            tabControl1.Hide();
            studentdataPanel.Hide();
            addstudentPanel.Hide();
            updatePanel.Show();
        }
        private void openSTList()
        {
            tabControl1.Hide();
            studentdataPanel.Show();
            addstudentPanel.Hide();
            updatePanel.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int studID = Int32.Parse(studentID.ToString());
            var selectedRow = _context.studentBackgrounds.Where(q => q.StudentID == studID).FirstOrDefault();

            _context.studentBackgrounds.Remove(selectedRow);
            _context.SaveChanges();
            dgvStudentList.DataSource = _context.studentBackgrounds.ToList();
        }

        public void loadList()
        {

            studID = Int32.Parse(studentID.ToString());
            var selectedRowID = _context.studentBackgrounds.Where(q => q.StudentID == studID).FirstOrDefault();


            U_StudentID.Text = selectedRowID.StudentID.ToString().Trim();
            U_FNAME.Text = selectedRowID.S_fname.ToString().Trim();
            U_MIDDLENAME.Text = selectedRowID.S_mname.ToString().Trim();
            U_LASTNAME.Text = selectedRowID.S_lname.ToString().Trim();
            U_GENDER.Text = selectedRowID.S_Sex.ToString().Trim();
            U_BIRTHDATE.Value = Convert.ToDateTime(selectedRowID.S_Birthdate.ToString());
            U_NUMBER.Text = selectedRowID.S_mNumber.ToString().Trim();
            U_EMAIL.Text = selectedRowID.S_emailAdd.ToString().Trim();
            U_RELIGION.Text = selectedRowID.S_Religion.ToString().Trim();
            U_CITIZEN.Text = selectedRowID.S_Citizenship.ToString().Trim();
            U_PROVINCE.Text = selectedRowID.S_Province.ToString().Trim();
            U_MUNICIPALITY.Text = selectedRowID.S_municipality.ToString().Trim();
            U_BRGY.Text = selectedRowID.S_barangay.ToString().Trim();
            U_GFNAME.Text = selectedRowID.S_Guardian_fname.ToString().Trim();
            U_GMIDDLENAME.Text = selectedRowID.S_Guardian_mname.ToString().Trim();
            U_GLASTNAME.Text = selectedRowID.S_Guardian_lname.ToString().Trim();
            U_GNUMBER.Text = selectedRowID.S_Guardian_contact.ToString().Trim();
        }

        private void UPDATEBTN_Click(object sender, EventArgs e)
        {
            var selectedRowID = _context.studentBackgrounds.Where(q => q.StudentID == studID).FirstOrDefault();

            selectedRowID.S_fname = U_FNAME.Text.Trim();
            selectedRowID.S_mname = U_MIDDLENAME.Text.Trim();
            selectedRowID.S_lname = U_LASTNAME.Text.Trim();
            selectedRowID.S_Sex = U_GENDER.Text.Trim();
            selectedRowID.S_Birthdate = U_BIRTHDATE.Text.Trim();
            selectedRowID.S_mNumber = U_NUMBER.Text.Trim();
            selectedRowID.S_emailAdd = U_EMAIL.Text.Trim();
            selectedRowID.S_Religion = U_RELIGION.Text.Trim();
            selectedRowID.S_Citizenship = U_CITIZEN.Text.Trim();
            selectedRowID.S_Province = U_PROVINCE.Text.Trim();
            selectedRowID.S_municipality = U_MUNICIPALITY.Text.Trim();
            selectedRowID.S_barangay = U_BRGY.Text.Trim();
            selectedRowID.S_Guardian_fname = U_GFNAME.Text.Trim();
            selectedRowID.S_Guardian_mname = U_GMIDDLENAME.Text.Trim();
            selectedRowID.S_Guardian_lname = U_GLASTNAME.Text.Trim();
            selectedRowID.S_Guardian_contact = U_GNUMBER.Text.Trim();

            _context.SaveChanges();
             dgvStudentList.DataSource = _context.studentBackgrounds.ToList();
            openSTList();
        }

        private void UCANCELBTN_Click(object sender, EventArgs e)
        {
            openSTList();
        }
    }
}
