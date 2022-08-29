using System.ComponentModel.DataAnnotations.Schema;

namespace Devagram.Models
{
    public class Seguidor
    {
        public int Id { get; set; }
        public int? IdUsuarioSeguidor { get; set; }
        public int? IdUsuarioSeguido { get; set; }

        [ForeignKey("IdUsuarioSeguidor")]//chave estrangeira de usuario
        public virtual Usuario UsuarioSeguidor { get; private set; }

        [ForeignKey("IdUsuarioSeguido")]//chave estrangeira de usuario
        public virtual Usuario UsuarioSeguido { get; private set; }

    }
}
