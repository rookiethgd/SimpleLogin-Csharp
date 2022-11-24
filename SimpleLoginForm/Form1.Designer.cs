namespace SimpleLoginForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.mainPNL = new Guna.UI2.WinForms.Guna2Panel();
            this.mainDRAG = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.usernameTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mainPNL.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPNL
            // 
            this.mainPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.mainPNL.Controls.Add(this.guna2ImageButton6);
            this.mainPNL.Controls.Add(this.guna2ImageButton5);
            this.mainPNL.Controls.Add(this.guna2Panel1);
            this.mainPNL.Controls.Add(this.label1);
            this.mainPNL.Location = new System.Drawing.Point(1, 1);
            this.mainPNL.Name = "mainPNL";
            this.mainPNL.Size = new System.Drawing.Size(780, 569);
            this.mainPNL.TabIndex = 0;
            // 
            // mainDRAG
            // 
            this.mainDRAG.DockIndicatorTransparencyValue = 0.6D;
            this.mainDRAG.TargetControl = this.mainPNL;
            this.mainDRAG.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.passwordTXT);
            this.guna2Panel1.Controls.Add(this.usernameTXT);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(72, 135);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(634, 307);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(150)))));
            this.guna2Button1.Location = new System.Drawing.Point(53, 185);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(531, 40);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Sign in";
            // 
            // usernameTXT
            // 
            this.usernameTXT.Animated = true;
            this.usernameTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.usernameTXT.BorderRadius = 5;
            this.usernameTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTXT.DefaultText = "";
            this.usernameTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTXT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.usernameTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTXT.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.usernameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.usernameTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.usernameTXT.Location = new System.Drawing.Point(53, 90);
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.PasswordChar = '\0';
            this.usernameTXT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.usernameTXT.PlaceholderText = "Username";
            this.usernameTXT.SelectedText = "";
            this.usernameTXT.Size = new System.Drawing.Size(531, 40);
            this.usernameTXT.TabIndex = 1;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Animated = true;
            this.passwordTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(20)))));
            this.passwordTXT.BorderRadius = 5;
            this.passwordTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTXT.DefaultText = "";
            this.passwordTXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTXT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.passwordTXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTXT.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F);
            this.passwordTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.passwordTXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(171)))));
            this.passwordTXT.Location = new System.Drawing.Point(53, 135);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '\0';
            this.passwordTXT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.passwordTXT.PlaceholderText = "Password";
            this.passwordTXT.SelectedText = "";
            this.passwordTXT.Size = new System.Drawing.Size(531, 40);
            this.passwordTXT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simple - Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lorem Ipsum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(50, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dont have an account?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(245)))));
            this.label5.Location = new System.Drawing.Point(198, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sign up";
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton6.Image")));
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton6.Location = new System.Drawing.Point(724, 6);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton6.Size = new System.Drawing.Size(22, 25);
            this.guna2ImageButton6.TabIndex = 8;
            this.guna2ImageButton6.Click += new System.EventHandler(this.guna2ImageButton6_Click);
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton5.Image")));
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton5.Location = new System.Drawing.Point(749, 6);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton5.Size = new System.Drawing.Size(22, 25);
            this.guna2ImageButton5.TabIndex = 7;
            this.guna2ImageButton5.Click += new System.EventHandler(this.guna2ImageButton5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(782, 571);
            this.Controls.Add(this.mainPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.mainPNL.ResumeLayout(false);
            this.mainPNL.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPNL;
        private Guna.UI2.WinForms.Guna2DragControl mainDRAG;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox passwordTXT;
        private Guna.UI2.WinForms.Guna2TextBox usernameTXT;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
    }
}

