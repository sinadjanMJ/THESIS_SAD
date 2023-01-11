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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace FullScreenAppDemo
{
    public partial class uDeanRejectedForm : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int deanID = 0;
        public static int a_ID = 0;

        string fileName = "";
        public uDeanRejectedForm()
        {
            InitializeComponent();
        }

        private void uDeanRejectedForm_Load(object sender, EventArgs e)
        {
            dgvClassLoadList.Columns[0].Visible = false;
            dgvClassLoadList.Columns[1].Visible = false;
            dgvClassLoadList.Columns[3].Visible = false;

            if (loginDean.deanID != 0)
            {
                deanID = loginDean.deanID;
                loadRejected();
            }
        }
        private void loadRejected()
        {
            var res = (
              from ai in _context.assignSubjects
              join sub in _context.S_Subject on ai.a_subjectID equals sub.SubjectID.ToString()
              join ins in _context.Instructors on ai.a_instructorID equals ins.InstructorID.ToString()
              join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
              join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
              join dn in _context.Deans on cl.DepartmentID equals dn.Department_ID.ToString()
              where dn.DeanID == deanID && tg.status_Dean == "pending" && tg.status_Registrar == "rejected"

              select new uDeanListGrade
              {
                  a_ID = ai.a_id.ToString(),
                  SubjectID = sub.SubjectID,
                  Subject = sub.SubjectName,
                  instructorID = ins.InstructorID.ToString(),
                  instructor = ins.Instructor_fname + " " + ins.Instructor_mname + " " + ins.Instructor_lname,
                  SEMESTER = ai.a_semester
              }

              ).ToList();

            dgvClassLoadList.DataSource = res;
        }

        private void dgvClassLoadList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClassLoadList.SelectedRows.Count > 0)
            {
                a_ID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[0].Value.ToString());
                loadFeedback();
            }
        }
        private void loadFeedback()
        {
            var res = _context.transactionGrades.Where(q => q.a_ID == a_ID.ToString()).FirstOrDefault();
            if (res != null)
            {
                lbl_Feedback.Text = res.feedback_Registrar;
            }
        }

        private void btnBackToInstructor_Click(object sender, EventArgs e)
        {
            var transactionGrade = _context.transactionGrades.Where(q => q.a_ID == a_ID.ToString()).FirstOrDefault();
            if (transactionGrade != null)
            {
                transactionGrade.feedback_Dean = txtFeedback.Text.Trim();
                transactionGrade.status_Dean = "rejected";
                transactionGrade.status_Registrar = "";
                _context.SaveChanges();

                MessageBox.Show("Successfully sent back to the Instructor");

                txtFeedback.Text = "";
                loadRejected();
            }
            else
            {
                MessageBox.Show("Entity not found");
            }
        }

        private void dgvClassLoadList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var res = _context.assignSubjects.Where(q => q.a_id == a_ID).FirstOrDefault();
            if (res != null)
            {
                fileName = res.a_FileLocation;
                openFile();
            }
            else
            {
                MessageBox.Show("Entity not found");
            }
        }
        private void openFile()
        {
            try
            {
                //MessageBox.Show(fileName);
                if (fileName != "")
                {
                    var excelApp = new Excel.Application();
                    excelApp.Visible = true;

                    Excel.Workbooks books = excelApp.Workbooks;
                    Excel.Workbook sheet = books.Open(fileName, ReadOnly: true);
                }
                else
                {
                    MessageBox.Show("File not found. Sent it back to the Instructor to create a corresponding file.");
                }
            }
            catch
            {
                MessageBox.Show("File not found");
            }
        }
    }
}
