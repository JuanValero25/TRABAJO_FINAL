
namespace TRABAJO_FINAL
{
    partial class PermisosForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.AgregarRole = new System.Windows.Forms.Button();
            this.RoleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(90, 70);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(430, 279);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar Permisos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarRole
            // 
            this.AgregarRole.Location = new System.Drawing.Point(599, 138);
            this.AgregarRole.Name = "AgregarRole";
            this.AgregarRole.Size = new System.Drawing.Size(75, 23);
            this.AgregarRole.TabIndex = 2;
            this.AgregarRole.Text = "Agregar";
            this.AgregarRole.UseVisualStyleBackColor = true;
            this.AgregarRole.Click += new System.EventHandler(this.AgregarRole_Click);
            // 
            // RoleName
            // 
            this.RoleName.Location = new System.Drawing.Point(544, 93);
            this.RoleName.Name = "RoleName";
            this.RoleName.Size = new System.Drawing.Size(197, 20);
            this.RoleName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Role";
            // 
            // PermisosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleName);
            this.Controls.Add(this.AgregarRole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "PermisosForm";
            this.Text = "Permisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AgregarRole;
        private System.Windows.Forms.TextBox RoleName;
        private System.Windows.Forms.Label label1;
    }
}