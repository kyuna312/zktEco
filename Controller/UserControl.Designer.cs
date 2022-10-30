
namespace OdooZK9500.Controller
{
    partial class UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ip_text = new System.Windows.Forms.TextBox();
            this.user_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(326, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нэвтрэх";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(101, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(101, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(101, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // ip_text
            // 
            this.ip_text.Location = new System.Drawing.Point(455, 227);
            this.ip_text.Multiline = true;
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(418, 31);
            this.ip_text.TabIndex = 4;
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(455, 335);
            this.user_text.Multiline = true;
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(418, 31);
            this.user_text.TabIndex = 5;
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(455, 433);
            this.pass_text.Multiline = true;
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(418, 31);
            this.pass_text.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.login_button.Location = new System.Drawing.Point(326, 550);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(459, 97);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Бүртгүүлэх";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.ip_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1046, 691);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip_text;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Button login_button;
    }
}
