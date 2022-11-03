
namespace TRABAJO_FINAL
{
    partial class CursosForm
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
            this.InicioDate = new System.Windows.Forms.DateTimePicker();
            this.FinalizacionDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfesorList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MateriaCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InicioDate
            // 
            this.InicioDate.Location = new System.Drawing.Point(455, 109);
            this.InicioDate.Name = "InicioDate";
            this.InicioDate.Size = new System.Drawing.Size(200, 20);
            this.InicioDate.TabIndex = 2;
            // 
            // FinalizacionDate
            // 
            this.FinalizacionDate.Location = new System.Drawing.Point(455, 158);
            this.FinalizacionDate.Name = "FinalizacionDate";
            this.FinalizacionDate.Size = new System.Drawing.Size(200, 20);
            this.FinalizacionDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Materia";
            // 
            // ProfesorList
            // 
            this.ProfesorList.FormattingEnabled = true;
            this.ProfesorList.Location = new System.Drawing.Point(38, 109);
            this.ProfesorList.Name = "ProfesorList";
            this.ProfesorList.Size = new System.Drawing.Size(120, 94);
            this.ProfesorList.TabIndex = 6;
            this.ProfesorList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Finalizacion";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(61, 255);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 9;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(256, 255);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 10;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(439, 255);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 11;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 184);
            this.dataGridView1.TabIndex = 12;
            // 
            // MateriaCombo
            // 
            this.MateriaCombo.FormattingEnabled = true;
            this.MateriaCombo.Location = new System.Drawing.Point(245, 109);
            this.MateriaCombo.Name = "MateriaCombo";
            this.MateriaCombo.Size = new System.Drawing.Size(121, 21);
            this.MateriaCombo.TabIndex = 1;
            // 
            // CursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProfesorList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinalizacionDate);
            this.Controls.Add(this.InicioDate);
            this.Controls.Add(this.MateriaCombo);
            this.Name = "CursosForm";
            this.Text = "CursosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker InicioDate;
        private System.Windows.Forms.DateTimePicker FinalizacionDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ProfesorList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox MateriaCombo;
    }
}