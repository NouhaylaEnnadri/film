namespace film
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.log_in_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(58, 204);
            this.email.Name = "email";
            this.email.PlaceholderText = "Email";
            this.email.Size = new System.Drawing.Size(305, 31);
            this.email.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(58, 264);
            this.password.Name = "password";
            this.password.PlaceholderText = "password";
            this.password.Size = new System.Drawing.Size(305, 31);
            this.password.TabIndex = 2;
            // 
            // log_in_btn
            // 
            this.log_in_btn.Location = new System.Drawing.Point(146, 342);
            this.log_in_btn.Name = "log_in_btn";
            this.log_in_btn.Size = new System.Drawing.Size(112, 34);
            this.log_in_btn.TabIndex = 3;
            this.log_in_btn.Text = "LOG IN";
            this.log_in_btn.UseVisualStyleBackColor = true;
            this.log_in_btn.Click += new System.EventHandler(this.log_in_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 429);
            this.Controls.Add(this.log_in_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox email;
        private TextBox password;
        private Button log_in_btn;
    }
}