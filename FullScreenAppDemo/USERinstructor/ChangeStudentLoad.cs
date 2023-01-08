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

namespace FullScreenAppDemo
{
    public partial class ChangeStudentLoad : Form
    {

        studentPortalEntities _context = new studentPortalEntities();

        int classID = 0;
        int instructorID = 0;
        int subjectID = 0;

        string fileName = "";
        List<string> spid = new List<string>();
        public ChangeStudentLoad()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            StudentLoad mj = new StudentLoad();
            mj.TopLevel = false;
            uipanel.Controls.Clear();
            uipanel.Controls.Add(mj);
            mj.Show();
        }

        private void ChangeStudentLoad_Load(object sender, EventArgs e)
        {
            checkList();
        }
        private void checkList()
        {
            if (dgvStudentLoad.Rows.Count <= 0)
            {
                gunaButton1.Visible = false;
            }
            else
            {
                gunaButton1.Visible = true;
            }
        }

        private void PROCEED_Click(object sender, EventArgs e)
        {
            loadCurrentData();
        }
        private void loadCurrentData()
        {
            /*dgvStudent.DataSource = null;
            dgvStudent.Rows.Clear();
            dgvStudent.Columns.Clear();
            dgvStudent.Refresh();*/

            // Clear the rows
            dgvStudentLoad.DataSource = null;
            dgvStudentLoad.Rows.Clear();
            dgvStudentLoad.Columns.Clear();

            // Reset the row count to the original value
            //dgvStudentLoad.RowCount = dgvStudentLoad.RowCount;
            dgvStudentLoad.Refresh();

            classID = Class.classID;
            instructorID = loginInstructor.instructorID;
            subjectID = Class.subjectID;

            var res = (
                from ai in _context.Student_Profile
                    /*join cl in _context.Class_S on ai.ClassID equals classID.ToString()
                    join ins in _context.Instructors on ai.InstructorID equals ins.InstructorID.ToString()
                    join sub in _context.S_Subject on ai.SubjectID equals sub.SubjectID.ToString()*/
                join stud in _context.studentBackgrounds on ai.StudentID equals stud.StudentID.ToString()

                where ai.ClassID == classID.ToString() && ai.InstructorID == instructorID.ToString()
                && ai.SubjectID == subjectID.ToString()

                select new
                {
                    studentID = stud.StudentID,
                    schoolID = stud.S_SchoolID,
                    STUDENT = stud.S_fname + " " + stud.S_mname + " " + stud.S_lname,
                    GRADE = !string.IsNullOrEmpty(ai.Grade.ToString()) ? ai.Grade.ToString() : " "
                    //StudentID = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";
                }
                ).ToList();

            dgvStudentLoad.DataSource = res;
            checkList();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            sFDialog.InitialDirectory = "C";
            sFDialog.Title = "SAVE AS EXCEL FILE";
            sFDialog.FileName = "";
            sFDialog.Filter = "Excel Files (2016|*.xlsx|Excel Files(.CSV)|*.csv";

            if (sFDialog.ShowDialog() != DialogResult.Cancel)
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                excelApp.Columns.ColumnWidth = 28;

                //Where the column name should start
                for (int i = 1; i < dgvStudentLoad.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dgvStudentLoad.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvStudentLoad.Rows.Count; i++)
                {
                    //where the column value should start
                    for (int j = 0; j < dgvStudentLoad.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dgvStudentLoad.Rows[i].Cells[j].Value.ToString();
                        // excelApp.Cells[i + 2, j + 1] = !string.IsNullOrEmpty(dgvStudentLoad.Rows[i].Cells[j].Value.ToString()) ? dgvStudentLoad.Rows[i].Cells[j].Value.ToString() : " ";

                        //StudentID = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";
                    }
                }
                excelApp.ActiveWorkbook.SaveCopyAs(sFDialog.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();

                MessageBox.Show("EXPORT DONE");
            }
            Cursor.Current = Cursors.Default;

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            dgvStudentLoad.DataSource = null;
            dgvStudentLoad.Columns.Clear();
            dgvStudentLoad.Refresh();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Choose the Excel File";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                }

                if (fileName != "")
                {
                    Microsoft.Office.Interop.Excel.Application xlApp;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
                    Microsoft.Office.Interop.Excel.Range xlRange;

                    try
                    {
                        xlApp = new Microsoft.Office.Interop.Excel.Application();
                        xlWorkbook = xlApp.Workbooks.Open(fileName);
                        xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                        xlRange = xlWorksheet.UsedRange;

                        dgvStudentLoad.Columns.Add("studentID", xlRange.Cells[1, 1].Text);
                        dgvStudentLoad.Columns.Add("schoolID", xlRange.Cells[1, 2].Text);
                        dgvStudentLoad.Columns.Add("STUDENT", xlRange.Cells[1, 3].Text);
                        dgvStudentLoad.Columns.Add("GRADE", xlRange.Cells[1, 4].Text);

                        dgvStudentLoad.ColumnCount = xlRange.Columns.Count;

                        for (int xlrow = 2; xlrow <= xlRange.Rows.Count; xlrow++)
                        {
                            dgvStudentLoad.Rows.Add(xlRange.Cells[xlrow, 1].Text, xlRange.Cells[xlrow, 2].Text, xlRange.Cells[xlrow, 3].Text, xlRange.Cells[xlrow, 4].Text);
                        }

                        xlWorkbook.Close();
                        xlApp.Quit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            classID = Class.classID;
            instructorID = loginInstructor.instructorID;
            subjectID = Class.subjectID;

            string studentID = "";
            string schoolID = "";

            /* for(int i = 0; i < dgvStudentLoad.Rows.Count; i++)
             {
                 spid.Add(dgvStudentLoad.Rows[i].Cells[0].Value.ToString());
                 MessageBox.Show(spid[i].ToString());
             }*/

            for (int i = 0; i < dgvStudentLoad.Rows.Count; i++)
            {
                studentID = dgvStudentLoad.Rows[i].Cells[0].Value.ToString();
                schoolID = dgvStudentLoad.Rows[i].Cells[1].Value.ToString();

                var res = _context.Student_Profile.Where(q => q.StudentID == studentID.ToString() && q.SchoolID == schoolID.ToString() &&
                q.ClassID == classID.ToString() && q.SubjectID == subjectID.ToString() && q.InstructorID == instructorID.ToString()).FirstOrDefault();

                if (res != null)
                {
                    //res.Grade = dgvStudentLoad.Rows[i].Cells[3].Value.ToString();
                    if (string.IsNullOrEmpty(dgvStudentLoad.Rows[i].Cells[3].Value as string))
                    {
                        dgvStudentLoad.Rows[i].Cells[3].Value = " ";
                    }
                    res.Grade = !string.IsNullOrEmpty(dgvStudentLoad.Rows[i].Cells[3].Value.ToString()) ? dgvStudentLoad.Rows[i].Cells[3].Value.ToString() : " "; //\0 means empty character
                }
            }

            _context.SaveChanges();
            loadCurrentData();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            dgvStudentLoad.DataSource = null;
            dgvStudentLoad.Rows.Clear();
            dgvStudentLoad.Columns.Clear();

            List<studentLoadwithInst> ais = new List<studentLoadwithInst>();
            dgvStudentLoad.DataSource = ais.ToList();

            // Reset the row count to the original value
            //dgvStudentLoad.RowCount = dgvStudentLoad.RowCount;
            dgvStudentLoad.Refresh();

            classID = Class.classID;
            instructorID = loginInstructor.instructorID;
            subjectID = Class.subjectID;

            var res = (
                from ai in _context.Student_Profile
                    /*join cl in _context.Class_S on ai.ClassID equals classID.ToString()
                    join ins in _context.Instructors on ai.InstructorID equals ins.InstructorID.ToString()
                    join sub in _context.S_Subject on ai.SubjectID equals sub.SubjectID.ToString()*/
                join stud in _context.studentBackgrounds on ai.StudentID equals stud.StudentID.ToString()

                where ai.ClassID == classID.ToString() && ai.InstructorID == instructorID.ToString()
                && ai.SubjectID == subjectID.ToString()

                select new studentLoadwithInst
                {
                    studentID = stud.StudentID,
                    schoolID = stud.S_SchoolID,
                    STUDENT = stud.S_fname + " " + stud.S_mname + " " + stud.S_lname,
                    GRADE = !string.IsNullOrEmpty(ai.Grade.ToString()) ? ai.Grade.ToString() : " "
                    //StudentID = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : " ";
                }
                ).ToList();

            dgvStudentLoad.DataSource = res;

            dgvStudentLoad.Columns.RemoveAt(3); //Certain values moved to 3 after removing index 3 that's why.
            dgvStudentLoad.Columns.RemoveAt(3);
            dgvStudentLoad.Columns.RemoveAt(3);
            dgvStudentLoad.Columns.RemoveAt(3);
            //dgvStudentLoad.Columns.RemoveAt(6);

            dgvStudentLoad.Refresh();
            checkList();
        }
    

    }
}
