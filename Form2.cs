using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ControliD;

namespace ValidaDigital
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string t;
        byte[] imageBuf;
        uint width, height;
        int quality;
        string campoFocado = "usuario";

        public static Bitmap ImageBufferToBitmap(byte[] imageBuf, uint width, uint height)
        {
            Bitmap img = new Bitmap((int)width, (int)height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    var color = Color.FromArgb(imageBuf[x + img.Width * y], imageBuf[x + img.Width * y], imageBuf[x + img.Width * y]);
                    img.SetPixel(x, y, color);
                }
            }
            return img;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { maskedTextBox1.Focus(); campoFocado = "senha"; }

            else
            {
                String nomeUsuario = "", biometriaID = "";
                //Logando o usuário
                OracleConnection conn2 = new OracleConnection("Data Source=(DESCRIPTION="
                                                            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.11.0.30)(PORT=1521)))"
                                                            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=INTEGRACAOSP)));"
                                                            + "User Id=pdvuser;Password=pdv1234");

                OracleCommand oCmd2 = new OracleCommand();
                string query2 = "select " +
                                "u.tsys_nome, " +
                                "u.tsys_biometria_id " +
                                "from tsys_usuario u " +
                                "where u.tsys_usuario_pk = " + txtUsuario.Text + " " +
                                "and u.tsys_senha = '" + maskedTextBox1.Text + "'";
                oCmd2.CommandText = query2;
                oCmd2.CommandType = CommandType.Text;
                oCmd2.Connection = conn2;
                conn2.Open();
                OracleDataReader ler1 = oCmd2.ExecuteReader();
                while (ler1.Read())
                {
                    nomeUsuario = ler1.GetValue(0).ToString();
                    biometriaID = ler1.GetValue(1).ToString();
                }

                if (nomeUsuario == "")
                {
                    MessageBox.Show("A combinação de usuário e senha fornecidos é inválida.", "Login Negado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    maskedTextBox1.Text = "";
                    txtUsuario.Focus();
                    campoFocado = "usuario";
                }
                else
                {
                    lblNomeUsuario.Text += " " + nomeUsuario;
                    btnLogin.Enabled = false;
                }

                if (biometriaID != "" && nomeUsuario != "")
                {
                    btnModificarDigital.Enabled = true;
                    lblComSemDigital.Text = "Usuário COM Digital";
                    lblComSemDigital.Visible = true;
                }
                else if (biometriaID == "" && nomeUsuario != "")
                {
                    btnIncluirDigital.Enabled = true;
                    lblComSemDigital.Text = "Usuário SEM Digital";
                    lblComSemDigital.Visible = true;
                }

                conn2.Close();
            }
        }

        
        void CapturarDigital ()
        {
            t = "";
            imageBuf = null;
            CIDBio cIDBio = new CIDBio();
            cIDBio.CaptureImageAndTemplate(out t, out imageBuf, out width, out height, out quality);
            //MessageBox.Show(imageBuf.ToString());
            if (t.Length > 0)
            {
                pictureDigital.Image = ImageBufferToBitmap(imageBuf, width, height);
                button1.Enabled = true;
                lblMensagem.Text = "Digital Capturada";
                lblMensagem.ForeColor = Color.Green;
            }
            else
            {
                lblMensagem.Text = "Erro na Captura da Digital";
                lblMensagem.ForeColor = Color.Red;
                button1.Enabled = false;
            }
            timerCapturar.Stop();
        }

        private void btnCapturarDigital_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarDigital_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            lblMensagem.Text = "Posicione o Dedo no Leitor";
            lblMensagem.ForeColor = Color.White;
            timerCapturar.Interval = 1000;
            timerCapturar.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn2 = new OracleConnection("Data Source=(DESCRIPTION="
                                                            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.11.0.30)(PORT=1521)))"
                                                            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=INTEGRACAOSP)));"
                                                            + "User Id=pdvuser;Password=pdv1234");

                OracleCommand oCmd2 = new OracleCommand();
                string query2 = "update tsys_usuario u " +
                                "set u.tsys_biometria_id = '" + t + "' " +
                                "where u.tsys_usuario_pk = " + txtUsuario.Text;
                oCmd2.CommandText = query2;
                oCmd2.CommandType = CommandType.Text;
                oCmd2.Connection = conn2;
                conn2.Open();
                oCmd2.ExecuteNonQuery();
                conn2.Close();
                MessageBox.Show("Biometria Salva com sucesso no banco de dados", "Sucesso", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIncluirDigital.Enabled = false;
                btnModificarDigital.Enabled = false;
                lblNomeUsuario.Text = "Nome:";
                txtUsuario.Text = "";
                maskedTextBox1.Text = "";
                btnLogin.Enabled = true;
                pictureDigital.Image = null;
                this.button1.Enabled = false;
                lblMensagem.Text = "";
                lblComSemDigital.Visible = false;
                txtUsuario.Focus();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnIncluirDigital_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            lblMensagem.Text = "Posicione o Dedo no Leitor";
            timerCapturar.Interval = 1000;
            timerCapturar.Start();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "" && this.maskedTextBox1.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void timerCapturar_Tick(object sender, EventArgs e)
        {
            CapturarDigital();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teclado_01_Click(object sender, EventArgs e)
        {
            if(campoFocado == "usuario") { txtUsuario.Text += "1"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "1"; }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            campoFocado = "usuario";
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            campoFocado = "senha";
        }

        private void teclado_02_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "2"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "2"; }
        }

        private void teclado_03_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "3"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "3"; }
        }

        private void teclado_04_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "4"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "4"; }
        }

        private void teclado_05_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "5"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "5"; }
        }

        private void teclado_06_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "6"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "6"; }
        }

        private void teclado_07_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "7"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "7"; }
        }

        private void teclado_08_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "8"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "8"; }
        }

        private void teclado_09_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "9"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "9"; }
        }

        private void teclado_00_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text += "0"; }
            if (campoFocado == "senha") { maskedTextBox1.Text += "0"; }
        }

        private void teclado_limpar_Click(object sender, EventArgs e)
        {
            if (campoFocado == "usuario") { txtUsuario.Text = ""; }
            if (campoFocado == "senha") { maskedTextBox1.Text = ""; }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                teclado_limpar.Enabled = true;
            }

            else if (maskedTextBox1.Text != "")
            {
                teclado_limpar.Enabled = true;
            }
            else
            {
                teclado_limpar.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var ret = CIDBio.Init();
            if (ret == RetCode.SUCCESS)
            {
                captureLog.Text += "Leitor Iniciado Corretamente\r\n";
                btnCapturarDigital.Enabled = true;
            }
            else if (ret < RetCode.SUCCESS)
            {
                captureLog.Text += "Erro na inicialização: " + CIDBio.GetErrorMessage(ret) + "\r\n";
            }
            else
            {
                captureLog.Text += "Alerta: " + CIDBio.GetErrorMessage(ret) + "\r\n";
                btnCapturarDigital.Enabled = true;
            }
        }
    }
}
