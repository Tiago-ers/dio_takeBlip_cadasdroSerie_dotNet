using System.Text;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Genero: " + this.Genero);
            retorno.AppendLine("Titulo: " + this.Titulo);
            retorno.AppendLine("Descrição: " + this.Descricao);
            retorno.AppendLine("Ano de Inicio: " + this.Ano);
            retorno.AppendLine("Excluido: " + this.Excluido);

            return retorno.ToString();
        }

        public int getId()
        {
            return this.Id;
        }

        public string getTitulo()
        {
            return this.Titulo;
        }

        public bool getExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}