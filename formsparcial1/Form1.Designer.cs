namespace formsparcial1
{
    partial class btnarea
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtradio = new System.Windows.Forms.TextBox();
            this.texradio = new System.Windows.Forms.Label();
            this.texaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(200, 20);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(100, 23);
            this.txtradio.TabIndex = 0;
            // 
            // texradio
            // 
            this.texradio.AutoSize = true;
            this.texradio.Location = new System.Drawing.Point(90, 20);
            this.texradio.Name = "texradio";
            this.texradio.Size = new System.Drawing.Size(79, 15);
            this.texradio.TabIndex = 1;
            this.texradio.Text = "ingresar radio";
            // 
            // texaltura
            // 
            this.texaltura.AutoSize = true;
            this.texaltura.Location = new System.Drawing.Point(87, 79);
            this.texaltura.Name = "texaltura";
            this.texaltura.Size = new System.Drawing.Size(82, 15);
            this.texaltura.TabIndex = 5;
            this.texaltura.Text = "ingresar altura";
            this.texaltura.Click += new System.EventHandler(this.texaltura_Click);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(200, 79);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 23);
            this.txtaltura.TabIndex = 4;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(366, 20);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 42);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(366, 78);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 7;
            this.cancelar.Text = "cancela";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // btnarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.texaltura);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.texradio);
            this.Controls.Add(this.txtradio);
            this.Name = "btnarea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtradio;
        private Label texradio;
        private Label texaltura;
        private TextBox txtaltura;
        private Button calcular;
        private Button cancelar;
    }
}