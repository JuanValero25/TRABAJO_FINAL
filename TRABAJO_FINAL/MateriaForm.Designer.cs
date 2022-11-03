
namespace TRABAJO_FINAL
{
    partial class MateriaForm
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
            this.NombreText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ListarButon = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrecioNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(54, 94);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(100, 20);
            this.NombreText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // CodigoText
            // 
            this.CodigoText.Location = new System.Drawing.Point(230, 94);
            this.CodigoText.Name = "CodigoText";
            this.CodigoText.Size = new System.Drawing.Size(100, 20);
            this.CodigoText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(54, 168);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 6;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ListarButon
            // 
            this.ListarButon.Location = new System.Drawing.Point(398, 168);
            this.ListarButon.Name = "ListarButon";
            this.ListarButon.Size = new System.Drawing.Size(75, 23);
            this.ListarButon.TabIndex = 7;
            this.ListarButon.Text = "ListarTodo";
            this.ListarButon.UseVisualStyleBackColor = true;
            this.ListarButon.Click += new System.EventHandler(this.ListarButon_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(233, 168);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 8;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 153);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PrecioNumber
            // 
            this.PrecioNumber.Location = new System.Drawing.Point(398, 95);
            this.PrecioNumber.Name = "PrecioNumber";
            this.PrecioNumber.Size = new System.Drawing.Size(120, 20);
            this.PrecioNumber.TabIndex = 10;
            // 
            // MateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrecioNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ListarButon);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreText);
            this.Name = "MateriaForm";
            this.Text = "Materia";
            this.Load += new System.EventHandler(this.MateriaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button ListarButon;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown PrecioNumber;
    }
}