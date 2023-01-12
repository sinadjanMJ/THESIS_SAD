
namespace FullScreenAppDemo
{
    partial class uDeanRejectedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uDeanRejectedForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_Feedback = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtFeedback = new Guna.UI.WinForms.GunaTextBox();
            this.btnBackToInstructor = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClassLoadList = new Guna.UI.WinForms.GunaDataGridView();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAcademicClassListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassLoadList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAcademicClassListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaCirclePictureBox2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbl_Feedback);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txtFeedback);
            this.panel1.Controls.Add(this.btnBackToInstructor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 733);
            this.panel1.TabIndex = 0;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(185, 183);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 78;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(283, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(252, 46);
            this.label16.TabIndex = 77;
            this.label16.Text = "Rejected List";
            // 
            // lbl_Feedback
            // 
            this.lbl_Feedback.AutoSize = true;
            this.lbl_Feedback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feedback.Location = new System.Drawing.Point(439, 304);
            this.lbl_Feedback.Name = "lbl_Feedback";
            this.lbl_Feedback.Size = new System.Drawing.Size(23, 17);
            this.lbl_Feedback.TabIndex = 24;
            this.lbl_Feedback.Text = "---";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(231, 306);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(202, 17);
            this.gunaLabel2.TabIndex = 23;
            this.gunaLabel2.Text = "ACADEMIC OFFICE FEEDBACK : ";
            // 
            // txtFeedback
            // 
            this.txtFeedback.BaseColor = System.Drawing.Color.White;
            this.txtFeedback.BorderColor = System.Drawing.Color.Silver;
            this.txtFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeedback.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFeedback.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFeedback.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFeedback.Location = new System.Drawing.Point(231, 493);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.PasswordChar = '\0';
            this.txtFeedback.SelectedText = "";
            this.txtFeedback.Size = new System.Drawing.Size(504, 42);
            this.txtFeedback.TabIndex = 22;
            // 
            // btnBackToInstructor
            // 
            this.btnBackToInstructor.AnimationHoverSpeed = 0.07F;
            this.btnBackToInstructor.AnimationSpeed = 0.03F;
            this.btnBackToInstructor.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToInstructor.BaseColor = System.Drawing.Color.Maroon;
            this.btnBackToInstructor.BorderColor = System.Drawing.Color.Black;
            this.btnBackToInstructor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackToInstructor.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackToInstructor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToInstructor.ForeColor = System.Drawing.Color.Gold;
            this.btnBackToInstructor.Image = null;
            this.btnBackToInstructor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBackToInstructor.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackToInstructor.Location = new System.Drawing.Point(741, 493);
            this.btnBackToInstructor.Name = "btnBackToInstructor";
            this.btnBackToInstructor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnBackToInstructor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackToInstructor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackToInstructor.OnHoverImage = null;
            this.btnBackToInstructor.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackToInstructor.Radius = 5;
            this.btnBackToInstructor.Size = new System.Drawing.Size(210, 42);
            this.btnBackToInstructor.TabIndex = 21;
            this.btnBackToInstructor.Text = "SEND BACK TO INSTRUCTOR";
            this.btnBackToInstructor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackToInstructor.Click += new System.EventHandler(this.btnBackToInstructor_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClassLoadList);
            this.panel2.Location = new System.Drawing.Point(231, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 163);
            this.panel2.TabIndex = 0;
            // 
            // dgvClassLoadList
            // 
            this.dgvClassLoadList.AllowUserToAddRows = false;
            this.dgvClassLoadList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvClassLoadList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClassLoadList.AutoGenerateColumns = false;
            this.dgvClassLoadList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassLoadList.BackgroundColor = System.Drawing.Color.White;
            this.dgvClassLoadList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClassLoadList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClassLoadList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassLoadList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClassLoadList.ColumnHeadersHeight = 21;
            this.dgvClassLoadList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.instructorIDDataGridViewTextBoxColumn,
            this.instructorDataGridViewTextBoxColumn,
            this.sEMESTERDataGridViewTextBoxColumn});
            this.dgvClassLoadList.DataSource = this.uAcademicClassListBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassLoadList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClassLoadList.EnableHeadersVisualStyles = false;
            this.dgvClassLoadList.GridColor = System.Drawing.Color.Gray;
            this.dgvClassLoadList.Location = new System.Drawing.Point(3, 3);
            this.dgvClassLoadList.Name = "dgvClassLoadList";
            this.dgvClassLoadList.ReadOnly = true;
            this.dgvClassLoadList.RowHeadersVisible = false;
            this.dgvClassLoadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassLoadList.Size = new System.Drawing.Size(717, 150);
            this.dgvClassLoadList.TabIndex = 20;
            this.dgvClassLoadList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvClassLoadList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClassLoadList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClassLoadList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClassLoadList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClassLoadList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClassLoadList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClassLoadList.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvClassLoadList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvClassLoadList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClassLoadList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClassLoadList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvClassLoadList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClassLoadList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvClassLoadList.ThemeStyle.ReadOnly = true;
            this.dgvClassLoadList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClassLoadList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClassLoadList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClassLoadList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClassLoadList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClassLoadList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClassLoadList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClassLoadList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassLoadList_CellClick);
            this.dgvClassLoadList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassLoadList_CellDoubleClick);
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "a_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "a_ID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            this.aIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SUBJECT ID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "SUBJECT";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instructorIDDataGridViewTextBoxColumn
            // 
            this.instructorIDDataGridViewTextBoxColumn.DataPropertyName = "instructorID";
            this.instructorIDDataGridViewTextBoxColumn.HeaderText = "INSTRUCTOR ID";
            this.instructorIDDataGridViewTextBoxColumn.Name = "instructorIDDataGridViewTextBoxColumn";
            this.instructorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instructorDataGridViewTextBoxColumn
            // 
            this.instructorDataGridViewTextBoxColumn.DataPropertyName = "instructor";
            this.instructorDataGridViewTextBoxColumn.HeaderText = "INSTRUCTOR";
            this.instructorDataGridViewTextBoxColumn.Name = "instructorDataGridViewTextBoxColumn";
            this.instructorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEMESTERDataGridViewTextBoxColumn
            // 
            this.sEMESTERDataGridViewTextBoxColumn.DataPropertyName = "SEMESTER";
            this.sEMESTERDataGridViewTextBoxColumn.HeaderText = "SEMESTER";
            this.sEMESTERDataGridViewTextBoxColumn.Name = "sEMESTERDataGridViewTextBoxColumn";
            this.sEMESTERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uAcademicClassListBindingSource
            // 
            this.uAcademicClassListBindingSource.DataSource = typeof(FullScreenAppDemo.perips.uAcademicClassList);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(636, -25);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(536, 473);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 85;
            this.gunaPictureBox1.TabStop = false;
            // 
            // uDeanRejectedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 733);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uDeanRejectedForm";
            this.Text = "uDeanRejectedForm";
            this.Load += new System.EventHandler(this.uDeanRejectedForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassLoadList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uAcademicClassListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lbl_Feedback;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtFeedback;
        private Guna.UI.WinForms.GunaButton btnBackToInstructor;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView dgvClassLoadList;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource uAcademicClassListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMESTERDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}