
namespace FullScreenAppDemo
{
    partial class DEANSTUDENTGRADE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEANSTUDENTGRADE));
            this.uipanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudentLoad = new Guna.UI.WinForms.GunaDataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLoadwithInstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblInstructorFeedback = new Guna.UI.WinForms.GunaLabel();
            this.textDeanFeedback = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblSubject = new Guna.UI.WinForms.GunaLabel();
            this.lblInstructor = new Guna.UI.WinForms.GunaLabel();
            this.lblClass = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.uipanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLoadwithInstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uipanel
            // 
            this.uipanel.Controls.Add(this.btnRefresh);
            this.uipanel.Controls.Add(this.panel1);
            this.uipanel.Controls.Add(this.gunaCirclePictureBox2);
            this.uipanel.Controls.Add(this.label16);
            this.uipanel.Controls.Add(this.lblInstructorFeedback);
            this.uipanel.Controls.Add(this.textDeanFeedback);
            this.uipanel.Controls.Add(this.gunaButton2);
            this.uipanel.Controls.Add(this.gunaButton1);
            this.uipanel.Controls.Add(this.gunaLabel4);
            this.uipanel.Controls.Add(this.lblSubject);
            this.uipanel.Controls.Add(this.lblInstructor);
            this.uipanel.Controls.Add(this.lblClass);
            this.uipanel.Controls.Add(this.gunaLabel3);
            this.uipanel.Controls.Add(this.gunaLabel2);
            this.uipanel.Controls.Add(this.gunaLabel1);
            this.uipanel.Controls.Add(this.gunaPictureBox1);
            this.uipanel.Location = new System.Drawing.Point(0, 0);
            this.uipanel.Name = "uipanel";
            this.uipanel.Size = new System.Drawing.Size(1176, 733);
            this.uipanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.Maroon;
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gold;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(200, 538);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Radius = 5;
            this.btnRefresh.Size = new System.Drawing.Size(123, 39);
            this.btnRefresh.TabIndex = 92;
            this.btnRefresh.Text = "BACK";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStudentLoad);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(187, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 211);
            this.panel1.TabIndex = 91;
            // 
            // dgvStudentLoad
            // 
            this.dgvStudentLoad.AllowUserToAddRows = false;
            this.dgvStudentLoad.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentLoad.AutoGenerateColumns = false;
            this.dgvStudentLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentLoad.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentLoad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudentLoad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentLoad.ColumnHeadersHeight = 21;
            this.dgvStudentLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.schoolIDDataGridViewTextBoxColumn,
            this.sTUDENTDataGridViewTextBoxColumn,
            this.gRADEDataGridViewTextBoxColumn});
            this.dgvStudentLoad.DataSource = this.studentLoadwithInstBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentLoad.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentLoad.EnableHeadersVisualStyles = false;
            this.dgvStudentLoad.GridColor = System.Drawing.Color.Gray;
            this.dgvStudentLoad.Location = new System.Drawing.Point(13, 3);
            this.dgvStudentLoad.Name = "dgvStudentLoad";
            this.dgvStudentLoad.ReadOnly = true;
            this.dgvStudentLoad.RowHeadersVisible = false;
            this.dgvStudentLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentLoad.Size = new System.Drawing.Size(776, 198);
            this.dgvStudentLoad.TabIndex = 83;
            this.dgvStudentLoad.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudentLoad.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvStudentLoad.ThemeStyle.ReadOnly = true;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentLoad.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudentLoad.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentLoad.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudentLoad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentLoad_CellClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "STUDENT ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolIDDataGridViewTextBoxColumn
            // 
            this.schoolIDDataGridViewTextBoxColumn.DataPropertyName = "schoolID";
            this.schoolIDDataGridViewTextBoxColumn.HeaderText = "SCHOOL ID";
            this.schoolIDDataGridViewTextBoxColumn.Name = "schoolIDDataGridViewTextBoxColumn";
            this.schoolIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDENTDataGridViewTextBoxColumn
            // 
            this.sTUDENTDataGridViewTextBoxColumn.DataPropertyName = "STUDENT";
            this.sTUDENTDataGridViewTextBoxColumn.HeaderText = "STUDENT";
            this.sTUDENTDataGridViewTextBoxColumn.Name = "sTUDENTDataGridViewTextBoxColumn";
            this.sTUDENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gRADEDataGridViewTextBoxColumn
            // 
            this.gRADEDataGridViewTextBoxColumn.DataPropertyName = "GRADE";
            this.gRADEDataGridViewTextBoxColumn.HeaderText = "GRADE";
            this.gRADEDataGridViewTextBoxColumn.Name = "gRADEDataGridViewTextBoxColumn";
            this.gRADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentLoadwithInstBindingSource
            // 
            this.studentLoadwithInstBindingSource.DataSource = typeof(FullScreenAppDemo.perips.studentLoadwithInst);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(155, 28);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 90;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(244, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(511, 46);
            this.label16.TabIndex = 89;
            this.label16.Text = "Check The Pending Grades";
            // 
            // lblInstructorFeedback
            // 
            this.lblInstructorFeedback.AutoSize = true;
            this.lblInstructorFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorFeedback.Location = new System.Drawing.Point(371, 237);
            this.lblInstructorFeedback.Name = "lblInstructorFeedback";
            this.lblInstructorFeedback.Size = new System.Drawing.Size(23, 17);
            this.lblInstructorFeedback.TabIndex = 88;
            this.lblInstructorFeedback.Text = "---";
            // 
            // textDeanFeedback
            // 
            this.textDeanFeedback.BaseColor = System.Drawing.Color.White;
            this.textDeanFeedback.BorderColor = System.Drawing.Color.Silver;
            this.textDeanFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDeanFeedback.FocusedBaseColor = System.Drawing.Color.White;
            this.textDeanFeedback.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textDeanFeedback.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textDeanFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDeanFeedback.Location = new System.Drawing.Point(200, 471);
            this.textDeanFeedback.Multiline = true;
            this.textDeanFeedback.Name = "textDeanFeedback";
            this.textDeanFeedback.PasswordChar = '\0';
            this.textDeanFeedback.SelectedText = "";
            this.textDeanFeedback.Size = new System.Drawing.Size(776, 58);
            this.textDeanFeedback.TabIndex = 86;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Gold;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(816, 535);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 85;
            this.gunaButton2.Text = "REJECT";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
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
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Gold;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(650, 535);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 84;
            this.gunaButton1.Text = "ACCEPT";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(197, 237);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(168, 17);
            this.gunaLabel4.TabIndex = 87;
            this.gunaLabel4.Text = "INSTRUCTOR FEEDBACK : ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(694, 144);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(37, 30);
            this.lblSubject.TabIndex = 82;
            this.lblSubject.Text = "---";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(341, 176);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(37, 30);
            this.lblInstructor.TabIndex = 81;
            this.lblInstructor.Text = "---";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(341, 145);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(37, 30);
            this.lblClass.TabIndex = 80;
            this.lblClass.Text = "---";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(583, 149);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(105, 25);
            this.gunaLabel3.TabIndex = 79;
            this.gunaLabel3.Text = "SUBJECT : ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(195, 180);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(139, 25);
            this.gunaLabel2.TabIndex = 78;
            this.gunaLabel2.Text = "INSTRUCTOR :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(195, 149);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 25);
            this.gunaLabel1.TabIndex = 77;
            this.gunaLabel1.Text = "CLASS NAME :";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(795, -34);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(381, 416);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 93;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DEANSTUDENTGRADE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 673);
            this.Controls.Add(this.uipanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DEANSTUDENTGRADE";
            this.Text = "DEANSTUDENTGRADE";
            this.Load += new System.EventHandler(this.DEANSTUDENTGRADE_Load);
            this.uipanel.ResumeLayout(false);
            this.uipanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLoadwithInstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uipanel;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaLabel lblInstructorFeedback;
        private Guna.UI.WinForms.GunaTextBox textDeanFeedback;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDataGridView dgvStudentLoad;
        private Guna.UI.WinForms.GunaLabel lblSubject;
        private Guna.UI.WinForms.GunaLabel lblInstructor;
        private Guna.UI.WinForms.GunaLabel lblClass;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentLoadwithInstBindingSource;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}