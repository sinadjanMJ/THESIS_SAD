
namespace FullScreenAppDemo
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbSemester = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvAssignment = new Guna.UI.WinForms.GunaDataGridView();
            this.userInWithClassListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_InstructorName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_InstructorID = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.PROCEED = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.userInWithClassListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInWithClassListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInWithClassListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(68, 212);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(89, 21);
            this.gunaLabel2.TabIndex = 21;
            this.gunaLabel2.Text = "SEMESTER";
            // 
            // cbSemester
            // 
            this.cbSemester.BackColor = System.Drawing.Color.Transparent;
            this.cbSemester.BaseColor = System.Drawing.Color.White;
            this.cbSemester.BorderColor = System.Drawing.Color.Silver;
            this.cbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FocusedColor = System.Drawing.Color.Empty;
            this.cbSemester.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSemester.ForeColor = System.Drawing.Color.Black;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.ItemHeight = 30;
            this.cbSemester.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "Summer"});
            this.cbSemester.Location = new System.Drawing.Point(72, 235);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbSemester.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSemester.Radius = 5;
            this.cbSemester.Size = new System.Drawing.Size(239, 36);
            this.cbSemester.TabIndex = 19;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(68, 108);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(168, 21);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "INSTRUCTOR NAME :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(68, 73);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(173, 21);
            this.gunaLabel1.TabIndex = 13;
            this.gunaLabel1.Text = "INSTRUCTOR ID         : ";
            // 
            // dgvAssignment
            // 
            this.dgvAssignment.AllowUserToAddRows = false;
            this.dgvAssignment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAssignment.AutoGenerateColumns = false;
            this.dgvAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAssignment.ColumnHeadersHeight = 21;
            this.dgvAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn,
            this.sEMESTERDataGridViewTextBoxColumn});
            this.dgvAssignment.DataSource = this.userInWithClassListBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAssignment.EnableHeadersVisualStyles = false;
            this.dgvAssignment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignment.Location = new System.Drawing.Point(72, 277);
            this.dgvAssignment.Name = "dgvAssignment";
            this.dgvAssignment.ReadOnly = true;
            this.dgvAssignment.RowHeadersVisible = false;
            this.dgvAssignment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignment.Size = new System.Drawing.Size(617, 246);
            this.dgvAssignment.TabIndex = 17;
            this.dgvAssignment.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAssignment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAssignment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAssignment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAssignment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAssignment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAssignment.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvAssignment.ThemeStyle.ReadOnly = true;
            this.dgvAssignment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAssignment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAssignment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAssignment.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAssignment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAssignment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_InstructorName
            // 
            this.lbl_InstructorName.AutoSize = true;
            this.lbl_InstructorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InstructorName.Location = new System.Drawing.Point(233, 108);
            this.lbl_InstructorName.Name = "lbl_InstructorName";
            this.lbl_InstructorName.Size = new System.Drawing.Size(58, 21);
            this.lbl_InstructorName.TabIndex = 16;
            this.lbl_InstructorName.Text = "NAME";
            // 
            // lbl_InstructorID
            // 
            this.lbl_InstructorID.AutoSize = true;
            this.lbl_InstructorID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InstructorID.Location = new System.Drawing.Point(234, 73);
            this.lbl_InstructorID.Name = "lbl_InstructorID";
            this.lbl_InstructorID.Size = new System.Drawing.Size(27, 21);
            this.lbl_InstructorID.TabIndex = 14;
            this.lbl_InstructorID.Text = "ID";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(757, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(416, 733);
            this.gunaPanel1.TabIndex = 22;
            // 
            // PROCEED
            // 
            this.PROCEED.AnimationHoverSpeed = 0.07F;
            this.PROCEED.AnimationSpeed = 0.03F;
            this.PROCEED.BackColor = System.Drawing.Color.Transparent;
            this.PROCEED.BaseColor = System.Drawing.Color.Maroon;
            this.PROCEED.BorderColor = System.Drawing.Color.Black;
            this.PROCEED.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PROCEED.FocusedColor = System.Drawing.Color.Empty;
            this.PROCEED.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROCEED.ForeColor = System.Drawing.Color.Gold;
            this.PROCEED.Image = null;
            this.PROCEED.ImageSize = new System.Drawing.Size(20, 20);
            this.PROCEED.Location = new System.Drawing.Point(341, 229);
            this.PROCEED.Name = "PROCEED";
            this.PROCEED.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PROCEED.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PROCEED.OnHoverForeColor = System.Drawing.Color.White;
            this.PROCEED.OnHoverImage = null;
            this.PROCEED.OnPressedColor = System.Drawing.Color.Black;
            this.PROCEED.Radius = 5;
            this.PROCEED.Size = new System.Drawing.Size(160, 42);
            this.PROCEED.TabIndex = 68;
            this.PROCEED.Text = "FILTER";
            this.PROCEED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gunaButton1.Location = new System.Drawing.Point(529, 540);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 69;
            this.gunaButton1.Text = "SEND TO PENDING";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Gold;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(529, 229);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 5;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 70;
            this.gunaButton2.Text = "REFRESH";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userInWithClassListBindingSource1
            // 
            this.userInWithClassListBindingSource1.DataSource = typeof(FullScreenAppDemo.perips.userInWithClassList);
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "a_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "a_ID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "Class_name";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "Class_name";
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            this.classnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "yearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "yearLevel";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            this.yearLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEMESTERDataGridViewTextBoxColumn
            // 
            this.sEMESTERDataGridViewTextBoxColumn.DataPropertyName = "SEMESTER";
            this.sEMESTERDataGridViewTextBoxColumn.HeaderText = "SEMESTER";
            this.sEMESTERDataGridViewTextBoxColumn.Name = "sEMESTERDataGridViewTextBoxColumn";
            this.sEMESTERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 733);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.PROCEED);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.lbl_InstructorName);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lbl_InstructorID);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dgvAssignment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Class";
            this.Text = "Class";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInWithClassListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInWithClassListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userInWithClassListBindingSource;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbSemester;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvAssignment;
        private Guna.UI.WinForms.GunaLabel lbl_InstructorName;
        private Guna.UI.WinForms.GunaLabel lbl_InstructorID;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton PROCEED;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMESTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userInWithClassListBindingSource1;
    }
}