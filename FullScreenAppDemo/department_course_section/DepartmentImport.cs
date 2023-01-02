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
        int departmentID = 0;
        string choice = "";

        
        public DepartmentImport(RegisDean l)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var selectedRow = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();
            string originalDepName = selectedRow.Department_Name.ToString();
            string depName = textDepartment_name.Text.Trim();

            if (textDepartment_name.Text == "" )
            {
                MessageBox.Show("Fill out the Designated Credential first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                

                if (choice == "add")
                {
                    var setCondition = _context.Departments.Where(q => q.Department_Name == depName).FirstOrDefault();

                    if (setCondition == null)
                    {
                        Department d = new Department
                        {
                            Department_Name = textDepartment_name.Text.Trim()
                        };

                        _context.Departments.Add(d);
                        _context.SaveChanges();
                       
                       
                        MessageBox.Show("Succesfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Insert();
                        this.Close();
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("DEPARTMENT NAME ALREADY EXIST!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else if (choice == "update")
                {
                    var setCondition = _context.Departments.Where(q => q.Department_Name == depName).FirstOrDefault();
                    if (setCondition != null)
                    {
                        string conditionDepName = setCondition.Department_Name.ToString();
                        if (originalDepName == conditionDepName)
                        {
                            selectedRow.Department_Name = textDepartment_name.Text.Trim();
                            _context.SaveChanges();


                            Insert();

                            this.Close();


                            MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            

                            MessageBox.Show("DEPARTMENT NAME ALREADY EXIST!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        selectedRow.Department_Name = textDepartment_name.Text.Trim();
                        _context.SaveChanges();

                        Insert();
                        this.Close();



                        MessageBox.Show("Succesfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            Insert();



        }
        public delegate void UpdatDelegate(object sender, UpdateEventArgs args);
        public event UpdatDelegate UpdateEventHandler;
        

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentImport_Load(object sender, EventArgs e)
        {
            
            departmentID = RegisDean.departmentID;
            choice = RegisDean.choicedepartment.ToString();


            
            if (choice == "update")

            {
                btnSave.Text = "UPDATE";
                var selectedRow = _context.Departments.Where(q => q.Department_ID == departmentID).FirstOrDefault();

                textDepartment_name.Text = selectedRow.Department_Name.ToString();
              
                


            }
            Insert();

        }
        private void openSTList()
        {
            
            RegisDashboard mj = new RegisDashboard();
            mj.Show();

            RegisDean m = new RegisDean();
            m.TopLevel = false;
            //m.dgvDepartmentList.DataSource = ;
            //m.loadData();
            

            mj.DashboardPanel.Controls.Clear();
            mj.DashboardPanel.Controls.Add(m);

            m.Show();

            this.Close();



        }
    }
}
