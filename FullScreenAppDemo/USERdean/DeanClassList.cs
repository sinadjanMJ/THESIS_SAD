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
    public partial class DeanClassList : Form

    {
        studentPortalEntities _context = new studentPortalEntities();
        public static string classID = "";
        public static int a_ID = 0;
        public static int subjectID = 0;
        public static int instructorID = 0;

        public DeanClassList()
        {
            InitializeComponent();
        }

        private void DeanClassList_Load(object sender, EventArgs e)
        {
            dgvClassLoadList.Columns[0].Visible = false;
            dgvClassLoadList.Columns[1].Visible = false;
            dgvClassLoadList.Columns[3].Visible = false;

            if (DeanformDH.classID != "")
            {
                classID = DeanformDH.classID;
            }

            loadLabels();
            loadClassList();
        }
        private void loadLabels()
        {
            int convertID = Int32.Parse(classID);
            var res = _context.Class_S.Where(q => q.ClassID == convertID).FirstOrDefault();

            if (res != null)
            {
                lblClassName.Text = res.ClassName;
                lblYearLevel.Text = res.YearLevel;
            }
        }

        private void loadClassList()
        {
            int convertID = Int32.Parse(classID);
            var res = (
               from ai in _context.assignSubjects
               join sub in _context.S_Subject on ai.a_subjectID equals sub.SubjectID.ToString()
               join ins in _context.Instructors on ai.a_instructorID equals ins.InstructorID.ToString()
               join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
               join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
               where cl.ClassID == convertID && tg.status_Instructor == "sent" && tg.status_Dean == "pending"

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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int convertID = Int32.Parse(classID);
            string sem = cbSemester.Text.Trim();

            var res = (
               from ai in _context.assignSubjects
               join sub in _context.S_Subject on ai.a_subjectID equals sub.SubjectID.ToString()
               join ins in _context.Instructors on ai.a_instructorID equals ins.InstructorID.ToString()
               join tg in _context.transactionGrades on ai.a_id.ToString() equals tg.a_ID
               join cl in _context.Class_S on ai.a_classID equals cl.ClassID.ToString()
               where cl.ClassID == convertID && tg.status_Instructor == "sent" && tg.status_Dean == "pending"
               && ai.a_semester == sem

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadClassList();
            cbSemester.SelectedIndex = 0;
        }

        private void dgvClassLoadList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClassLoadList.SelectedRows.Count > 0)
            {
                a_ID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[0].Value.ToString());
                subjectID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[1].Value.ToString());
                instructorID = Int32.Parse(dgvClassLoadList.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private void dgvClassLoadList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DEANSTUDENTGRADE mj = new DEANSTUDENTGRADE();
            mj.TopLevel = false;
            uipanelclass.Controls.Clear();
            uipanelclass.Controls.Add(mj);
            mj.Show();
            //this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DeanformDH mj = new DeanformDH();
            mj.TopLevel = false;
            uipanelclass.Controls.Clear();
            uipanelclass.Controls.Add(mj);
            mj.Show();
        }
    }
}
