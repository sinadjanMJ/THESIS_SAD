﻿namespace FullScreenAppDemo
{
    partial class RegisDean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisDean));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnDelete = new System.Windows.Forms.TabPage();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.dgvDeanList = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAddDean = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletecourse = new Guna.UI.WinForms.GunaButton();
            this.deletedepartment = new Guna.UI.WinForms.GunaButton();
            this.dgvCourseList = new Guna.UI.WinForms.GunaDataGridView();
            this.btnCourse = new Guna.UI.WinForms.GunaButton();
            this.btnAddDepartment = new Guna.UI.WinForms.GunaButton();
            this.studentPortalDataSet = new FullScreenAppDemo.studentPortalDataSet();
            this.deanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deanTableAdapter = new FullScreenAppDemo.studentPortalDataSetTableAdapters.DeanTableAdapter();
            this.dgvDepartmentList = new Guna.UI.WinForms.GunaDataGridView();
            this.deanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deanWithDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseImpsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regisDeanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DashboardPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.btnDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeanList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPortalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanWithDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseImpsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisDeanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.tabControl1);
            this.DashboardPanel.Location = new System.Drawing.Point(2, 2);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1175, 733);
            this.DashboardPanel.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.btnDelete);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1172, 727);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Controls.Add(this.gunaButton1);
            this.btnDelete.Controls.Add(this.dgvDeanList);
            this.btnDelete.Controls.Add(this.btnAddDean);
            this.btnDelete.Controls.Add(this.gunaCirclePictureBox2);
            this.btnDelete.Controls.Add(this.label4);
            this.btnDelete.Location = new System.Drawing.Point(4, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(3);
            this.btnDelete.Size = new System.Drawing.Size(1164, 697);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Dean";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Gold;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(144, 582);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "DELETE";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Visible = false;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // dgvDeanList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDeanList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeanList.AutoGenerateColumns = false;
            this.dgvDeanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeanList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeanList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeanList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeanList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeanList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeanList.ColumnHeadersHeight = 21;
            this.dgvDeanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deanIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.deanNameDataGridViewTextBoxColumn});
            this.dgvDeanList.DataSource = this.deanWithDepartmentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeanList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeanList.EnableHeadersVisualStyles = false;
            this.dgvDeanList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeanList.Location = new System.Drawing.Point(144, 326);
            this.dgvDeanList.Name = "dgvDeanList";
            this.dgvDeanList.RowHeadersVisible = false;
            this.dgvDeanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeanList.Size = new System.Drawing.Size(850, 239);
            this.dgvDeanList.TabIndex = 15;
            this.dgvDeanList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDeanList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeanList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDeanList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDeanList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDeanList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDeanList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeanList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeanList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvDeanList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDeanList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeanList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvDeanList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDeanList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvDeanList.ThemeStyle.ReadOnly = false;
            this.dgvDeanList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeanList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeanList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeanList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDeanList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDeanList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeanList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDeanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeanList_CellClick);
            this.dgvDeanList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeanList_CellMouseDoubleClick);
            this.dgvDeanList.SelectionChanged += new System.EventHandler(this.dgvDeanList_SelectionChanged);
            // 
            // btnAddDean
            // 
            this.btnAddDean.AnimationHoverSpeed = 0.07F;
            this.btnAddDean.AnimationSpeed = 0.03F;
            this.btnAddDean.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDean.BaseColor = System.Drawing.Color.Maroon;
            this.btnAddDean.BorderColor = System.Drawing.Color.Black;
            this.btnAddDean.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDean.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDean.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDean.ForeColor = System.Drawing.Color.Gold;
            this.btnAddDean.Image = null;
            this.btnAddDean.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDean.Location = new System.Drawing.Point(144, 267);
            this.btnAddDean.Name = "btnAddDean";
            this.btnAddDean.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnAddDean.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDean.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDean.OnHoverImage = null;
            this.btnAddDean.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDean.Radius = 5;
            this.btnAddDean.Size = new System.Drawing.Size(160, 42);
            this.btnAddDean.TabIndex = 14;
            this.btnAddDean.Text = "ADD DEAN";
            this.btnAddDean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDean.Click += new System.EventHandler(this.btnAddDean_Click_1);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(143, 71);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 13;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            this.gunaCirclePictureBox2.Click += new System.EventHandler(this.gunaCirclePictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 54);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dean Data Form";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dgvDepartmentList);
            this.tabPage2.Controls.Add(this.gunaCirclePictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.deletecourse);
            this.tabPage2.Controls.Add(this.deletedepartment);
            this.tabPage2.Controls.Add(this.dgvCourseList);
            this.tabPage2.Controls.Add(this.btnCourse);
            this.tabPage2.Controls.Add(this.btnAddDepartment);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1164, 697);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Department and Course";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.ErrorImage = null;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(213, 18);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 21;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 54);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department and Course  Data Form";
            // 
            // deletecourse
            // 
            this.deletecourse.AnimationHoverSpeed = 0.07F;
            this.deletecourse.AnimationSpeed = 0.03F;
            this.deletecourse.BackColor = System.Drawing.Color.Transparent;
            this.deletecourse.BaseColor = System.Drawing.Color.Maroon;
            this.deletecourse.BorderColor = System.Drawing.Color.Black;
            this.deletecourse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletecourse.FocusedColor = System.Drawing.Color.Empty;
            this.deletecourse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecourse.ForeColor = System.Drawing.Color.Gold;
            this.deletecourse.Image = null;
            this.deletecourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletecourse.ImageSize = new System.Drawing.Size(20, 20);
            this.deletecourse.Location = new System.Drawing.Point(392, 389);
            this.deletecourse.Name = "deletecourse";
            this.deletecourse.OnHoverBaseColor = System.Drawing.Color.Red;
            this.deletecourse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletecourse.OnHoverForeColor = System.Drawing.Color.White;
            this.deletecourse.OnHoverImage = null;
            this.deletecourse.OnPressedColor = System.Drawing.Color.Black;
            this.deletecourse.Radius = 5;
            this.deletecourse.Size = new System.Drawing.Size(160, 42);
            this.deletecourse.TabIndex = 19;
            this.deletecourse.Text = "DELETE COURSE";
            this.deletecourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletecourse.Visible = false;
            this.deletecourse.Click += new System.EventHandler(this.deletecourse_Click);
            // 
            // deletedepartment
            // 
            this.deletedepartment.AnimationHoverSpeed = 0.07F;
            this.deletedepartment.AnimationSpeed = 0.03F;
            this.deletedepartment.BackColor = System.Drawing.Color.Transparent;
            this.deletedepartment.BaseColor = System.Drawing.Color.Maroon;
            this.deletedepartment.BorderColor = System.Drawing.Color.Black;
            this.deletedepartment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletedepartment.FocusedColor = System.Drawing.Color.Empty;
            this.deletedepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedepartment.ForeColor = System.Drawing.Color.Gold;
            this.deletedepartment.Image = null;
            this.deletedepartment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletedepartment.ImageSize = new System.Drawing.Size(20, 20);
            this.deletedepartment.Location = new System.Drawing.Point(392, 138);
            this.deletedepartment.Name = "deletedepartment";
            this.deletedepartment.OnHoverBaseColor = System.Drawing.Color.Red;
            this.deletedepartment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletedepartment.OnHoverForeColor = System.Drawing.Color.White;
            this.deletedepartment.OnHoverImage = null;
            this.deletedepartment.OnPressedColor = System.Drawing.Color.Black;
            this.deletedepartment.Radius = 5;
            this.deletedepartment.Size = new System.Drawing.Size(160, 42);
            this.deletedepartment.TabIndex = 18;
            this.deletedepartment.Text = "DELETE DEPARTMENT";
            this.deletedepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletedepartment.Visible = false;
            this.deletedepartment.Click += new System.EventHandler(this.deletedepartment_Click);
            // 
            // dgvCourseList
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCourseList.AutoGenerateColumns = false;
            this.dgvCourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourseList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCourseList.ColumnHeadersHeight = 21;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn2});
            this.dgvCourseList.DataSource = this.courseImpsBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourseList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourseList.Location = new System.Drawing.Point(213, 437);
            this.dgvCourseList.Name = "dgvCourseList";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCourseList.RowHeadersVisible = false;
            this.dgvCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseList.Size = new System.Drawing.Size(738, 150);
            this.dgvCourseList.TabIndex = 17;
            this.dgvCourseList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCourseList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvCourseList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCourseList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCourseList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvCourseList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCourseList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCourseList.ThemeStyle.ReadOnly = false;
            this.dgvCourseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCourseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCourseList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCourseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCourseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseList_CellClick);
            this.dgvCourseList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourseList_CellMouseDoubleClick);
            this.dgvCourseList.SelectionChanged += new System.EventHandler(this.dgvCourseList_SelectionChanged);
            // 
            // btnCourse
            // 
            this.btnCourse.AnimationHoverSpeed = 0.07F;
            this.btnCourse.AnimationSpeed = 0.03F;
            this.btnCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnCourse.BaseColor = System.Drawing.Color.Maroon;
            this.btnCourse.BorderColor = System.Drawing.Color.Black;
            this.btnCourse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCourse.FocusedColor = System.Drawing.Color.Empty;
            this.btnCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.Gold;
            this.btnCourse.Image = null;
            this.btnCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCourse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCourse.Location = new System.Drawing.Point(213, 389);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCourse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCourse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCourse.OnHoverImage = null;
            this.btnCourse.OnPressedColor = System.Drawing.Color.Black;
            this.btnCourse.Radius = 5;
            this.btnCourse.Size = new System.Drawing.Size(160, 42);
            this.btnCourse.TabIndex = 16;
            this.btnCourse.Text = "ADD COURSE";
            this.btnCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.AnimationHoverSpeed = 0.07F;
            this.btnAddDepartment.AnimationSpeed = 0.03F;
            this.btnAddDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDepartment.BaseColor = System.Drawing.Color.Maroon;
            this.btnAddDepartment.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddDepartment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDepartment.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.Gold;
            this.btnAddDepartment.Image = null;
            this.btnAddDepartment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDepartment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDepartment.Location = new System.Drawing.Point(213, 138);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddDepartment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDepartment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.OnHoverImage = null;
            this.btnAddDepartment.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDepartment.Radius = 5;
            this.btnAddDepartment.Size = new System.Drawing.Size(160, 42);
            this.btnAddDepartment.TabIndex = 14;
            this.btnAddDepartment.Text = "ADD DEPARTMENT";
            this.btnAddDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // studentPortalDataSet
            // 
            this.studentPortalDataSet.DataSetName = "studentPortalDataSet";
            this.studentPortalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deanBindingSource
            // 
            this.deanBindingSource.DataMember = "Dean";
            this.deanBindingSource.DataSource = this.studentPortalDataSet;
            // 
            // deanTableAdapter
            // 
            this.deanTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDepartmentList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartmentList.AutoGenerateColumns = false;
            this.dgvDepartmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartmentList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartmentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartmentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDepartmentList.ColumnHeadersHeight = 21;
            this.dgvDepartmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvDepartmentList.DataSource = this.departmentBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartmentList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDepartmentList.EnableHeadersVisualStyles = false;
            this.dgvDepartmentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.Location = new System.Drawing.Point(213, 186);
            this.dgvDepartmentList.Name = "dgvDepartmentList";
            this.dgvDepartmentList.RowHeadersVisible = false;
            this.dgvDepartmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartmentList.Size = new System.Drawing.Size(738, 150);
            this.dgvDepartmentList.TabIndex = 22;
            this.dgvDepartmentList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepartmentList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvDepartmentList.ThemeStyle.ReadOnly = false;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepartmentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDepartmentList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDepartmentList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDepartmentList_CellMouseDoubleClick_1);
            this.dgvDepartmentList.SelectionChanged += new System.EventHandler(this.dgvDepartmentList_SelectionChanged_1);
            // 
            // deanIDDataGridViewTextBoxColumn
            // 
            this.deanIDDataGridViewTextBoxColumn.DataPropertyName = "DeanID";
            this.deanIDDataGridViewTextBoxColumn.HeaderText = "DeanID";
            this.deanIDDataGridViewTextBoxColumn.Name = "deanIDDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // deanNameDataGridViewTextBoxColumn
            // 
            this.deanNameDataGridViewTextBoxColumn.DataPropertyName = "Dean_Name";
            this.deanNameDataGridViewTextBoxColumn.HeaderText = "Dean_Name";
            this.deanNameDataGridViewTextBoxColumn.Name = "deanNameDataGridViewTextBoxColumn";
            // 
            // deanWithDepartmentBindingSource
            // 
            this.deanWithDepartmentBindingSource.DataSource = typeof(FullScreenAppDemo.perips.DeanWithDepartment);
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Department_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Department_Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(FullScreenAppDemo.db.Department);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // departmentNameDataGridViewTextBoxColumn2
            // 
            this.departmentNameDataGridViewTextBoxColumn2.DataPropertyName = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn2.HeaderText = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn2.Name = "departmentNameDataGridViewTextBoxColumn2";
            // 
            // courseImpsBindingSource
            // 
            this.courseImpsBindingSource.DataSource = typeof(FullScreenAppDemo.perips.courseImps);
            // 
            // regisDeanBindingSource
            // 
            this.regisDeanBindingSource.DataSource = typeof(FullScreenAppDemo.RegisDean);
            // 
            // RegisDean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 736);
            this.Controls.Add(this.DashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisDean";
            this.Text = "RegisDean";
            this.Load += new System.EventHandler(this.RegisDean_Load);
            this.DashboardPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.btnDelete.ResumeLayout(false);
            this.btnDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeanList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPortalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanWithDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseImpsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisDeanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.BindingSource regisDeanBindingSource;
        private studentPortalDataSet studentPortalDataSet;
        private System.Windows.Forms.BindingSource deanBindingSource;
        private studentPortalDataSetTableAdapters.DeanTableAdapter deanTableAdapter;
        private System.Windows.Forms.BindingSource deanWithDepartmentBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage btnDelete;
        private Guna.UI.WinForms.GunaDataGridView dgvDeanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn deanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deanNameDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton btnAddDean;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton deletecourse;
        private Guna.UI.WinForms.GunaButton deletedepartment;
        private Guna.UI.WinForms.GunaDataGridView dgvCourseList;
        private Guna.UI.WinForms.GunaButton btnCourse;
        private Guna.UI.WinForms.GunaButton btnAddDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource courseImpsBindingSource;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDataGridView dgvDepartmentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}