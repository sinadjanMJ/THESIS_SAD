
namespace FullScreenAppDemo
{
    partial class AccadDH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccadDH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gunaElipsePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaElipsePanel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 733);
            this.panel1.TabIndex = 0;
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(49)))));
            this.gunaElipsePanel4.Controls.Add(this.label15);
            this.gunaElipsePanel4.Controls.Add(this.pictureBox5);
            this.gunaElipsePanel4.Controls.Add(this.label17);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(58, 53);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 20;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(241, 140);
            this.gunaElipsePanel4.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(49)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(13, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 33);
            this.label15.TabIndex = 2;
            this.label15.Text = "5";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(49)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(183, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(124)))), ((int)(((byte)(49)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(14, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Pending";
            // 
            // AccadDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 733);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccadDH";
            this.Text = "AccadDH";
            this.Load += new System.EventHandler(this.AccadDH_Load);
            this.panel1.ResumeLayout(false);
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label17;
    }
}