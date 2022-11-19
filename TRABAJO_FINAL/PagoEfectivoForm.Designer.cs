
namespace TRABAJO_FINAL
{
    partial class PagoEfectivoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MontoNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PagarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentoTextBox
            // 
            this.DocumentoTextBox.Location = new System.Drawing.Point(212, 172);
            this.DocumentoTextBox.Name = "DocumentoTextBox";
            this.DocumentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocumentoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // MontoNumber
            // 
            this.MontoNumber.Location = new System.Drawing.Point(425, 173);
            this.MontoNumber.Name = "MontoNumber";
            this.MontoNumber.Size = new System.Drawing.Size(120, 20);
            this.MontoNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto";
            // 
            // PagarButton
            // 
            this.PagarButton.Location = new System.Drawing.Point(334, 291);
            this.PagarButton.Name = "PagarButton";
            this.PagarButton.Size = new System.Drawing.Size(75, 23);
            this.PagarButton.TabIndex = 4;
            this.PagarButton.Text = "Pagar";
            this.PagarButton.UseVisualStyleBackColor = true;
            this.PagarButton.Click += new System.EventHandler(this.PagarButton_Click);
            // 
            // PagoEfectivoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PagarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MontoNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentoTextBox);
            this.Name = "PagoEfectivoForm";
            this.Text = "PagoForm";
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DocumentoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MontoNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PagarButton;
    }
}