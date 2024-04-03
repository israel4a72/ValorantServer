namespace ValorantServer.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public string Mensagem { get; set; }

        public DomainException(string mensagem) : base(mensagem)
        {
            Mensagem = mensagem;
        }
    }
}