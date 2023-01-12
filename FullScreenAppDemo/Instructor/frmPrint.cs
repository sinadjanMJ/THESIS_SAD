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
    public partial class frmPrint : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public static int departmentID = 0;
        public static int instructorID = 0;
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            var rds = (
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

            /*rs.Value = rds.ToList();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rs);*/

            string instructor = "";
            string instructorName = "";
            string departmentName = "";

            instructorID = InstructorClearance.instructorID;
            departmentID = InstructorClearance.departmentID;
            var res = _context.Instructors.Where(q => q.InstructorID == instructorID).FirstOrDefault();
            if (res != null)
            {
                instructor = res.InstructorID.ToString();
                instructorName = res.Instructor_fname + " " + res.Instructor_mname + " " + res.Instructor_lname;
            }

            var resDep = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();
            if (resDep != null)
            {
                departmentName = resDep.Department_Name;
            }
            //ReportDataSource rds = new ReportDataSource("Product_Detail", ds.Tables[0]);

            ReportParameter pInstructorID = new ReportParameter("pInstructorID", instructor);
            this.reportViewer1.LocalReport.SetParameters(pInstructorID);

            ReportParameter pInstructorName = new ReportParameter("pInstructor", instructorName);
            this.reportViewer1.LocalReport.SetParameters(pInstructorName);

            ReportParameter pDepartment = new ReportParameter("pDepartment", departmentName);
            this.reportViewer1.LocalReport.SetParameters(pDepartment);

            this.reportViewer1.RefreshReport();

        }
    }
}
