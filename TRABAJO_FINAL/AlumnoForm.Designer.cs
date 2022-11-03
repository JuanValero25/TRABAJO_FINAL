
namespace TRABAJO_FINAL
{
    partial class AlumnoForm
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
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DNITextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EstadoTextBox = new System.Windows.Forms.ComboBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListarTodo = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(61, 73);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(129, 20);
            this.NombreTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(61, 131);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(129, 20);
            this.ApellidoTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // DNITextBox
            // 
            this.DNITextBox.Location = new System.Drawing.Point(61, 187);
            this.DNITextBox.Name = "DNITextBox";
            this.DNITextBox.Size = new System.Drawing.Size(129, 20);
            this.DNITextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(268, 73);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(129, 20);
            this.TelefonoTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado";
            // 
            // EstadoTextBox
            // 
            this.EstadoTextBox.FormattingEnabled = true;
            this.EstadoTextBox.Items.AddRange(new object[] {
            "AL_DIA",
            "MORATORIA",
            "DESHABILITADO"});
            this.EstadoTextBox.Location = new System.Drawing.Point(268, 186);
            this.EstadoTextBox.Name = "EstadoTextBox";
            this.EstadoTextBox.Size = new System.Drawing.Size(129, 21);
            this.EstadoTextBox.TabIndex = 10;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(61, 235);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 11;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(190, 235);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 152);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListarTodo
            // 
            this.ListarTodo.Location = new System.Drawing.Point(322, 235);
            this.ListarTodo.Name = "ListarTodo";
            this.ListarTodo.Size = new System.Drawing.Size(75, 23);
            this.ListarTodo.TabIndex = 15;
            this.ListarTodo.Text = "ListarTodo";
            this.ListarTodo.UseVisualStyleBackColor = true;
            this.ListarTodo.Click += new System.EventHandler(this.ListarTodo_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(268, 131);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(129, 20);
            this.EmailTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 482);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ListarTodo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.EstadoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DNITextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "AlumnoForm";
            this.Text = "AlumnoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DNITextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EstadoTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ListarTodo;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label6;
    }
}