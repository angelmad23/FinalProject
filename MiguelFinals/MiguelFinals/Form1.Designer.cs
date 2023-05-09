namespace MiguelFinals
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login1 = new MiguelFinals.Login();
            this.register1 = new MiguelFinals.Register();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(56, 131);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(56, 264);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log in";
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(206, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(545, 472);
            this.login1.TabIndex = 2;
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(193, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(820, 566);
            this.register1.TabIndex = 3;
            this.register1.Load += new System.EventHandler(this.register1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private Login login1;
        private Register register1;
    }
}

