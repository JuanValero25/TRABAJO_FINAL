
namespace TRABAJO_FINAL
{
    partial class InscripcionForm
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
            this.InscribirSeButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BurcarPorDNIButton = new System.Windows.Forms.Button();
            this.DniTextBox = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CuposDisponiblesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CursoCombo
            // 
            this.CursoCombo.FormattingEnabled = true;
            this.CursoCombo.Location = new System.Drawing.Point(54, 94);
            this.CursoCombo.Name = "CursoCombo";
            this.CursoCombo.Size = new System.Drawing.Size(121, 21);
            this.CursoCombo.TabIndex = 0;
            this.CursoCombo.SelectedIndexChanged += new System.EventHandler(this.CursoCombo_SelectedIndexChanged);
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
            this.FechaDeInicioText.TextChanged += new System.EventHandler(this.FechaDeInicioText_TextChanged);
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
            this.CuposDisponiblesNumber.ValueChanged += new System.EventHandler(this.CuposDisponiblesNumber_ValueChanged);
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
            // InscribirSeButton
            // 
            this.InscribirSeButton.Enabled = false;
            this.InscribirSeButton.Location = new System.Drawing.Point(57, 268);
            this.InscribirSeButton.Name = "InscribirSeButton";
            this.InscribirSeButton.Size = new System.Drawing.Size(75, 23);
            this.InscribirSeButton.TabIndex = 12;
            this.InscribirSeButton.Text = "Inscribirse";
            this.InscribirSeButton.UseVisualStyleBackColor = true;
            this.InscribirSeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(209, 267);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BurcarPorDNIButton
            // 
            this.BurcarPorDNIButton.Enabled = false;
            this.BurcarPorDNIButton.Location = new System.Drawing.Point(386, 267);
            this.BurcarPorDNIButton.Name = "BurcarPorDNIButton";
            this.BurcarPorDNIButton.Size = new System.Drawing.Size(109, 23);
            this.BurcarPorDNIButton.TabIndex = 14;
            this.BurcarPorDNIButton.Text = "Buscar Por DNI";
            this.BurcarPorDNIButton.UseVisualStyleBackColor = true;
            this.BurcarPorDNIButton.Click += new System.EventHandler(this.BurcarPorDNIButton_Click);
            // 
            // DniTextBox
            // 
            this.DniTextBox.Location = new System.Drawing.Point(54, 146);
            this.DniTextBox.Name = "DniTextBox";
            this.DniTextBox.Size = new System.Drawing.Size(121, 20);
            this.DniTextBox.TabIndex = 15;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(54, 128);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 16;
            this.DNI.Text = "DNI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 240);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.DniTextBox);
            this.Controls.Add(this.BurcarPorDNIButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.InscribirSeButton);
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
            this.Name = "InscripcionForm";
            this.Text = "Inscripcion form";
            ((System.ComponentModel.ISupportInitialize)(this.CuposDisponiblesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button InscribirSeButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BurcarPorDNIButton;
        private System.Windows.Forms.TextBox DniTextBox;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}