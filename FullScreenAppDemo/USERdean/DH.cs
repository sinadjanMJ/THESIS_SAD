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
    public partial class DH : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public DH()
        {
            InitializeComponent();
        }

        private void DH_Load(object sender, EventArgs e)
        {
            int dep = _context.transactionGrades.Where(q => q.status_Dean == "pending").Count();

            label12.Text = dep.ToString();
        }
    }
}
