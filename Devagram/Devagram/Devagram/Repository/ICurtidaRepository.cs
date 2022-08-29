using Devagram.Models;

namespace Devagram.Repository
{
    public interface ICurtidaRepository
    {
        public void Curtir(Curtida curtida);
        public void Descurtir(Curtida curtida);
        public Curtida GetCurtida(int idPublicacao, int idUsuario);
        List<Curtida> GetCurtidaPorPublicacao(int idPublicacao);
    }
}
