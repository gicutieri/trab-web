namespace TrabalhoWeb.Ecommerce.Domain.Dtos
{
    public sealed class Result<T> : Result where T : class
    {
        public T Data { get; }

        public Result(T data)
            : base(true, string.Empty)
        {
            Data = data;
        }

        public Result(string[] erros)
            : base(false, erros)
        {
            Data = default(T);
        }

        public Result(bool sucesso, string mensagem)
            : base(sucesso, mensagem)
        {
            Data = default(T);
        }
    }
}
