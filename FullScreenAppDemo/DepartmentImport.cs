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


namespace FullScreenAppDemo
{
    public partial class DepartmentImport : Form
    {
        studentPortalEntities _context = new studentPortalEntities();
        public DepartmentImport(RegisSubject R)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Department d = new Department
            {
                Department_Name = textDepartment_name.Text.Trim()
            };

            _context.Departments.Add(d);
            _context.SaveChanges();

            TabControl de = new TabControl();
            de.Show();
            this.Hide();
            insert();


        }
        public delegate void UpdatDelegate(object sender, UpdateEventArgs args);
        public event UpdatDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
              TabControl de = new TabControl();
            de.Show();
            this.Hide();
        }
    }
}
