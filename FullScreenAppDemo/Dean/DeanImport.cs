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
    public partial class DeanImport : Form
    {

        studentPortalEntities _context = new studentPortalEntities();
        DepartmentValue dv = new DepartmentValue();
        public DeanImport()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textDean_fname.Text == "" || textDean_lname.Text == "" || textDean_mname.Text == "" || gunaComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Dean dn = new Dean
                    {
                        Dean_fname = textDean_fname.Text.Trim(),
                        Dean_mname = textDean_mname.Text.Trim(),
                        Dean_lname = textDean_lname.Text.Trim(),
                        Department_ID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString()
                    };

                    _context.Deans.Add(dn);
                    _context.SaveChanges();

                    RegisDean d = new RegisDean();
                    d.Show();
                    this.Hide();
                }
            }
           

        }

        private void DeanImport_Load(object sender, EventArgs e)
        {
            var selected = _context.Departments.ToList();

            foreach (var item in selected)
            {
                DepartmentValue dv = new DepartmentValue();
                dv.Text = item.Department_Name; //Display name
                dv.Value = item.Department_ID; //value inside the name

                gunaComboBox1.Items.Add(dv);
            }
            gunaComboBox1.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RegisDean d = new RegisDean();
            d.Show();
            this.Hide();
        }
    }
}
