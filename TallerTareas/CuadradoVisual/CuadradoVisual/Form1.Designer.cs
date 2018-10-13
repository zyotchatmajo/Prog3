namespace CuadradoVisual
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtBot = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Perimetro = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CuadradoVisual.Properties.Resources.P_Cuadrado;
            this.pictureBox1.Location = new System.Drawing.Point(270, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(467, 165);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(23, 20);
            this.txtRight.TabIndex = 1;
            // 
            // txtBot
            // 
            this.txtBot.BackColor = System.Drawing.SystemColors.Window;
            this.txtBot.Location = new System.Drawing.Point(376, 248);
            this.txtBot.Name = "txtBot";
            this.txtBot.Size = new System.Drawing.Size(26, 20);
            this.txtBot.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(341, 340);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Perimetro
            // 
            this.Perimetro.AutoSize = true;
            this.Perimetro.Location = new System.Drawing.Point(267, 309);
            this.Perimetro.Name = "Perimetro";
            this.Perimetro.Size = new System.Drawing.Size(51, 13);
            this.Perimetro.TabIndex = 6;
            this.Perimetro.Text = "Perimetro";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(418, 309);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(29, 13);
            this.Area.TabIndex = 7;
            this.Area.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Perimetro);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBot);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtBot;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label Perimetro;
        private System.Windows.Forms.Label Area;
    }
}

