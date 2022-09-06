namespace ValidaDigital
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCapturar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.captureLog = new System.Windows.Forms.Label();
            this.pictureFinger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFinger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Location = new System.Drawing.Point(30, 43);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(600, 34);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 282);
            this.textBox1.TabIndex = 1;
            // 
            // captureLog
            // 
            this.captureLog.AutoSize = true;
            this.captureLog.Location = new System.Drawing.Point(27, 407);
            this.captureLog.Name = "captureLog";
            this.captureLog.Size = new System.Drawing.Size(31, 13);
            this.captureLog.TabIndex = 2;
            this.captureLog.Text = "Log: ";
            // 
            // pictureFinger
            // 
            this.pictureFinger.Location = new System.Drawing.Point(399, 105);
            this.pictureFinger.Name = "pictureFinger";
            this.pictureFinger.Size = new System.Drawing.Size(231, 282);
            this.pictureFinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFinger.TabIndex = 3;
            this.pictureFinger.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 446);
            this.Controls.Add(this.pictureFinger);
            this.Controls.Add(this.captureLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCapturar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFinger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label captureLog;
        private System.Windows.Forms.PictureBox pictureFinger;
    }
}

