
namespace TRABAJO_FINAL
{
    partial class FinalForm
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
            this.DocumentoTextBox = new System.Windows.Forms.TextBox();
            this.CursoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InscribirButton = new System.Windows.Forms.Button();
            this.ListarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CursosPorDNIButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentoTextBox
            // 
            this.DocumentoTextBox.Location = new System.Drawing.Point(126, 96);
            this.DocumentoTextBox.Name = "DocumentoTextBox";
            this.DocumentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocumentoTextBox.TabIndex = 0;
            // 
            // CursoComboBox
            // 
            this.CursoComboBox.FormattingEnabled = true;
            this.CursoComboBox.Location = new System.Drawing.Point(433, 94);
            this.CursoComboBox.Name = "CursoComboBox";
            this.CursoComboBox.Size = new System.Drawing.Size(121, 21);
            this.CursoComboBox.TabIndex = 1;
            this.CursoComboBox.SelectedIndexChanged += new System.EventHandler(this.CursoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI de estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cursos para final";
            // 
            // InscribirButton
            // 
            this.InscribirButton.Enabled = false;
            this.InscribirButton.Location = new System.Drawing.Point(129, 251);
            this.InscribirButton.Name = "InscribirButton";
            this.InscribirButton.Size = new System.Drawing.Size(75, 23);
            this.InscribirButton.TabIndex = 4;
            this.InscribirButton.Text = "Inscribir";
            this.InscribirButton.UseVisualStyleBackColor = true;
            this.InscribirButton.Click += new System.EventHandler(this.Inscribir_Click);
            // 
            // ListarButton
            // 
            this.ListarButton.Enabled = false;
            this.ListarButton.Location = new System.Drawing.Point(533, 251);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(75, 23);
            this.ListarButton.TabIndex = 5;
            this.ListarButton.Text = "Listar";
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.ListarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 124);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(322, 251);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // CursosPorDNIButton
            // 
            this.CursosPorDNIButton.Location = new System.Drawing.Point(267, 92);
            this.CursosPorDNIButton.Name = "CursosPorDNIButton";
            this.CursosPorDNIButton.Size = new System.Drawing.Size(98, 23);
            this.CursosPorDNIButton.TabIndex = 10;
            this.CursosPorDNIButton.Text = "Cursos por DNI";
            this.CursosPorDNIButton.UseVisualStyleBackColor = true;
            this.CursosPorDNIButton.Click += new System.EventHandler(this.CursosPorDNIButton_Click);
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CursosPorDNIButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.InscribirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CursoComboBox);
            this.Controls.Add(this.DocumentoTextBox);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DocumentoTextBox;
        private System.Windows.Forms.ComboBox CursoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InscribirButton;
        private System.Windows.Forms.Button ListarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button CursosPorDNIButton;
    }
}