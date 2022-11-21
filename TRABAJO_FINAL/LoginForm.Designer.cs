
namespace TRABAJO_FINAL
{
    partial class LoginForm
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
            this.LogingButton = new System.Windows.Forms.Button();
            this.DniTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TestClientButton = new System.Windows.Forms.Button();
            this.SuperAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogingButton
            // 
            this.LogingButton.Location = new System.Drawing.Point(320, 244);
            this.LogingButton.Name = "LogingButton";
            this.LogingButton.Size = new System.Drawing.Size(75, 23);
            this.LogingButton.TabIndex = 0;
            this.LogingButton.Text = "Loging";
            this.LogingButton.UseVisualStyleBackColor = true;
            this.LogingButton.Click += new System.EventHandler(this.LogingButton_Click);
            // 
            // DniTextBox
            // 
            this.DniTextBox.Location = new System.Drawing.Point(272, 144);
            this.DniTextBox.Name = "DniTextBox";
            this.DniTextBox.Size = new System.Drawing.Size(174, 20);
            this.DniTextBox.TabIndex = 1;
            this.DniTextBox.Text = "999555111";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(272, 189);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(174, 20);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "fancy_password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // TestClientButton
            // 
            this.TestClientButton.Location = new System.Drawing.Point(64, 140);
            this.TestClientButton.Name = "TestClientButton";
            this.TestClientButton.Size = new System.Drawing.Size(75, 23);
            this.TestClientButton.TabIndex = 8;
            this.TestClientButton.Text = "Test Client";
            this.TestClientButton.UseVisualStyleBackColor = true;
            this.TestClientButton.Click += new System.EventHandler(this.TestClientButton_Click);
            // 
            // SuperAdminButton
            // 
            this.SuperAdminButton.Location = new System.Drawing.Point(64, 189);
            this.SuperAdminButton.Name = "SuperAdminButton";
            this.SuperAdminButton.Size = new System.Drawing.Size(75, 23);
            this.SuperAdminButton.TabIndex = 9;
            this.SuperAdminButton.Text = "SuperAdmin";
            this.SuperAdminButton.UseVisualStyleBackColor = true;
            this.SuperAdminButton.Click += new System.EventHandler(this.SuperAdminButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SuperAdminButton);
            this.Controls.Add(this.TestClientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.DniTextBox);
            this.Controls.Add(this.LogingButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogingButton;
        private System.Windows.Forms.TextBox DniTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TestClientButton;
        private System.Windows.Forms.Button SuperAdminButton;
    }
}