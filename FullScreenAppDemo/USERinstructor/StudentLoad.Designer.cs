
namespace FullScreenAppDemo
{
    partial class StudentLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoad));
            this.uipanel = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.PROCEED = new Guna.UI.WinForms.GunaButton();
            this.lblSubject = new Guna.UI.WinForms.GunaLabel();
            this.lblClass = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvStudentLoad = new Guna.UI.WinForms.GunaDataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLoadwithInstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.uipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLoadwithInstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uipanel
            // 
            this.uipanel.BackColor = System.Drawing.SystemColors.Control;
            this.uipanel.Controls.Add(this.gunaCirclePictureBox2);
            this.uipanel.Controls.Add(this.label16);
            this.uipanel.Controls.Add(this.gunaButton1);
            this.uipanel.Controls.Add(this.PROCEED);
            this.uipanel.Controls.Add(this.lblSubject);
            this.uipanel.Controls.Add(this.lblClass);
            this.uipanel.Controls.Add(this.gunaLabel3);
            this.uipanel.Controls.Add(this.gunaLabel1);
            this.uipanel.Controls.Add(this.dgvStudentLoad);
            this.uipanel.Location = new System.Drawing.Point(2, 1);
            this.uipanel.Name = "uipanel";
            this.uipanel.Size = new System.Drawing.Size(1161, 727);
            this.uipanel.TabIndex = 71;
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
            this.gunaButton1.Location = new System.Drawing.Point(591, 275);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 79;
            this.gunaButton1.Text = "BACK";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.PROCEED.Location = new System.Drawing.Point(85, 275);
            this.PROCEED.Name = "PROCEED";
            this.PROCEED.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PROCEED.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PROCEED.OnHoverForeColor = System.Drawing.Color.White;
            this.PROCEED.OnHoverImage = null;
            this.PROCEED.OnPressedColor = System.Drawing.Color.Black;
            this.PROCEED.Radius = 5;
            this.PROCEED.Size = new System.Drawing.Size(160, 42);
            this.PROCEED.TabIndex = 78;
            this.PROCEED.Text = "MAKE CHANGES";
            this.PROCEED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PROCEED.Click += new System.EventHandler(this.PROCEED_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(447, 204);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(23, 17);
            this.lblSubject.TabIndex = 77;
            this.lblSubject.Text = "---";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(184, 204);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(23, 17);
            this.lblClass.TabIndex = 75;
            this.lblClass.Text = "---";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(368, 204);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(73, 17);
            this.gunaLabel3.TabIndex = 74;
            this.gunaLabel3.Text = "SUBJECT : ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(82, 204);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 17);
            this.gunaLabel1.TabIndex = 72;
            this.gunaLabel1.Text = "CLASS NAME :";
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentLoad.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentLoad.EnableHeadersVisualStyles = false;
            this.dgvStudentLoad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentLoad.Location = new System.Drawing.Point(85, 323);
            this.dgvStudentLoad.Name = "dgvStudentLoad";
            this.dgvStudentLoad.ReadOnly = true;
            this.dgvStudentLoad.RowHeadersVisible = false;
            this.dgvStudentLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentLoad.Size = new System.Drawing.Size(666, 198);
            this.dgvStudentLoad.TabIndex = 71;
            this.dgvStudentLoad.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudentLoad.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudentLoad.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudentLoad.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvStudentLoad.ThemeStyle.ReadOnly = true;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvStudentLoad.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudentLoad.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStudentLoad.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentLoad.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolIDDataGridViewTextBoxColumn
            // 
            this.schoolIDDataGridViewTextBoxColumn.DataPropertyName = "schoolID";
            this.schoolIDDataGridViewTextBoxColumn.HeaderText = "schoolID";
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
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(85, 81);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 81;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(183, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(330, 46);
            this.label16.TabIndex = 80;
            this.label16.Text = " Class Data Form";
            // 
            // StudentLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 728);
            this.Controls.Add(this.uipanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentLoad";
            this.Load += new System.EventHandler(this.StudentLoad_Load);
            this.uipanel.ResumeLayout(false);
            this.uipanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLoadwithInstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource studentLoadwithInstBindingSource;
        private System.Windows.Forms.Panel uipanel;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton PROCEED;
        private Guna.UI.WinForms.GunaLabel lblSubject;
        private Guna.UI.WinForms.GunaLabel lblClass;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dgvStudentLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADEDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label16;
    }
}