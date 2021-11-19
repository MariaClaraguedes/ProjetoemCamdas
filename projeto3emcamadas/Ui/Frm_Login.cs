using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

using projeto3emcamadas.Code.BLL;
using projeto3emcamadas.Code.DTO;

namespace projeto3emcamadas.Ui
{
    public partial class Frm_Login : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                frmPost Frmpost = new frmPost();
                Frmpost.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLabEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //configurar o cliente gmail
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11901799@aluno.cotemig.com.br", "haaqpzplmrcftlyq"),
                EnableSsl = true
            };

            loginDTO.Email = txtEmail.Text;
            string senha = loginBLL.RetornarSenha(loginDTO);

            client.Send("11901799@aluno.cotemig.com.br", $"{txtEmail.Text}", "Redefinição de Senha", $"Seu e-mail é {txtEmail} com senha {senha}");

            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
