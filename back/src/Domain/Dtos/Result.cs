namespace TrabalhoWeb.Ecommerce.Domain.Dtos
{
    public class Result
    {
        public bool Sucesso { get; }
        public string Mensagem { get; }
        public string[] Erros { get; }

        public Result(string mensagem)
        {
            Sucesso = false;
            Mensagem = mensagem;
            Erros = new string[0];
        }

        public Result(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Erros = new string[0];
        }

        public Result(bool sucesso, string[] erros)
        {
            Sucesso = sucesso;
            Mensagem = string.Empty;
            Erros = erros;
        }
    }
}
