namespace Contador_clics
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
            this.boton_t = new System.Windows.Forms.Button();
            this.conteo = new System.Windows.Forms.Label();
            this.contador_b = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton_t
            // 
            this.boton_t.Location = new System.Drawing.Point(325, 93);
            this.boton_t.Name = "boton_t";
            this.boton_t.Size = new System.Drawing.Size(102, 32);
            this.boton_t.TabIndex = 0;
            this.boton_t.Text = "Presioname ";
            this.boton_t.UseVisualStyleBackColor = true;
            this.boton_t.Click += new System.EventHandler(this.button1_Click);
            // 
            // conteo
            // 
            this.conteo.AutoSize = true;
            this.conteo.Location = new System.Drawing.Point(353, 150);
            this.conteo.Name = "conteo";
            this.conteo.Size = new System.Drawing.Size(0, 20);
            this.conteo.TabIndex = 1;
            // 
            // contador_b
            // 
            this.contador_b.AutoSize = true;
            this.contador_b.Location = new System.Drawing.Point(353, 150);
            this.contador_b.Name = "contador_b";
            this.contador_b.Size = new System.Drawing.Size(62, 20);
            this.contador_b.TabIndex = 2;
            this.contador_b.Text = "conteo:";
            this.contador_b.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contador_b);
            this.Controls.Add(this.conteo);
            this.Controls.Add(this.boton_t);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_t;
        private System.Windows.Forms.Label conteo;
        private System.Windows.Forms.Label contador_b;
    }
}

