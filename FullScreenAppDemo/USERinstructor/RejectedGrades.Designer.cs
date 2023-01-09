
namespace FullScreenAppDemo
{
    partial class RejectedGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RejectedGrades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PROCEED = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDeanFeedback = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dgvRejected = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMESTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInWithClassListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInWithClassListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PROCEED);
            this.panel1.Controls.Add(this.gunaCirclePictureBox2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblDeanFeedback);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.dgvRejected);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 726);
            this.panel1.TabIndex = 0;
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
            this.PROCEED.Location = new System.Drawing.Point(780, 471);
            this.PROCEED.Name = "PROCEED";
            this.PROCEED.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.PROCEED.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PROCEED.OnHoverForeColor = System.Drawing.Color.White;
            this.PROCEED.OnHoverImage = null;
            this.PROCEED.OnPressedColor = System.Drawing.Color.Black;
            this.PROCEED.Radius = 5;
            this.PROCEED.Size = new System.Drawing.Size(174, 42);
            this.PROCEED.TabIndex = 75;
            this.PROCEED.Text = "SEND TO PENDING";
            this.PROCEED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PROCEED.Click += new System.EventHandler(this.PROCEED_Click);
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(193, 134);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(92, 91);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 74;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(291, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(519, 46);
            this.label16.TabIndex = 73;
            this.label16.Text = "Rejected Grades Data Form";
            // 
            // lblDeanFeedback
            // 
            this.lblDeanFeedback.AutoSize = true;
            this.lblDeanFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeanFeedback.Location = new System.Drawing.Point(359, 471);
            this.lblDeanFeedback.Name = "lblDeanFeedback";
            this.lblDeanFeedback.Size = new System.Drawing.Size(28, 21);
            this.lblDeanFeedback.TabIndex = 22;
            this.lblDeanFeedback.Text = "---";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(189, 471);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(164, 21);
            this.gunaLabel5.TabIndex = 20;
            this.gunaLabel5.Text = "DEAN\'S FEEDBACK : ";
            // 
            // dgvRejected
            // 
            this.dgvRejected.AllowUserToAddRows = false;
            this.dgvRejected.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRejected.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRejected.AutoGenerateColumns = false;
            this.dgvRejected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRejected.BackgroundColor = System.Drawing.Color.White;
            this.dgvRejected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRejected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRejected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRejected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRejected.ColumnHeadersHeight = 21;
            this.dgvRejected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIDDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn,
            this.subjectIDDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn,
            this.sEMESTERDataGridViewTextBoxColumn});
            this.dgvRejected.DataSource = this.userInWithClassListBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRejected.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRejected.EnableHeadersVisualStyles = false;
            this.dgvRejected.GridColor = System.Drawing.Color.Gray;
            this.dgvRejected.Location = new System.Drawing.Point(193, 312);
            this.dgvRejected.Name = "dgvRejected";
            this.dgvRejected.ReadOnly = true;
            this.dgvRejected.RowHeadersVisible = false;
            this.dgvRejected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRejected.Size = new System.Drawing.Size(761, 150);
            this.dgvRejected.TabIndex = 19;
            this.dgvRejected.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvRejected.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRejected.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRejected.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRejected.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRejected.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRejected.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRejected.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvRejected.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvRejected.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRejected.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRejected.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvRejected.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRejected.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvRejected.ThemeStyle.ReadOnly = true;
            this.dgvRejected.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRejected.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRejected.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRejected.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRejected.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRejected.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRejected.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRejected.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRejected_CellClick);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(186, 272);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(143, 37);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "REJECTED";
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
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            this.subjectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
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
            // userInWithClassListBindingSource
            // 
            this.userInWithClassListBindingSource.DataSource = typeof(FullScreenAppDemo.perips.userInWithClassList);
            // 
            // RejectedGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 733);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RejectedGrades";
            this.Text = "RejectedGrades";
            this.Load += new System.EventHandler(this.RejectedGrades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInWithClassListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblDeanFeedback;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDataGridView dgvRejected;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMESTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userInWithClassListBindingSource;
        private Guna.UI.WinForms.GunaButton PROCEED;
    }
}