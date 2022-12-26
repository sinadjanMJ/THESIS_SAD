namespace FullScreenAppDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisDean));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.dgvDeanList = new Guna.UI.WinForms.GunaDataGridView();
            this.deanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deanWithDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddDean = new Guna.UI.WinForms.GunaButton();
            this.studentPortalDataSet = new FullScreenAppDemo.studentPortalDataSet();
            this.deanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deanTableAdapter = new FullScreenAppDemo.studentPortalDataSetTableAdapters.DeanTableAdapter();
            this.regisDeanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeanList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanWithDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPortalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisDeanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(217, 32);
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
            this.label4.Location = new System.Drawing.Point(315, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dean Data Form";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.dgvDeanList);
            this.DashboardPanel.Controls.Add(this.btnAddDean);
            this.DashboardPanel.Controls.Add(this.gunaCirclePictureBox2);
            this.DashboardPanel.Controls.Add(this.label4);
            this.DashboardPanel.Location = new System.Drawing.Point(2, 2);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1175, 733);
            this.DashboardPanel.TabIndex = 11;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeanList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeanList.EnableHeadersVisualStyles = false;
            this.dgvDeanList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeanList.Location = new System.Drawing.Point(218, 296);
            this.dgvDeanList.Name = "dgvDeanList";
            this.dgvDeanList.RowHeadersVisible = false;
            this.dgvDeanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeanList.Size = new System.Drawing.Size(738, 239);
            this.dgvDeanList.TabIndex = 11;
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
            this.dgvDeanList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeanList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gold;
            this.dgvDeanList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDeanList.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvDeanList.ThemeStyle.ReadOnly = false;
            this.dgvDeanList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDeanList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeanList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDeanList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDeanList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDeanList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDeanList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnAddDean.Location = new System.Drawing.Point(218, 237);
            this.btnAddDean.Name = "btnAddDean";
            this.btnAddDean.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.btnAddDean.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDean.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDean.OnHoverImage = null;
            this.btnAddDean.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDean.Radius = 5;
            this.btnAddDean.Size = new System.Drawing.Size(160, 42);
            this.btnAddDean.TabIndex = 10;
            this.btnAddDean.Text = "ADD DEAN";
            this.btnAddDean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDean.Click += new System.EventHandler(this.btnAddDean_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeanList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanWithDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPortalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regisDeanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel DashboardPanel;
        private Guna.UI.WinForms.GunaDataGridView dgvDeanList;
        private Guna.UI.WinForms.GunaButton btnAddDean;
        private System.Windows.Forms.BindingSource regisDeanBindingSource;
        private studentPortalDataSet studentPortalDataSet;
        private System.Windows.Forms.BindingSource deanBindingSource;
        private studentPortalDataSetTableAdapters.DeanTableAdapter deanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deanWithDepartmentBindingSource;
    }
}