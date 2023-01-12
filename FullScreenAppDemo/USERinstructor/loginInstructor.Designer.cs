
namespace FullScreenAppDemo
{
    partial class loginInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginInstructor));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_InstructorID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckbxShowPas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseBTN = new Guna.UI.WinForms.GunaButton();
            this.MinimizedBTN = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(216, 28);
            this.textBox1.TabIndex = 35;
            // 
            // txt_InstructorID
            // 
            this.txt_InstructorID.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_InstructorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_InstructorID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InstructorID.Location = new System.Drawing.Point(39, 142);
            this.txt_InstructorID.Multiline = true;
            this.txt_InstructorID.Name = "txt_InstructorID";
            this.txt_InstructorID.Size = new System.Drawing.Size(216, 28);
            this.txt_InstructorID.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(39, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckbxShowPas
            // 
            this.CheckbxShowPas.AutoSize = true;
            this.CheckbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbxShowPas.ForeColor = System.Drawing.Color.DimGray;
            this.CheckbxShowPas.Location = new System.Drawing.Point(136, 240);
            this.CheckbxShowPas.Name = "CheckbxShowPas";
            this.CheckbxShowPas.Size = new System.Drawing.Size(119, 21);
            this.CheckbxShowPas.TabIndex = 29;
            this.CheckbxShowPas.Text = "Show Password";
            this.CheckbxShowPas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(36, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Get Started";
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
            this.CloseBTN.Location = new System.Drawing.Point(254, 4);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.OnHoverBaseColor = System.Drawing.Color.Red;
            this.CloseBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseBTN.OnHoverImage = null;
            this.CloseBTN.OnPressedColor = System.Drawing.Color.Black;
            this.CloseBTN.Size = new System.Drawing.Size(30, 30);
            this.CloseBTN.TabIndex = 47;
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
            this.MinimizedBTN.Location = new System.Drawing.Point(218, 4);
            this.MinimizedBTN.Name = "MinimizedBTN";
            this.MinimizedBTN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(170)))), ((int)(((byte)(231)))));
            this.MinimizedBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MinimizedBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.MinimizedBTN.OnHoverImage = null;
            this.MinimizedBTN.OnPressedColor = System.Drawing.Color.Black;
            this.MinimizedBTN.Size = new System.Drawing.Size(30, 30);
            this.MinimizedBTN.TabIndex = 46;
            this.MinimizedBTN.Click += new System.EventHandler(this.MinimizedBTN_Click);
            // 
            // loginInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.MinimizedBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_InstructorID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckbxShowPas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginInstructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_InstructorID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckbxShowPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton CloseBTN;
        private Guna.UI.WinForms.GunaButton MinimizedBTN;
    }
}