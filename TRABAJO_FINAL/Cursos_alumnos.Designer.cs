
namespace TRABAJO_FINAL
{
    partial class Cursos_alumnos
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
            this.CursoCombo = new System.Windows.Forms.ComboBox();
            this.NombreMateriaText = new System.Windows.Forms.TextBox();
            this.FechaDeInicioText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuposDisponiblesNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CuposDisponiblesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoCombo
            // 
            this.CursoCombo.FormattingEnabled = true;
            this.CursoCombo.Location = new System.Drawing.Point(54, 94);
            this.CursoCombo.Name = "CursoCombo";
            this.CursoCombo.Size = new System.Drawing.Size(121, 21);
            this.CursoCombo.TabIndex = 0;
            // 
            // NombreMateriaText
            // 
            this.NombreMateriaText.Location = new System.Drawing.Point(263, 94);
            this.NombreMateriaText.Name = "NombreMateriaText";
            this.NombreMateriaText.ReadOnly = true;
            this.NombreMateriaText.Size = new System.Drawing.Size(100, 20);
            this.NombreMateriaText.TabIndex = 1;
            // 
            // FechaDeInicioText
            // 
            this.FechaDeInicioText.Location = new System.Drawing.Point(452, 94);
            this.FechaDeInicioText.Name = "FechaDeInicioText";
            this.FechaDeInicioText.ReadOnly = true;
            this.FechaDeInicioText.Size = new System.Drawing.Size(170, 20);
            this.FechaDeInicioText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha De Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de Materia";
            // 
            // CuposDisponiblesNumber
            // 
            this.CuposDisponiblesNumber.Location = new System.Drawing.Point(455, 147);
            this.CuposDisponiblesNumber.Name = "CuposDisponiblesNumber";
            this.CuposDisponiblesNumber.ReadOnly = true;
            this.CuposDisponiblesNumber.Size = new System.Drawing.Size(167, 20);
            this.CuposDisponiblesNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cupos Disponibles";
            // 
            // PrecioNumber
            // 
            this.PrecioNumber.Location = new System.Drawing.Point(452, 198);
            this.PrecioNumber.Name = "PrecioNumber";
            this.PrecioNumber.ReadOnly = true;
            this.PrecioNumber.Size = new System.Drawing.Size(170, 20);
            this.PrecioNumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cursos_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecioNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CuposDisponiblesNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaDeInicioText);
            this.Controls.Add(this.NombreMateriaText);
            this.Controls.Add(this.CursoCombo);
            this.Name = "Cursos_alumnos";
            this.Text = "Cursos_alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.CuposDisponiblesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CursoCombo;
        private System.Windows.Forms.TextBox NombreMateriaText;
        private System.Windows.Forms.TextBox FechaDeInicioText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CuposDisponiblesNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PrecioNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}