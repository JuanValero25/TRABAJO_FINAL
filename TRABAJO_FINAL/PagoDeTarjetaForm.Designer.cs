
namespace TRABAJO_FINAL
{
    partial class PagoDeTarjetaForm
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
            this.PagoButton = new System.Windows.Forms.Button();
            this.DocumentoTarjeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroTarjeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoDeSeguridad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MontoApagar = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.DniAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreEnTarjetaText = new System.Windows.Forms.TextBox();
            this.FechaDeVencimiento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.MontoApagar)).BeginInit();
            this.SuspendLayout();
            // 
            // PagoButton
            // 
            this.PagoButton.Location = new System.Drawing.Point(316, 326);
            this.PagoButton.Name = "PagoButton";
            this.PagoButton.Size = new System.Drawing.Size(75, 23);
            this.PagoButton.TabIndex = 0;
            this.PagoButton.Text = "Pagar";
            this.PagoButton.UseVisualStyleBackColor = true;
            this.PagoButton.Click += new System.EventHandler(this.PagoButton_Click);
            // 
            // DocumentoTarjeta
            // 
            this.DocumentoTarjeta.Location = new System.Drawing.Point(96, 65);
            this.DocumentoTarjeta.Name = "DocumentoTarjeta";
            this.DocumentoTarjeta.Size = new System.Drawing.Size(100, 20);
            this.DocumentoTarjeta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = " Numero de tarjeta";
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.Location = new System.Drawing.Point(96, 119);
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Size = new System.Drawing.Size(100, 20);
            this.NumeroTarjeta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo de seguridad";
            // 
            // CodigoDeSeguridad
            // 
            this.CodigoDeSeguridad.Location = new System.Drawing.Point(96, 173);
            this.CodigoDeSeguridad.Name = "CodigoDeSeguridad";
            this.CodigoDeSeguridad.Size = new System.Drawing.Size(100, 20);
            this.CodigoDeSeguridad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto a pagar";
            // 
            // MontoApagar
            // 
            this.MontoApagar.Location = new System.Drawing.Point(281, 66);
            this.MontoApagar.Name = "MontoApagar";
            this.MontoApagar.Size = new System.Drawing.Size(120, 20);
            this.MontoApagar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DNI alumno";
            // 
            // DniAlumno
            // 
            this.DniAlumno.Location = new System.Drawing.Point(281, 173);
            this.DniAlumno.Name = "DniAlumno";
            this.DniAlumno.Size = new System.Drawing.Size(100, 20);
            this.DniAlumno.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre de tarjeta";
            // 
            // NombreEnTarjetaText
            // 
            this.NombreEnTarjetaText.Location = new System.Drawing.Point(281, 119);
            this.NombreEnTarjetaText.Name = "NombreEnTarjetaText";
            this.NombreEnTarjetaText.Size = new System.Drawing.Size(100, 20);
            this.NombreEnTarjetaText.TabIndex = 14;
            // 
            // FechaDeVencimiento
            // 
            this.FechaDeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDeVencimiento.Location = new System.Drawing.Point(96, 228);
            this.FechaDeVencimiento.Name = "FechaDeVencimiento";
            this.FechaDeVencimiento.Size = new System.Drawing.Size(200, 20);
            this.FechaDeVencimiento.TabIndex = 16;
            // 
            // PagoDeTarjetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FechaDeVencimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NombreEnTarjetaText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DniAlumno);
            this.Controls.Add(this.MontoApagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodigoDeSeguridad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentoTarjeta);
            this.Controls.Add(this.PagoButton);
            this.Name = "PagoDeTarjetaForm";
            this.Text = "PagoDeTarjetaForm";
            ((System.ComponentModel.ISupportInitialize)(this.MontoApagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PagoButton;
        private System.Windows.Forms.TextBox DocumentoTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumeroTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoDeSeguridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown MontoApagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DniAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreEnTarjetaText;
        private System.Windows.Forms.DateTimePicker FechaDeVencimiento;
    }
}