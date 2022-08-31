using Devagram.Dtos;
using Devagram.Models;

namespace Devagram.Repository
{
    public interface IPublicacaoRepository
    {
        public void Publicar(Publicacao publicacao);
        List<PublicacaoFeedRespostaDto> GetPublicacoesFeed(int idUsuario);
        List<PublicacaoFeedRespostaDto> GetPublicacoesFeedUsuario(int idUsuario);
        int GetQtdePublicacoes(int idUsuario);
    }
}
