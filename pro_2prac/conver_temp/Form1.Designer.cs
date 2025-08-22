namespace conver_temp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnFtoC = new System.Windows.Forms.RadioButton();
            this.rbtnCtoF = new System.Windows.Forms.RadioButton();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnFtoC
            // 
            this.rbtnFtoC.AutoSize = true;
            this.rbtnFtoC.Location = new System.Drawing.Point(139, 95);
            this.rbtnFtoC.Name = "rbtnFtoC";
            this.rbtnFtoC.Size = new System.Drawing.Size(120, 24);
            this.rbtnFtoC.TabIndex = 0;
            this.rbtnFtoC.TabStop = true;
            this.rbtnFtoC.Text = "Con_celsius";
            this.rbtnFtoC.UseVisualStyleBackColor = true;
            this.rbtnFtoC.CheckedChanged += new System.EventHandler(this.rbtnFtoC_CheckedChanged);
            // 
            // rbtnCtoF
            // 
            this.rbtnCtoF.AutoSize = true;
            this.rbtnCtoF.Location = new System.Drawing.Point(140, 164);
            this.rbtnCtoF.Name = "rbtnCtoF";
            this.rbtnCtoF.Size = new System.Drawing.Size(141, 24);
            this.rbtnCtoF.TabIndex = 1;
            this.rbtnCtoF.TabStop = true;
            this.rbtnCtoF.Text = "con_fahrenheit";
            this.rbtnCtoF.UseVisualStyleBackColor = true;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(335, 130);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 26);
            this.txtTemperatura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escoja la conversion a realizar e ingrese la temperatura";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvertir.Location = new System.Drawing.Point(335, 210);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(117, 25);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(505, 215);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.rbtnCtoF);
            this.Controls.Add(this.rbtnFtoC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFtoC;
        private System.Windows.Forms.RadioButton rbtnCtoF;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}

