
namespace TRABAJO_FINAL
{
    partial class SubirNotasForm
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
            this.DniProfesorText = new System.Windows.Forms.TextBox();
            this.CursoCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NotaAlumno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MateriaCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreAlumnoText = new System.Windows.Forms.TextBox();
            this.DniALumnoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GuardarNotasButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // DniProfesorText
            // 
            this.DniProfesorText.Location = new System.Drawing.Point(88, 87);
            this.DniProfesorText.Name = "DniProfesorText";
            this.DniProfesorText.Size = new System.Drawing.Size(100, 20);
            this.DniProfesorText.TabIndex = 0;
            this.DniProfesorText.TextChanged += new System.EventHandler(this.DniProfesorText_TextChanged);
            // 
            // CursoCombo
            // 
            this.CursoCombo.FormattingEnabled = true;
            this.CursoCombo.Location = new System.Drawing.Point(427, 87);
            this.CursoCombo.Name = "CursoCombo";
            this.CursoCombo.Size = new System.Drawing.Size(121, 21);
            this.CursoCombo.TabIndex = 1;
            this.CursoCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NotaAlumno
            // 
            this.NotaAlumno.Location = new System.Drawing.Point(88, 202);
            this.NotaAlumno.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NotaAlumno.Name = "NotaAlumno";
            this.NotaAlumno.Size = new System.Drawing.Size(120, 20);
            this.NotaAlumno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profesor DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Curso";
            // 
            // MateriaCombo
            // 
            this.MateriaCombo.FormattingEnabled = true;
            this.MateriaCombo.Location = new System.Drawing.Point(234, 86);
            this.MateriaCombo.Name = "MateriaCombo";
            this.MateriaCombo.Size = new System.Drawing.Size(121, 21);
            this.MateriaCombo.TabIndex = 7;
            this.MateriaCombo.SelectedIndexChanged += new System.EventHandler(this.MateriaCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Materias";
            // 
            // NombreAlumnoText
            // 
            this.NombreAlumnoText.Location = new System.Drawing.Point(282, 201);
            this.NombreAlumnoText.Name = "NombreAlumnoText";
            this.NombreAlumnoText.ReadOnly = true;
            this.NombreAlumnoText.Size = new System.Drawing.Size(100, 20);
            this.NombreAlumnoText.TabIndex = 9;
            // 
            // DniALumnoText
            // 
            this.DniALumnoText.Location = new System.Drawing.Point(415, 201);
            this.DniALumnoText.Name = "DniALumnoText";
            this.DniALumnoText.ReadOnly = true;
            this.DniALumnoText.Size = new System.Drawing.Size(100, 20);
            this.DniALumnoText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre de alumno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DNI";
            // 
            // GuardarNotasButton
            // 
            this.GuardarNotasButton.Enabled = false;
            this.GuardarNotasButton.Location = new System.Drawing.Point(285, 250);
            this.GuardarNotasButton.Name = "GuardarNotasButton";
            this.GuardarNotasButton.Size = new System.Drawing.Size(107, 23);
            this.GuardarNotasButton.TabIndex = 13;
            this.GuardarNotasButton.Text = "Guardar Nota";
            this.GuardarNotasButton.UseVisualStyleBackColor = true;
            this.GuardarNotasButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubirNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuardarNotasButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DniALumnoText);
            this.Controls.Add(this.NombreAlumnoText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MateriaCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotaAlumno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CursoCombo);
            this.Controls.Add(this.DniProfesorText);
            this.Name = "SubirNotasForm";
            this.Text = "SubirNotasForm";
            this.Load += new System.EventHandler(this.SubirNotasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotaAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DniProfesorText;
        private System.Windows.Forms.ComboBox CursoCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown NotaAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MateriaCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreAlumnoText;
        private System.Windows.Forms.TextBox DniALumnoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarNotasButton;
    }
}