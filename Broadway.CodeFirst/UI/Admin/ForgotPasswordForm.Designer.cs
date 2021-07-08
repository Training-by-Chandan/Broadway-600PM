
namespace Broadway.CodeFirst.UI.Admin
{
    partial class ForgotPasswordForm
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
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.ButtonResetSent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextUsername
            // 
            this.TextUsername.Location = new System.Drawing.Point(182, 44);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(218, 20);
            this.TextUsername.TabIndex = 0;
            // 
            // ButtonResetSent
            // 
            this.ButtonResetSent.Location = new System.Drawing.Point(255, 85);
            this.ButtonResetSent.Name = "ButtonResetSent";
            this.ButtonResetSent.Size = new System.Drawing.Size(145, 52);
            this.ButtonResetSent.TabIndex = 1;
            this.ButtonResetSent.Text = "Reset and Set Email";
            this.ButtonResetSent.UseVisualStyleBackColor = true;
            this.ButtonResetSent.Click += new System.EventHandler(this.ButtonResetSent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 10);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonResetSent);
            this.Controls.Add(this.TextUsername);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.Button ButtonResetSent;
        private System.Windows.Forms.Label label1;
    }
}