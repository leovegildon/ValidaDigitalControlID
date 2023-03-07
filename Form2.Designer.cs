namespace ValidaDigital
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblComSemDigital = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificarDigital = new System.Windows.Forms.Button();
            this.pictureDigital = new System.Windows.Forms.PictureBox();
            this.btnIncluirDigital = new System.Windows.Forms.Button();
            this.btnCapturarDigital = new System.Windows.Forms.Button();
            this.captureLog = new System.Windows.Forms.Label();
            this.timerCapturar = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teclado_01 = new System.Windows.Forms.Button();
            this.teclado_02 = new System.Windows.Forms.Button();
            this.teclado_03 = new System.Windows.Forms.Button();
            this.teclado_06 = new System.Windows.Forms.Button();
            this.teclado_05 = new System.Windows.Forms.Button();
            this.teclado_04 = new System.Windows.Forms.Button();
            this.teclado_09 = new System.Windows.Forms.Button();
            this.teclado_08 = new System.Windows.Forms.Button();
            this.teclado_07 = new System.Windows.Forms.Button();
            this.teclado_00 = new System.Windows.Forms.Button();
            this.teclado_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDigital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(635, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(67, 59);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Enter";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(128, 38);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(233, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomeUsuario.Location = new System.Drawing.Point(7, 66);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(60, 20);
            this.lblNomeUsuario.TabIndex = 5;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lblNomeUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Location = new System.Drawing.Point(10, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de acesso ao Próton";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(237, 38);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnModificarDigital);
            this.groupBox2.Controls.Add(this.pictureDigital);
            this.groupBox2.Controls.Add(this.btnIncluirDigital);
            this.groupBox2.Location = new System.Drawing.Point(10, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 314);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funções";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.lblComSemDigital);
            this.panel2.Location = new System.Drawing.Point(195, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 36);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblComSemDigital
            // 
            this.lblComSemDigital.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComSemDigital.AutoSize = true;
            this.lblComSemDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComSemDigital.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComSemDigital.Location = new System.Drawing.Point(38, 5);
            this.lblComSemDigital.Name = "lblComSemDigital";
            this.lblComSemDigital.Size = new System.Drawing.Size(171, 20);
            this.lblComSemDigital.TabIndex = 12;
            this.lblComSemDigital.Text = "Usuário COM Digital";
            this.lblComSemDigital.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Location = new System.Drawing.Point(195, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 46);
            this.panel1.TabIndex = 13;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMensagem.Location = new System.Drawing.Point(6, 11);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(225, 20);
            this.lblMensagem.TabIndex = 12;
            this.lblMensagem.Text = "Posicione o Dedo no Leitor";
            this.lblMensagem.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(11, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificarDigital
            // 
            this.btnModificarDigital.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificarDigital.Enabled = false;
            this.btnModificarDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDigital.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificarDigital.Location = new System.Drawing.Point(11, 146);
            this.btnModificarDigital.Name = "btnModificarDigital";
            this.btnModificarDigital.Size = new System.Drawing.Size(155, 107);
            this.btnModificarDigital.TabIndex = 9;
            this.btnModificarDigital.Text = "Modificar Digital";
            this.btnModificarDigital.UseVisualStyleBackColor = false;
            this.btnModificarDigital.Click += new System.EventHandler(this.btnModificarDigital_Click);
            // 
            // pictureDigital
            // 
            this.pictureDigital.Location = new System.Drawing.Point(257, 107);
            this.pictureDigital.Name = "pictureDigital";
            this.pictureDigital.Size = new System.Drawing.Size(127, 146);
            this.pictureDigital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDigital.TabIndex = 8;
            this.pictureDigital.TabStop = false;
            // 
            // btnIncluirDigital
            // 
            this.btnIncluirDigital.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnIncluirDigital.Enabled = false;
            this.btnIncluirDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirDigital.ForeColor = System.Drawing.Color.Transparent;
            this.btnIncluirDigital.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirDigital.Location = new System.Drawing.Point(11, 25);
            this.btnIncluirDigital.Name = "btnIncluirDigital";
            this.btnIncluirDigital.Size = new System.Drawing.Size(155, 106);
            this.btnIncluirDigital.TabIndex = 8;
            this.btnIncluirDigital.Text = "Incluir Digital";
            this.btnIncluirDigital.UseVisualStyleBackColor = false;
            this.btnIncluirDigital.Click += new System.EventHandler(this.btnIncluirDigital_Click);
            // 
            // btnCapturarDigital
            // 
            this.btnCapturarDigital.Enabled = false;
            this.btnCapturarDigital.Location = new System.Drawing.Point(665, 477);
            this.btnCapturarDigital.Name = "btnCapturarDigital";
            this.btnCapturarDigital.Size = new System.Drawing.Size(45, 44);
            this.btnCapturarDigital.TabIndex = 10;
            this.btnCapturarDigital.Text = "Capturar Digital";
            this.btnCapturarDigital.UseVisualStyleBackColor = true;
            this.btnCapturarDigital.Visible = false;
            this.btnCapturarDigital.Click += new System.EventHandler(this.btnCapturarDigital_Click);
            // 
            // captureLog
            // 
            this.captureLog.AutoSize = true;
            this.captureLog.Location = new System.Drawing.Point(7, 532);
            this.captureLog.Name = "captureLog";
            this.captureLog.Size = new System.Drawing.Size(31, 13);
            this.captureLog.TabIndex = 12;
            this.captureLog.Text = "Log: ";
            // 
            // timerCapturar
            // 
            this.timerCapturar.Tick += new System.EventHandler(this.timerCapturar_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ValidaDigital.Properties.Resources._22318;
            this.pictureBox1.Location = new System.Drawing.Point(205, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // teclado_01
            // 
            this.teclado_01.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_01.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_01.Location = new System.Drawing.Point(489, 115);
            this.teclado_01.Name = "teclado_01";
            this.teclado_01.Size = new System.Drawing.Size(67, 59);
            this.teclado_01.TabIndex = 14;
            this.teclado_01.Text = "1";
            this.teclado_01.UseVisualStyleBackColor = false;
            this.teclado_01.Click += new System.EventHandler(this.teclado_01_Click);
            // 
            // teclado_02
            // 
            this.teclado_02.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_02.Location = new System.Drawing.Point(562, 116);
            this.teclado_02.Name = "teclado_02";
            this.teclado_02.Size = new System.Drawing.Size(67, 59);
            this.teclado_02.TabIndex = 15;
            this.teclado_02.Text = "2";
            this.teclado_02.UseVisualStyleBackColor = false;
            this.teclado_02.Click += new System.EventHandler(this.teclado_02_Click);
            // 
            // teclado_03
            // 
            this.teclado_03.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_03.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_03.Location = new System.Drawing.Point(635, 116);
            this.teclado_03.Name = "teclado_03";
            this.teclado_03.Size = new System.Drawing.Size(67, 59);
            this.teclado_03.TabIndex = 16;
            this.teclado_03.Text = "3";
            this.teclado_03.UseVisualStyleBackColor = false;
            this.teclado_03.Click += new System.EventHandler(this.teclado_03_Click);
            // 
            // teclado_06
            // 
            this.teclado_06.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_06.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_06.Location = new System.Drawing.Point(635, 181);
            this.teclado_06.Name = "teclado_06";
            this.teclado_06.Size = new System.Drawing.Size(67, 59);
            this.teclado_06.TabIndex = 19;
            this.teclado_06.Text = "6";
            this.teclado_06.UseVisualStyleBackColor = false;
            this.teclado_06.Click += new System.EventHandler(this.teclado_06_Click);
            // 
            // teclado_05
            // 
            this.teclado_05.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_05.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_05.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_05.Location = new System.Drawing.Point(562, 181);
            this.teclado_05.Name = "teclado_05";
            this.teclado_05.Size = new System.Drawing.Size(67, 59);
            this.teclado_05.TabIndex = 18;
            this.teclado_05.Text = "5";
            this.teclado_05.UseVisualStyleBackColor = false;
            this.teclado_05.Click += new System.EventHandler(this.teclado_05_Click);
            // 
            // teclado_04
            // 
            this.teclado_04.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_04.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_04.Location = new System.Drawing.Point(489, 180);
            this.teclado_04.Name = "teclado_04";
            this.teclado_04.Size = new System.Drawing.Size(67, 59);
            this.teclado_04.TabIndex = 17;
            this.teclado_04.Text = "4";
            this.teclado_04.UseVisualStyleBackColor = false;
            this.teclado_04.Click += new System.EventHandler(this.teclado_04_Click);
            // 
            // teclado_09
            // 
            this.teclado_09.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_09.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_09.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_09.Location = new System.Drawing.Point(635, 246);
            this.teclado_09.Name = "teclado_09";
            this.teclado_09.Size = new System.Drawing.Size(67, 59);
            this.teclado_09.TabIndex = 22;
            this.teclado_09.Text = "9";
            this.teclado_09.UseVisualStyleBackColor = false;
            this.teclado_09.Click += new System.EventHandler(this.teclado_09_Click);
            // 
            // teclado_08
            // 
            this.teclado_08.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_08.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_08.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_08.Location = new System.Drawing.Point(562, 246);
            this.teclado_08.Name = "teclado_08";
            this.teclado_08.Size = new System.Drawing.Size(67, 59);
            this.teclado_08.TabIndex = 21;
            this.teclado_08.Text = "8";
            this.teclado_08.UseVisualStyleBackColor = false;
            this.teclado_08.Click += new System.EventHandler(this.teclado_08_Click);
            // 
            // teclado_07
            // 
            this.teclado_07.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_07.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_07.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_07.Location = new System.Drawing.Point(489, 245);
            this.teclado_07.Name = "teclado_07";
            this.teclado_07.Size = new System.Drawing.Size(67, 59);
            this.teclado_07.TabIndex = 20;
            this.teclado_07.Text = "7";
            this.teclado_07.UseVisualStyleBackColor = false;
            this.teclado_07.Click += new System.EventHandler(this.teclado_07_Click);
            // 
            // teclado_00
            // 
            this.teclado_00.BackColor = System.Drawing.Color.DarkSlateGray;
            this.teclado_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_00.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teclado_00.Location = new System.Drawing.Point(562, 311);
            this.teclado_00.Name = "teclado_00";
            this.teclado_00.Size = new System.Drawing.Size(67, 59);
            this.teclado_00.TabIndex = 23;
            this.teclado_00.Text = "0";
            this.teclado_00.UseVisualStyleBackColor = false;
            this.teclado_00.Click += new System.EventHandler(this.teclado_00_Click);
            // 
            // teclado_limpar
            // 
            this.teclado_limpar.BackColor = System.Drawing.Color.Yellow;
            this.teclado_limpar.Enabled = false;
            this.teclado_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teclado_limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teclado_limpar.Location = new System.Drawing.Point(489, 311);
            this.teclado_limpar.Name = "teclado_limpar";
            this.teclado_limpar.Size = new System.Drawing.Size(67, 59);
            this.teclado_limpar.TabIndex = 24;
            this.teclado_limpar.Text = "Limpar";
            this.teclado_limpar.UseVisualStyleBackColor = false;
            this.teclado_limpar.Click += new System.EventHandler(this.teclado_limpar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(722, 574);
            this.Controls.Add(this.teclado_limpar);
            this.Controls.Add(this.teclado_00);
            this.Controls.Add(this.teclado_09);
            this.Controls.Add(this.teclado_08);
            this.Controls.Add(this.teclado_07);
            this.Controls.Add(this.teclado_06);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.teclado_05);
            this.Controls.Add(this.teclado_04);
            this.Controls.Add(this.teclado_03);
            this.Controls.Add(this.teclado_02);
            this.Controls.Add(this.teclado_01);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.captureLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCapturarDigital);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão / Alteração de Biometria no PDV";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDigital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificarDigital;
        private System.Windows.Forms.Button btnIncluirDigital;
        private System.Windows.Forms.PictureBox pictureDigital;
        private System.Windows.Forms.Button btnCapturarDigital;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label captureLog;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer timerCapturar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblComSemDigital;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button teclado_01;
        private System.Windows.Forms.Button teclado_02;
        private System.Windows.Forms.Button teclado_03;
        private System.Windows.Forms.Button teclado_06;
        private System.Windows.Forms.Button teclado_05;
        private System.Windows.Forms.Button teclado_04;
        private System.Windows.Forms.Button teclado_09;
        private System.Windows.Forms.Button teclado_08;
        private System.Windows.Forms.Button teclado_07;
        private System.Windows.Forms.Button teclado_00;
        private System.Windows.Forms.Button teclado_limpar;
    }
}