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
using Microsoft.Reporting.WinForms;

namespace FullScreenAppDemo
{
    public partial class InstructorClearanceDisplay : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int departmentID = 0;
        public static int instructorID = 0;
        public InstructorClearanceDisplay()
        {
            InitializeComponent();
        }

        private void InstructorClearanceDisplay_Load(object sender, EventArgs e)
        {
            departmentID = InstructorClearance.departmentID;
            instructorID = InstructorClearance.instructorID;
            loadData();
            loadInstructorClearance();
        }

        private void loadInstructorClearance()
        {
            var res = (
                from asb in _context.assignSubjects
                join cl in _context.Class_S on asb.a_classID equals cl.ClassID.ToString()
                join sub in _context.S_Subject on asb.a_subjectID equals sub.SubjectID.ToString()
                join ins in _context.Instructors on asb.a_instructorID equals ins.InstructorID.ToString()
                join tg in _context.transactionGrades on asb.a_id.ToString() equals tg.a_ID
                where ins.InstructorID == instructorID

                select new instructorClearance
                {
                    SECTION = cl.ClassName,
                    SUBJECT = sub.SubjectName,
                    STATUS = tg.status_Registrar
                }

                ).ToList();


            instructorClearanceBindingSource.DataSource = res.ToList();
            dgvClearanceIns.DataSource = res;
        }

        private void loadData()
        {
            var resIns = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();
            if (resIns != null)
            {
                lblInstructor.Text = resIns.Instructor_fname + " " + resIns.Instructor_mname + " " + resIns.Instructor_lname;
            }

            var resDep = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();
            if (resDep != null)
            {
                lblDepartment.Text = resDep.Department_Name;
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ReportDataSource rs = new ReportDataSource();
            List<printClearance> lst = new List<printClearance>();
            lst.Clear();
            string stat = "";

            for (int i = 0; i < dgvClearanceIns.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dgvClearanceIns.Rows[i].Cells[2].Value as string))
                {
                    stat = "PENDING";
                }
                else
                {
                    stat = "CLEARED";
                }

                lst.Add(new printClearance
                {
                    section = dgvClearanceIns.Rows[i].Cells[0].Value.ToString(),
                    subject = dgvClearanceIns.Rows[i].Cells[1].Value.ToString(),
                    status = stat
                });
                rs.Name = "DataSet1";
                rs.Value = lst;
            }

            frmPrint p = new frmPrint();
            p.reportViewer1.LocalReport.DataSources.Clear();
            p.reportViewer1.LocalReport.DataSources.Add(rs);
            p.reportViewer1.LocalReport.ReportEmbeddedResource = "FullScreenAppDemo.rptInstructorClearance.rdlc";

            p.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            InstructorClearance mj = new InstructorClearance();
            mj.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(mj);
            mj.Show();
        }
    }
}
