
namespace TRABAJO_FINAL
{
    partial class PagosForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PagoConTarjeta = new System.Windows.Forms.Button();
            this.PagoEfectivoButton = new System.Windows.Forms.Button();
            this.DocumentoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListarButton = new System.Windows.Forms.Button();
            this.ListarCuotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Provider";
            // 
            // PagoConTarjeta
            // 
            this.PagoConTarjeta.Enabled = false;
            this.PagoConTarjeta.Location = new System.Drawing.Point(320, 91);
            this.PagoConTarjeta.Name = "PagoConTarjeta";
            this.PagoConTarjeta.Size = new System.Drawing.Size(99, 23);
            this.PagoConTarjeta.TabIndex = 6;
            this.PagoConTarjeta.Text = "Pago Con Tarjeta";
            this.PagoConTarjeta.UseVisualStyleBackColor = true;
            this.PagoConTarjeta.Click += new System.EventHandler(this.PagoConTarjeta_Click);
            // 
            // PagoEfectivoButton
            // 
            this.PagoEfectivoButton.Enabled = false;
            this.PagoEfectivoButton.Location = new System.Drawing.Point(320, 133);
            this.PagoEfectivoButton.Name = "PagoEfectivoButton";
            this.PagoEfectivoButton.Size = new System.Drawing.Size(99, 23);
            this.PagoEfectivoButton.TabIndex = 7;
            this.PagoEfectivoButton.Text = "Pago Efectivo";
            this.PagoEfectivoButton.UseVisualStyleBackColor = true;
            this.PagoEfectivoButton.Click += new System.EventHandler(this.PagoEfectivoButton_Click);
            // 
            // DocumentoTextBox
            // 
            this.DocumentoTextBox.Location = new System.Drawing.Point(86, 135);
            this.DocumentoTextBox.Name = "DocumentoTextBox";
            this.DocumentoTextBox.Size = new System.Drawing.Size(130, 20);
            this.DocumentoTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI/DOCUMENTO";
            // 
            // ListarButton
            // 
            this.ListarButton.Location = new System.Drawing.Point(86, 184);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(130, 20);
            this.ListarButton.TabIndex = 11;
            this.ListarButton.Text = "Listar pagos por DNI";
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListarCuotas
            // 
            this.ListarCuotas.Location = new System.Drawing.Point(271, 184);
            this.ListarCuotas.Name = "ListarCuotas";
            this.ListarCuotas.Size = new System.Drawing.Size(110, 23);
            this.ListarCuotas.TabIndex = 12;
            this.ListarCuotas.Text = "Listar Cuotas";
            this.ListarCuotas.UseVisualStyleBackColor = true;
            this.ListarCuotas.Click += new System.EventHandler(this.ListarCuotas_Click);
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListarCuotas);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocumentoTextBox);
            this.Controls.Add(this.PagoEfectivoButton);
            this.Controls.Add(this.PagoConTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PagosForm";
            this.Text = "PagosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PagoConTarjeta;
        private System.Windows.Forms.Button PagoEfectivoButton;
        private System.Windows.Forms.TextBox DocumentoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ListarButton;
        private System.Windows.Forms.Button ListarCuotas;
    }
}