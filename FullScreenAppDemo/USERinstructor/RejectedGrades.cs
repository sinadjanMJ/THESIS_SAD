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
    public partial class RejectedGrades : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        
        string instructorID = "";
        string rejectedA_ID = "";

        public RejectedGrades()
        {
            InitializeComponent();
        }

        private void dgvRejected_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRejected.SelectedRows.Count > 0)
            {
                rejectedA_ID = dgvRejected.SelectedRows[0].Cells[0].Value.ToString();
            }

            //LOAD DEAN'S FEEDBACK
            var res = _context.transactionGrades.Where(q => q.a_ID == rejectedA_ID).FirstOrDefault();
            if (res != null)
            {
                lblDeanFeedback.Text = res.feedback_Dean;
            }
        }

        private void RejectedGrades_Load(object sender, EventArgs e)
        {
            dgvRejected.Columns[0].Visible = false;
            dgvRejected.Columns[1].Visible = false;
            dgvRejected.Columns[3].Visible = false;

            instructorID = loginInstructor.instructorID.ToString();
            //loadSentGrade();
            rejectedGrade();
        }
        private void rejectedGrade()
        {
            var res = (
                from asb in _context.assignSubjects
                join tgs in _context.transactionGrades on asb.a_id.ToString() equals tgs.a_ID
                join cls in _context.Class_S on asb.a_classID equals cls.ClassID.ToString()
                join sub in _context.S_Subject on asb.a_subjectID equals sub.SubjectID.ToString()
                join ins in _context.Instructors on asb.a_instructorID equals ins.InstructorID.ToString()
                where asb.a_instructorID == instructorID.ToString() && tgs.status_Dean == "rejected"

                select new userInWithClassList
                {
                    a_ID = asb.a_id.ToString(),
                    ClassID = cls.ClassID,
                    Class_name = cls.ClassName,
                    SubjectID = sub.SubjectID,
                    Subject = sub.SubjectName,
                    yearLevel = cls.YearLevel,
                    SEMESTER = asb.a_semester
                }

                ).ToList();

            dgvRejected.DataSource = res;
        }

        private void PROCEED_Click(object sender, EventArgs e)
        {
          try
          {
            if (MessageBox.Show("Are you sure you want to Send it to Pending", "Sending in Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int convertID = 0;
                if (rejectedA_ID != "")
                {
                    convertID = Int32.Parse(rejectedA_ID);
                }
                var res = _context.assignSubjects.Where(q => q.a_id == convertID).FirstOrDefault();

                if (res != null)
                {
                    res.a_status = "pending";
                    _context.SaveChanges();

                    var resTransact = _context.transactionGrades.Where(q => q.a_ID == rejectedA_ID).FirstOrDefault();
                    if (resTransact != null)
                    {
                        resTransact.status_Instructor = "pending";
                        resTransact.status_Dean = "";
                        _context.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Entity not found");
                }
                rejectedGrade();
            }

            }
            catch
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    

    }
}
