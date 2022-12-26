namespace FullScreenAppDemo
{
    partial class RegisAcademics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisAcademics));
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.DashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.ErrorImage = null;
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(419, 68);
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
            this.label4.Location = new System.Drawing.Point(517, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Academics Data Form";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.gunaCirclePictureBox2);
            this.DashboardPanel.Controls.Add(this.label4);
            this.DashboardPanel.Location = new System.Drawing.Point(3, 4);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1175, 683);
            this.DashboardPanel.TabIndex = 11;
            // 
            // RegisAcademics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 736);
            this.Controls.Add(this.DashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisAcademics";
            this.Text = "RegisAcademis";
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel DashboardPanel;
    }
}