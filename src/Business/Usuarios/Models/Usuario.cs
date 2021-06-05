using Business.Core.Models;
namespace Business.Usuarios.Models
{
    public class Usuario : Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
