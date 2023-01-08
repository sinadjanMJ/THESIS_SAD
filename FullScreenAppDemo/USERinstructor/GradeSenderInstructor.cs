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
    public partial class GradeSenderInstructor : Form
    {

        studentPortalEntities _context = new studentPortalEntities();

     //   string classID = "";
        string instructorID = "";
     //   string subjectID = "";

        string selectedClassID = "";
        string selectedSubjectID = "";
        string selectedA_ID = "";

       // string rejectedA_ID = "";
        public GradeSenderInstructor()
        {
            InitializeComponent();
        }

        private void GradeSenderInstructor_Load(object sender, EventArgs e)
        {
            dgvPendingGrade.Columns[0].Visible = false;
            dgvPendingGrade.Columns[1].Visible = false;
            dgvPendingGrade.Columns[3].Visible = false;

            //dgvSentGrade.Columns[0].Visible = false;
            //dgvSentGrade.Columns[1].Visible = false;
            //dgvSentGrade.Columns[3].Visible = false;

            
            loadPendingGrade();
            //loadSentGrade();
           
        }
        private void loadPendingGrade()
        {

            instructorID = loginInstructor.instructorID.ToString();

            string convertID = instructorID.ToString();
            var renderLoad = _context.assign_Instructor.Where(q => q.ai_instructorID == convertID).ToList();

            var res = (
                from ai in _context.assignSubjects
                join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
                join sli in _context.S_Subject on ai.a_subjectID equals sli.SubjectID.ToString()
                where ai.a_instructorID == instructorID.ToString() && ai.a_status == "pending"

                select new userInWithClassList
                {
                    a_ID = ai.a_id.ToString(),
                    ClassID = cl.ClassID,
                    Class_name = cl.ClassName,
                    SubjectID = sli.SubjectID,
                    Subject = sli.SubjectName,
                    yearLevel = cl.YearLevel,
                    SEMESTER = ai.a_semester
                }
                ).ToList();

            dgvPendingGrade.DataSource = res;
        }

        private void dgvPendingGrade_SelectionChanged(object sender, EventArgs e)
        {
            getIDs();
        }

        private void dgvPendingGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIDs();
        }
        private void getIDs()
        {
            if (dgvPendingGrade.SelectedRows.Count > 0)
            {
                selectedA_ID = dgvPendingGrade.SelectedRows[0].Cells[0].Value.ToString();
                selectedClassID = dgvPendingGrade.SelectedRows[0].Cells[1].Value.ToString();
                selectedSubjectID = dgvPendingGrade.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            int convertID = 0;
            if (selectedA_ID.ToString() != "")
            {
                convertID = Int32.Parse(selectedA_ID.ToString());
            }
            //convertID = Int32.Parse(selectedA_ID.ToString());
            var res = _context.assignSubjects.Where(q => q.a_id == convertID).FirstOrDefault();

            if (res != null)
            {
                res.a_status = "edit";
                _context.SaveChanges();
                loadPendingGrade();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            int convertID = 0;
            if (selectedA_ID.ToString() != "")
            {
                convertID = Int32.Parse(selectedA_ID.ToString());
            }
            //MessageBox.Show("Class ID : " + res.a_classID.ToString());
            var res = _context.assignSubjects.Where(q => q.a_id == convertID).FirstOrDefault();
            if (res != null)
            {
                res.a_status = "sent";

                var renderRes = _context.transactionGrades.Where(q => q.a_ID == convertID.ToString()).FirstOrDefault();
                if (renderRes != null) //THERE IS ALREADY AN EXISTING RECORDS
                {
                    renderRes.feedback_Instructor = textFeedback.Text.Trim();
                    renderRes.status_Instructor = "sent";
                    renderRes.status_Dean = "pending";
                }
                else //SINCE IT'S NULL, ADD NEW RECORD
                {
                    transactionGrade tg = new transactionGrade
                    {
                        a_ID = selectedA_ID.ToString(),
                        feedback_Instructor = textFeedback.Text.Trim(),
                        status_Instructor = "sent",
                        status_Dean = "pending"
                    };
                    _context.transactionGrades.Add(tg);
                }

                _context.SaveChanges();
                MessageBox.Show("PENDING GRADE SENT TO DEAN");
                loadPendingGrade();
                textFeedback.Text = "";
            }
            else
            {
                MessageBox.Show("Entity not found");
            }

        }
    }
}
