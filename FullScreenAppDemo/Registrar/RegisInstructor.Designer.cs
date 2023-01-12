namespace FullScreenAppDemo
{
    partial class RegisInstructor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisInstructor));
            this.instructorWithDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.btnDELETE = new Guna.UI.WinForms.GunaButton();
            this.btnAddInstructor = new Guna.UI.WinForms.GunaButton();
            this.dgvInstructorList = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorWithDeptBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.instructorWithDeptBindingSource)).BeginInit();
            this.DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorWithDeptBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.btnDELETE);
            this.DashboardPanel.Controls.Add(this.btnAddInstructor);
            this.DashboardPanel.Controls.Add(this.dgvInstructorList);
            this.DashboardPanel.Controls.Add(this.gunaCirclePictureBox2);
            this.DashboardPanel.Controls.Add(this.label4);
            this.DashboardPanel.Controls.Add(this.gunaPictureBox1);
            this.DashboardPanel.Location = new System.Drawing.Point(3, 4);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1175, 683);
            this.DashboardPanel.TabIndex = 11;
            // 
            // btnDELETE
            // 
            this.btnDELETE.AnimationHoverSpeed = 0.07F;
            this.btnDELETE.AnimationSpeed = 0.03F;
            this.btnDELETE.BackColor = System.Drawing.Color.Transparent;
            this.btnDELETE.BaseColor = System.Drawing.Color.Maroon;
            this.btnDELETE.BorderColor = System.Drawing.Color.Black;
            this.btnDELETE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDELETE.FocusedColor = System.Drawing.Color.Empty;
            this.btnDELETE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.Gold;
            this.btnDELETE.Image = null;
            this.btnDELETE.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDELETE.Location = new System.Drawing.Point(350, 214);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDELETE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDELETE.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDELETE.OnHoverImage = null;
            this.btnDELETE.OnPressedColor = System.Drawing.Color.Black;
            this.btnDELETE.Radius = 5;
            this.btnDELETE.Size = new System.Drawing.Size(160, 42);
            this.btnDELETE.TabIndex = 12;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDELETE.Visible = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.AnimationHoverSpeed = 0.07F;
            this.btnAddInstructor.AnimationSpeed = 0.03F;
            this.btnAddInstructor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddInstructor.BaseColor = System.Drawing.Color.Maroon;
            this.btnAddInstructor.BorderColor = System.Drawing.Color.Black;
            this.btnAddInstructor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddInstructor.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddInstructor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstructor.ForeColor = System.Drawing.Color.Gold;
            this.btnAddInstructor.Image = null;
            this.btnAddInstructor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddInstructor.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddInstructor.Location = new System.Drawing.Point(184, 214);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddInstructor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddInstructor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.OnHoverImage = null;
            this.btnAddInstructor.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddInstructor.Radius = 5;
            this.btnAddInstructor.Size = new System.Drawing.Size(160, 42);
            this.btnAddInstructor.TabIndex = 11;
            this.btnAddInstructor.Text = "ADD INSTRUCTOR";
            this.btnAddInstructor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // dgvInstructorList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInstructorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstructorList.AutoGenerateColumns = false;
            this.dgvInstructorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstructorList.BackgroundColor = System.Drawing.Color.White;
            this.dgvInstructorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInstructorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstructorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInstructorList.ColumnHeadersHeight = 21;
            this.dgvInstructorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructorIDDataGridViewTextBoxColumn,
            this.instructorNameDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn});
            this.dgvInstructorList.DataSource = this.instructorWithDeptBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructorList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInstructorList.EnableHeadersVisualStyles = false;
            this.dgvInstructorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInstructorList.Location = new System.Drawing.Point(184, 274);
            this.dgvInstructorList.Name = "dgvInstructorList";
            this.dgvInstructorList.RowHeadersVisible = false;
            this.dgvInstructorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructorList.Size = new System.Drawing.Size(770, 249);
            this.dgvInstructorList.TabIndex = 10;
            this.dgvInstructorList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvInstructorList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructorList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInstructorList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInstructorList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInstructorList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInstructorList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructorList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInstructorList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvInstructorList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInstructorList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInstructorList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvInstructorList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInstructorList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvInstructorList.ThemeStyle.ReadOnly = false;
            this.dgvInstructorList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInstructorList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstructorList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInstructorList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInstructorList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvInstructorList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInstructorList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInstructorList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInstructorList_CellMouseDoubleClick);
            this.dgvInstructorList.SelectionChanged += new System.EventHandler(this.dgvInstructorList_SelectionChanged);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(184, 62);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 9;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Instructor Data Form";
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "InstructorID";
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            // 
            // instructorNameDataGridViewTextBoxColumn
            // 
            this.instructorNameDataGridViewTextBoxColumn.DataPropertyName = "Instructor_Name";
            this.instructorNameDataGridViewTextBoxColumn.HeaderText = "Instructor_Name";
            this.instructorNameDataGridViewTextBoxColumn.Name = "instructorNameDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // instructorWithDeptBindingSource1
            // 
            this.instructorWithDeptBindingSource1.DataSource = typeof(FullScreenAppDemo.perips.InstructorWithDept);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(673, -9);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(499, 473);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 85;
            this.gunaPictureBox1.TabStop = false;
            // 
            // RegisInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 736);
            this.Controls.Add(this.DashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisInstructor";
            this.Text = "InstructorDashboard";
            this.Load += new System.EventHandler(this.RegisInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instructorWithDeptBindingSource)).EndInit();
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorWithDeptBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource instructorWithDeptBindingSource;
        private System.Windows.Forms.BindingSource instructorWithDeptBindingSource1;
        private System.Windows.Forms.Panel DashboardPanel;
        private Guna.UI.WinForms.GunaButton btnDELETE;
        private Guna.UI.WinForms.GunaButton btnAddInstructor;
        private Guna.UI.WinForms.GunaDataGridView dgvInstructorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}