namespace LaunryManager
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.accountName = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassoword = new System.Windows.Forms.Button();
            this.currentPassErr = new System.Windows.Forms.Label();
            this.newPassErr = new System.Windows.Forms.Label();
            this.confirmPassErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change pasword for account";
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.ForeColor = System.Drawing.Color.DarkCyan;
            this.accountName.Location = new System.Drawing.Point(212, 13);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(97, 15);
            this.accountName.TabIndex = 1;
            this.accountName.Text = "account name";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(16, 81);
            this.txtCurrentPassword.MaxLength = 20;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(456, 21);
            this.txtCurrentPassword.TabIndex = 2;
            this.txtCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "New password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(16, 167);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(456, 21);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm new password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(16, 257);
            this.txtConfirmNewPassword.MaxLength = 20;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(456, 21);
            this.txtConfirmNewPassword.TabIndex = 6;
            this.txtConfirmNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmNewPassword_KeyDown);
            // 
            // btnChangePassoword
            // 
            this.btnChangePassoword.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChangePassoword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassoword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassoword.Location = new System.Drawing.Point(16, 324);
            this.btnChangePassoword.Name = "btnChangePassoword";
            this.btnChangePassoword.Size = new System.Drawing.Size(456, 48);
            this.btnChangePassoword.TabIndex = 8;
            this.btnChangePassoword.Text = "Change password";
            this.btnChangePassoword.UseVisualStyleBackColor = false;
            this.btnChangePassoword.Click += new System.EventHandler(this.btnChangePassoword_Click);
            // 
            // currentPassErr
            // 
            this.currentPassErr.AutoSize = true;
            this.currentPassErr.BackColor = System.Drawing.Color.White;
            this.currentPassErr.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.currentPassErr.ForeColor = System.Drawing.Color.Crimson;
            this.currentPassErr.Location = new System.Drawing.Point(453, 51);
            this.currentPassErr.Name = "currentPassErr";
            this.currentPassErr.Size = new System.Drawing.Size(19, 27);
            this.currentPassErr.TabIndex = 9;
            this.currentPassErr.Text = "!";
            this.currentPassErr.Visible = false;
            // 
            // newPassErr
            // 
            this.newPassErr.AutoSize = true;
            this.newPassErr.BackColor = System.Drawing.Color.White;
            this.newPassErr.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.newPassErr.ForeColor = System.Drawing.Color.Crimson;
            this.newPassErr.Location = new System.Drawing.Point(453, 137);
            this.newPassErr.Name = "newPassErr";
            this.newPassErr.Size = new System.Drawing.Size(19, 27);
            this.newPassErr.TabIndex = 10;
            this.newPassErr.Text = "!";
            this.newPassErr.Visible = false;
            // 
            // confirmPassErr
            // 
            this.confirmPassErr.AutoSize = true;
            this.confirmPassErr.BackColor = System.Drawing.Color.White;
            this.confirmPassErr.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.confirmPassErr.ForeColor = System.Drawing.Color.Crimson;
            this.confirmPassErr.Location = new System.Drawing.Point(453, 227);
            this.confirmPassErr.Name = "confirmPassErr";
            this.confirmPassErr.Size = new System.Drawing.Size(19, 27);
            this.confirmPassErr.TabIndex = 11;
            this.confirmPassErr.Text = "!";
            this.confirmPassErr.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.confirmPassErr);
            this.Controls.Add(this.newPassErr);
            this.Controls.Add(this.currentPassErr);
            this.Controls.Add(this.btnChangePassoword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Button btnChangePassoword;
        private System.Windows.Forms.Label currentPassErr;
        private System.Windows.Forms.Label newPassErr;
        private System.Windows.Forms.Label confirmPassErr;
    }
}