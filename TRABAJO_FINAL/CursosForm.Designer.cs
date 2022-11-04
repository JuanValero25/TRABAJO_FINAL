
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
            this.ListarTodoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MateriaCombo = new System.Windows.Forms.ComboBox();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.ProfesorList.Size = new System.Drawing.Size(184, 94);
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
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ListarTodoButton
            // 
            this.ListarTodoButton.Location = new System.Drawing.Point(439, 255);
            this.ListarTodoButton.Name = "ListarTodoButton";
            this.ListarTodoButton.Size = new System.Drawing.Size(75, 23);
            this.ListarTodoButton.TabIndex = 11;
            this.ListarTodoButton.Text = "ListarTodo";
            this.ListarTodoButton.UseVisualStyleBackColor = true;
            this.ListarTodoButton.Click += new System.EventHandler(this.ListarTodoButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 184);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MateriaCombo
            // 
            this.MateriaCombo.FormattingEnabled = true;
            this.MateriaCombo.Location = new System.Drawing.Point(245, 109);
            this.MateriaCombo.Name = "MateriaCombo";
            this.MateriaCombo.Size = new System.Drawing.Size(187, 21);
            this.MateriaCombo.TabIndex = 1;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(245, 182);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(187, 20);
            this.NombreTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // CursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NombreTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ListarTodoButton);
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
        private System.Windows.Forms.Button ListarTodoButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox MateriaCombo;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.Label label5;
    }
}