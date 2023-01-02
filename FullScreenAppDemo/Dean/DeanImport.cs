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

        string choice = "";
        int deanID = 0;
        public DeanImport(RegisDean R)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textDean_fname.Text == "" || textDean_lname.Text == "" || gunaComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                    string depID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();
                    var selected = _context.Deans.Where(q => q.Department_ID == depID).FirstOrDefault();
                if (choice == "add")

                {
                    

                    if (selected == null)
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
                            this.Close();
                            insert();
                            MessageBox.Show("Succesfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                       
                        MessageBox.Show("There is already designated dean to the selected Department. Pick another.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else if (choice == "update")

                {
                    

                    if (MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int convertdepID = Int32.Parse(depID);

                        var selDep = _context.Departments.Where(q => q.Department_ID == convertdepID).FirstOrDefault();
                        var deanDep = _context.Deans.Where(q => q.DeanID == deanID).FirstOrDefault();

                        string deanDepID = deanDep.Department_ID;
                        string selDepID = selDep.Department_ID.ToString();

                        if (deanDepID == selDepID || selected == null)
                        {
                            deanDep.Dean_fname = textDean_fname.Text.Trim();
                            deanDep.Dean_mname = textDean_mname.Text.Trim();
                            deanDep.Dean_lname = textDean_lname.Text.Trim();
                            deanDep.Department_ID = (gunaComboBox1.SelectedItem as DepartmentValue).Value.ToString();

                            _context.SaveChanges();
                            this.Close();
                            insert();
                            MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                       
                            MessageBox.Show("There is already designated dean to the selected Department. Pick another.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
            }
           

        }

        private void DeanImport_Load(object sender, EventArgs e)
        {
            choice = RegisDean.choicedean.ToString();
            deanID = RegisDean.deanID;

            if (choice == "add")
            {
                btnSave.Text = "SAVE";
                var selected = _context.Departments.ToList();

                foreach (var item in selected)
                {
                    DepartmentValue dv = new DepartmentValue();
                    dv.Text = item.Department_Name; //Display name
                    dv.Value = item.Department_ID; //value inside the name

                    gunaComboBox1.Items.Add(dv);
                }
                gunaComboBox1.SelectedIndex = 0;
                insert();
            }
            else if (choice == "update")
            {
                btnSave.Text = "UPDATE";
                var selected = _context.Departments.ToList();

                var deanIDs = _context.Deans.FirstOrDefault(q => q.DeanID == deanID);
                string deanDepartment = deanIDs.Department_ID.ToString();

                int departmentIDConvert = Int32.Parse(deanDepartment);
                var departmentIDs = _context.Departments.FirstOrDefault(q => q.Department_ID == departmentIDConvert);
                string departmentNames = departmentIDs.Department_Name.ToString();

                foreach (var item in selected)
                {
                    DepartmentValue dv = new DepartmentValue();
                    dv.Text = item.Department_Name; //Display name
                    dv.Value = item.Department_ID; //value inside the name

                    gunaComboBox1.Items.Add(dv);
                }

                gunaComboBox1.SelectedIndex = gunaComboBox1.FindString(departmentNames);

                //DELIVER TEXT VALUES TO TEXTBOXES
                textDean_fname.Text = deanIDs.Dean_fname.ToString();
                textDean_mname.Text = deanIDs.Dean_mname.ToString();
                textDean_lname.Text = deanIDs.Dean_lname.ToString();
                insert();
            }
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

            this.Close();
        }
    }
}
