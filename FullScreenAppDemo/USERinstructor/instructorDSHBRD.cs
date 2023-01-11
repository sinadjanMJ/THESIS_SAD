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
    public partial class instructorDSHBRD : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        public instructorDSHBRD()
        {
            InitializeComponent();
        }

        private void instructorDSHBRD_Load(object sender, EventArgs e)
        {
            int dep = 0;
            int re = 0;
             dep = _context.assignSubjects.Where(q => q.a_status == "pending").Count();
             re = _context.assignSubjects.Where(q => q.a_status == "rejected").Count();

            label6.Text = dep.ToString();
            label1.Text = re.ToString();
        }
    }
}
