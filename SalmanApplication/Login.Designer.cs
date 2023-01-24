namespace SalmanApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.image = new System.Windows.Forms.Panel();
            this.unamelabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.unametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.LinkLabel();
            this.heading = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image.BackgroundImage")));
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(3, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(474, 278);
            this.image.TabIndex = 1;
            // 
            // unamelabel
            // 
            this.unamelabel.AutoSize = true;
            this.unamelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamelabel.Location = new System.Drawing.Point(44, 371);
            this.unamelabel.Name = "unamelabel";
            this.unamelabel.Size = new System.Drawing.Size(98, 25);
            this.unamelabel.TabIndex = 2;
            this.unamelabel.Text = "Username";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(51, 421);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(91, 25);
            this.passlabel.TabIndex = 3;
            this.passlabel.Text = "Password";
            // 
            // unametxt
            // 
            this.unametxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unametxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametxt.Location = new System.Drawing.Point(161, 363);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(298, 33);
            this.unametxt.TabIndex = 4;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passtxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(161, 418);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(298, 33);
            this.passtxt.TabIndex = 5;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.GhostWhite;
            this.loginBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(279, 476);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(180, 40);
            this.loginBTN.TabIndex = 6;
            this.loginBTN.Text = "LOGIN";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(334, 535);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(125, 21);
            this.signup.TabIndex = 7;
            this.signup.TabStop = true;
            this.signup.Text = "Create Account !";
            this.signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_LinkClicked);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(153, 297);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(116, 45);
            this.heading.TabIndex = 8;
            this.heading.Text = "LOGIN";
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.Location = new System.Drawing.Point(109, 581);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(262, 13);
            this.footer.TabIndex = 53;
            this.footer.Text = "Database Application Created by Muhammad Salman";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 603);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.unametxt);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.unamelabel);
            this.Controls.Add(this.image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel image;
        private System.Windows.Forms.Label unamelabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox unametxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label footer;
    }
}