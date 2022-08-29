using Devagram.Dtos;
using Devagram.Models;

namespace Devagram.Repository.Impl
{
    public  interface IPublicacaoRepository
    {
        public void Publicar(Publicacao publicacao);
        List<PublicacaoFeedRespostaDto> GetPublicacoesFeed(int idUsuario);
        List<PublicacaoFeedRespostaDto> GetPublicacoesFeedUsuario(int idUsuario);
    }
}
