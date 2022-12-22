
namespace FullScreenAppDemo
{
    partial class RegisSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisSubject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBTN = new Guna.UI.WinForms.GunaButton();
            this.MinimizedBTN = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Subject = new Guna.UI.WinForms.GunaButton();
            this.DeanBTN = new Guna.UI.WinForms.GunaButton();
            this.StudentBTN = new Guna.UI.WinForms.GunaButton();
            this.AcademicsBTN = new Guna.UI.WinForms.GunaButton();
            this.InstructorBTN = new Guna.UI.WinForms.GunaButton();
            this.DashboardBTN = new Guna.UI.WinForms.GunaButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvCourseList = new Guna.UI.WinForms.GunaDataGridView();
            this.btnCourse = new Guna.UI.WinForms.GunaButton();
            this.dgvDepartmentList = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAddDepartment = new Guna.UI.WinForms.GunaButton();
            this.studentPortalDataSet1 = new FullScreenAppDemo.studentPortalDataSet1();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new FullScreenAppDemo.studentPortalDataSet1TableAdapters.DepartmentTableAdapter();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPortalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.CloseBTN);
            this.panel1.Controls.Add(this.MinimizedBTN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 52);
            this.panel1.TabIndex = 6;
            // 
            // CloseBTN
            // 
            this.CloseBTN.AnimationHoverSpeed = 0.07F;
            this.CloseBTN.AnimationSpeed = 0.03F;
            this.CloseBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CloseBTN.BorderColor = System.Drawing.Color.Black;
            this.CloseBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseBTN.FocusedColor = System.Drawing.Color.Empty;
            this.CloseBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Image = ((System.Drawing.Image)(resources.GetObject("CloseBTN.Image")));
            this.CloseBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseBTN.Location = new System.Drawing.Point(1320, 8);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.OnHoverBaseColor = System.Drawing.Color.Red;
            this.CloseBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseBTN.OnHoverImage = null;
            this.CloseBTN.OnPressedColor = System.Drawing.Color.Black;
            this.CloseBTN.Size = new System.Drawing.Size(42, 38);
            this.CloseBTN.TabIndex = 4;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // MinimizedBTN
            // 
            this.MinimizedBTN.AnimationHoverSpeed = 0.07F;
            this.MinimizedBTN.AnimationSpeed = 0.03F;
            this.MinimizedBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.MinimizedBTN.BorderColor = System.Drawing.Color.Black;
            this.MinimizedBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizedBTN.FocusedColor = System.Drawing.Color.Empty;
            this.MinimizedBTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizedBTN.ForeColor = System.Drawing.Color.Gray;
            this.MinimizedBTN.Image = ((System.Drawing.Image)(resources.GetObject("MinimizedBTN.Image")));
            this.MinimizedBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinimizedBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.MinimizedBTN.Location = new System.Drawing.Point(1272, 8);
            this.MinimizedBTN.Name = "MinimizedBTN";
            this.MinimizedBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.MinimizedBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MinimizedBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.MinimizedBTN.OnHoverImage = null;
            this.MinimizedBTN.OnPressedColor = System.Drawing.Color.Black;
            this.MinimizedBTN.Size = new System.Drawing.Size(42, 38);
            this.MinimizedBTN.TabIndex = 3;
            this.MinimizedBTN.Click += new System.EventHandler(this.MinimizedBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(60, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amping permi , nikaon naka";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gold;
            this.label18.Location = new System.Drawing.Point(653, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Welcome to Mga Palaatik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(60, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CRMC STUDENT PORTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gunaCirclePictureBox1);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 138);
            this.panel4.TabIndex = 6;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.ErrorImage = null;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(63, 17);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(58, 58);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 3;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(76, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "Admin";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Michel Jay Gwapo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.Subject);
            this.panel2.Controls.Add(this.DeanBTN);
            this.panel2.Controls.Add(this.StudentBTN);
            this.panel2.Controls.Add(this.AcademicsBTN);
            this.panel2.Controls.Add(this.InstructorBTN);
            this.panel2.Controls.Add(this.DashboardBTN);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 736);
            this.panel2.TabIndex = 7;
            // 
            // Subject
            // 
            this.Subject.AnimationHoverSpeed = 0.07F;
            this.Subject.AnimationSpeed = 0.03F;
            this.Subject.BackColor = System.Drawing.Color.Transparent;
            this.Subject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Subject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.Subject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Subject.FocusedColor = System.Drawing.Color.Empty;
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Subject.ForeColor = System.Drawing.Color.Gray;
            this.Subject.Image = ((System.Drawing.Image)(resources.GetObject("Subject.Image")));
            this.Subject.ImageOffsetX = 5;
            this.Subject.ImageSize = new System.Drawing.Size(20, 20);
            this.Subject.Location = new System.Drawing.Point(10, 462);
            this.Subject.Name = "Subject";
            this.Subject.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.Subject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Subject.OnHoverForeColor = System.Drawing.Color.White;
            this.Subject.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Subject.OnHoverImage")));
            this.Subject.OnPressedColor = System.Drawing.Color.Black;
            this.Subject.Radius = 20;
            this.Subject.Size = new System.Drawing.Size(177, 45);
            this.Subject.TabIndex = 12;
            this.Subject.Text = "Subject";
            this.Subject.TextOffsetX = 10;
            this.Subject.Click += new System.EventHandler(this.Subject_Click);
            // 
            // DeanBTN
            // 
            this.DeanBTN.AnimationHoverSpeed = 0.07F;
            this.DeanBTN.AnimationSpeed = 0.03F;
            this.DeanBTN.BackColor = System.Drawing.Color.Transparent;
            this.DeanBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DeanBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.DeanBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeanBTN.FocusedColor = System.Drawing.Color.Empty;
            this.DeanBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeanBTN.ForeColor = System.Drawing.Color.Gray;
            this.DeanBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeanBTN.Image")));
            this.DeanBTN.ImageOffsetX = 5;
            this.DeanBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.DeanBTN.Location = new System.Drawing.Point(10, 407);
            this.DeanBTN.Name = "DeanBTN";
            this.DeanBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.DeanBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeanBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.DeanBTN.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("DeanBTN.OnHoverImage")));
            this.DeanBTN.OnPressedColor = System.Drawing.Color.Black;
            this.DeanBTN.Radius = 20;
            this.DeanBTN.Size = new System.Drawing.Size(177, 45);
            this.DeanBTN.TabIndex = 11;
            this.DeanBTN.Text = "Dean";
            this.DeanBTN.TextOffsetX = 10;
            this.DeanBTN.Click += new System.EventHandler(this.DeanBTN_Click);
            // 
            // StudentBTN
            // 
            this.StudentBTN.AnimationHoverSpeed = 0.07F;
            this.StudentBTN.AnimationSpeed = 0.03F;
            this.StudentBTN.BackColor = System.Drawing.Color.Transparent;
            this.StudentBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.StudentBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.StudentBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StudentBTN.FocusedColor = System.Drawing.Color.Empty;
            this.StudentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.StudentBTN.ForeColor = System.Drawing.Color.Gray;
            this.StudentBTN.Image = ((System.Drawing.Image)(resources.GetObject("StudentBTN.Image")));
            this.StudentBTN.ImageOffsetX = 5;
            this.StudentBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.StudentBTN.Location = new System.Drawing.Point(10, 234);
            this.StudentBTN.Name = "StudentBTN";
            this.StudentBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.StudentBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StudentBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.StudentBTN.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("StudentBTN.OnHoverImage")));
            this.StudentBTN.OnPressedColor = System.Drawing.Color.Black;
            this.StudentBTN.Radius = 20;
            this.StudentBTN.Size = new System.Drawing.Size(177, 45);
            this.StudentBTN.TabIndex = 10;
            this.StudentBTN.Text = "Student";
            this.StudentBTN.TextOffsetX = 10;
            this.StudentBTN.Click += new System.EventHandler(this.StudentBTN_Click);
            // 
            // AcademicsBTN
            // 
            this.AcademicsBTN.AnimationHoverSpeed = 0.07F;
            this.AcademicsBTN.AnimationSpeed = 0.03F;
            this.AcademicsBTN.BackColor = System.Drawing.Color.Transparent;
            this.AcademicsBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.AcademicsBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.AcademicsBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AcademicsBTN.FocusedColor = System.Drawing.Color.Empty;
            this.AcademicsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.AcademicsBTN.ForeColor = System.Drawing.Color.Gray;
            this.AcademicsBTN.Image = ((System.Drawing.Image)(resources.GetObject("AcademicsBTN.Image")));
            this.AcademicsBTN.ImageOffsetX = 5;
            this.AcademicsBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.AcademicsBTN.Location = new System.Drawing.Point(10, 351);
            this.AcademicsBTN.Name = "AcademicsBTN";
            this.AcademicsBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.AcademicsBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AcademicsBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.AcademicsBTN.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("AcademicsBTN.OnHoverImage")));
            this.AcademicsBTN.OnPressedColor = System.Drawing.Color.Black;
            this.AcademicsBTN.Radius = 20;
            this.AcademicsBTN.Size = new System.Drawing.Size(177, 45);
            this.AcademicsBTN.TabIndex = 9;
            this.AcademicsBTN.Text = "Academics";
            this.AcademicsBTN.TextOffsetX = 10;
            this.AcademicsBTN.Click += new System.EventHandler(this.AcademicsBTN_Click);
            // 
            // InstructorBTN
            // 
            this.InstructorBTN.AnimationHoverSpeed = 0.07F;
            this.InstructorBTN.AnimationSpeed = 0.03F;
            this.InstructorBTN.BackColor = System.Drawing.Color.Transparent;
            this.InstructorBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.InstructorBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.InstructorBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.InstructorBTN.FocusedColor = System.Drawing.Color.Empty;
            this.InstructorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.InstructorBTN.ForeColor = System.Drawing.Color.Gray;
            this.InstructorBTN.Image = ((System.Drawing.Image)(resources.GetObject("InstructorBTN.Image")));
            this.InstructorBTN.ImageOffsetX = 5;
            this.InstructorBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.InstructorBTN.Location = new System.Drawing.Point(10, 293);
            this.InstructorBTN.Name = "InstructorBTN";
            this.InstructorBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.InstructorBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.InstructorBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.InstructorBTN.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("InstructorBTN.OnHoverImage")));
            this.InstructorBTN.OnPressedColor = System.Drawing.Color.Black;
            this.InstructorBTN.Radius = 20;
            this.InstructorBTN.Size = new System.Drawing.Size(177, 45);
            this.InstructorBTN.TabIndex = 8;
            this.InstructorBTN.Text = "Instructor";
            this.InstructorBTN.TextOffsetX = 10;
            this.InstructorBTN.Click += new System.EventHandler(this.InstructorBTN_Click);
            // 
            // DashboardBTN
            // 
            this.DashboardBTN.AnimationHoverSpeed = 0.07F;
            this.DashboardBTN.AnimationSpeed = 0.03F;
            this.DashboardBTN.BackColor = System.Drawing.Color.Transparent;
            this.DashboardBTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DashboardBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.DashboardBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DashboardBTN.FocusedColor = System.Drawing.Color.Empty;
            this.DashboardBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.DashboardBTN.ForeColor = System.Drawing.Color.Gray;
            this.DashboardBTN.Image = ((System.Drawing.Image)(resources.GetObject("DashboardBTN.Image")));
            this.DashboardBTN.ImageOffsetX = 5;
            this.DashboardBTN.ImageSize = new System.Drawing.Size(20, 20);
            this.DashboardBTN.Location = new System.Drawing.Point(10, 177);
            this.DashboardBTN.Name = "DashboardBTN";
            this.DashboardBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.DashboardBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DashboardBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.DashboardBTN.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("DashboardBTN.OnHoverImage")));
            this.DashboardBTN.OnPressedColor = System.Drawing.Color.Black;
            this.DashboardBTN.Radius = 20;
            this.DashboardBTN.Size = new System.Drawing.Size(177, 45);
            this.DashboardBTN.TabIndex = 7;
            this.DashboardBTN.Text = "Dashboard";
            this.DashboardBTN.TextOffsetX = 10;
            this.DashboardBTN.Click += new System.EventHandler(this.DashboardBTN_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(202, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 655);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Subject";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1152, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Section";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvCourseList);
            this.tabPage3.Controls.Add(this.btnCourse);
            this.tabPage3.Controls.Add(this.dgvDepartmentList);
            this.tabPage3.Controls.Add(this.btnAddDepartment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1152, 629);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Department";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvCourseList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCourseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourseList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourseList.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourseList.Location = new System.Drawing.Point(207, 368);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.RowHeadersVisible = false;
            this.dgvCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseList.Size = new System.Drawing.Size(738, 150);
            this.dgvCourseList.TabIndex = 11;
            this.dgvCourseList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCourseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCourseList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvCourseList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCourseList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCourseList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCourseList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCourseList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCourseList.ThemeStyle.ReadOnly = false;
            this.dgvCourseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCourseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCourseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCourseList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCourseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnCourse
            // 
            this.btnCourse.AnimationHoverSpeed = 0.07F;
            this.btnCourse.AnimationSpeed = 0.03F;
            this.btnCourse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCourse.BorderColor = System.Drawing.Color.Black;
            this.btnCourse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCourse.FocusedColor = System.Drawing.Color.Empty;
            this.btnCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Image = null;
            this.btnCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCourse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCourse.Location = new System.Drawing.Point(373, 110);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCourse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCourse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCourse.OnHoverImage = null;
            this.btnCourse.OnPressedColor = System.Drawing.Color.Black;
            this.btnCourse.Size = new System.Drawing.Size(160, 42);
            this.btnCourse.TabIndex = 10;
            this.btnCourse.Text = "ADD COURSE";
            this.btnCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDepartmentList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartmentList.AutoGenerateColumns = false;
            this.dgvDepartmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartmentList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDepartmentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartmentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartmentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDepartmentList.ColumnHeadersHeight = 21;
            this.dgvDepartmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn});
            this.dgvDepartmentList.DataSource = this.departmentBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartmentList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDepartmentList.EnableHeadersVisualStyles = false;
            this.dgvDepartmentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.Location = new System.Drawing.Point(207, 170);
            this.dgvDepartmentList.Name = "dgvDepartmentList";
            this.dgvDepartmentList.RowHeadersVisible = false;
            this.dgvDepartmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartmentList.Size = new System.Drawing.Size(738, 150);
            this.dgvDepartmentList.TabIndex = 8;
            this.dgvDepartmentList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDepartmentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDepartmentList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDepartmentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDepartmentList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvDepartmentList.ThemeStyle.ReadOnly = false;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDepartmentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDepartmentList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDepartmentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDepartmentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.AnimationHoverSpeed = 0.07F;
            this.btnAddDepartment.AnimationSpeed = 0.03F;
            this.btnAddDepartment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAddDepartment.BorderColor = System.Drawing.Color.Black;
            this.btnAddDepartment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDepartment.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Image = null;
            this.btnAddDepartment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDepartment.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDepartment.Location = new System.Drawing.Point(207, 110);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddDepartment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDepartment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.OnHoverImage = null;
            this.btnAddDepartment.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDepartment.Size = new System.Drawing.Size(160, 42);
            this.btnAddDepartment.TabIndex = 7;
            this.btnAddDepartment.Text = "ADD DEPARTMENT";
            this.btnAddDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // studentPortalDataSet1
            // 
            this.studentPortalDataSet1.DataSetName = "studentPortalDataSet1";
            this.studentPortalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.studentPortalDataSet1;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "Department_ID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "Department ID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "Department_Name";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(FullScreenAppDemo.db.Department);
            // 
            // RegisSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 788);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisSubject";
            this.Text = "RegisSubject";
            this.Load += new System.EventHandler(this.RegisSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPortalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton CloseBTN;
        private Guna.UI.WinForms.GunaButton MinimizedBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton Subject;
        private Guna.UI.WinForms.GunaButton DeanBTN;
        private Guna.UI.WinForms.GunaButton StudentBTN;
        private Guna.UI.WinForms.GunaButton AcademicsBTN;
        private Guna.UI.WinForms.GunaButton InstructorBTN;
        private Guna.UI.WinForms.GunaButton DashboardBTN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI.WinForms.GunaDataGridView dgvCourseList;
        private Guna.UI.WinForms.GunaButton btnCourse;
        private Guna.UI.WinForms.GunaDataGridView dgvDepartmentList;
        private Guna.UI.WinForms.GunaButton btnAddDepartment;
        private studentPortalDataSet1 studentPortalDataSet1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private studentPortalDataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
    }
}