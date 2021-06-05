using Business.Core.Models;
using Business.Usuarios.Models;

namespace Business.Financas.Models
{
    public class Conta : Entity
    {
        public float ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
    }
}
