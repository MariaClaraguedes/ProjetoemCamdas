
using projeto3emcamadas.Code.DTO;
using projeto3emcamadas.Code.DAL;
using System.Data;

namespace projeto3emcamadas.Code.BLL
{
    class PostBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Post";
        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(PostDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Titulo}','{medDto.Constesto}','1')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(PostDTO medDto)
        {
            string editar = $"update {tabela} set titulo = '{medDto.Titulo}', conteudo = '{medDto.Constesto}' where codigo = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(PostDTO medDto)
        {
            string excluir = $"delete from {tabela} where codigo = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by codigo;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
