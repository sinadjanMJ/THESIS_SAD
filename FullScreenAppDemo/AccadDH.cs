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
    public partial class AccadDH : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public AccadDH()
        {
            InitializeComponent();
        }

        private void AccadDH_Load(object sender, EventArgs e)
        {
            int dep = 0;
          
            dep = _context.transactionGrades.Where(q => q.status_Registrar == "pending").Count();

            label15.Text = dep.ToString();
            
        }
    }
}
