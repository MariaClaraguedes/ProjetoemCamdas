using System;
using System.Windows.Forms;

//Importação da camada de negócio
using projeto3emcamadas.Code.BLL;
using projeto3emcamadas.Code.DTO;

namespace projeto3emcamadas.Ui
{
    public partial class frmPost : Form
    {
        PostBLL medbll = new PostBLL();
        PostDTO meddto = new PostDTO();

        public frmPost()
        {
            InitializeComponent();
            dgvConteudo.DataSource = medbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            meddto.Titulo = txtTitulo.Text;
            meddto.Constesto = txtConteudo.Text;

            medbll.Inserir(meddto);
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvConteudo.DataSource = medbll.Listar();
            //limpar campos
            txtTitulo.Clear();
            txtConteudo.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtid.Text);
            meddto.Titulo = txtTitulo.Text;
            meddto.Constesto = txtConteudo.Text;

            medbll.Editar(meddto);
            MessageBox.Show("Editado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvConteudo.DataSource = medbll.Listar();
            //limpar campos
            txtTitulo.Clear();
            txtConteudo.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtid.Text);
            meddto.Titulo = txtTitulo.Text;
            meddto.Constesto = txtConteudo.Text;

            medbll.Excluir(meddto);
            MessageBox.Show("Excluido com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvConteudo.DataSource = medbll.Listar();
            //limpar campos
            txtTitulo.Clear();
            txtConteudo.Clear();
        }

        private void dgvConteudo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvConteudo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitulo.Text = dgvConteudo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dgvConteudo.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvConteudo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
