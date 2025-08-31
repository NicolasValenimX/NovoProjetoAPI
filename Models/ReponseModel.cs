namespace NovoProjetoAPI.Models
{
    public class ReponseModel<T>
    {
        public T? Dados {get; set;}
        public string? Mensagem { get; set; } = string.Empty;
        public bool status { get; set; } = true;
    }
}