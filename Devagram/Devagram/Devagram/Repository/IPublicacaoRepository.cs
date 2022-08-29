using Devagram.Dtos;
using Devagram.Models;

namespace Devagram.Repository
{
    public interface IPublicacaoRepository
    {
        public void Publicar(Publicacao publicacao);
<<<<<<< HEAD
        List<PublicacaoFeedRespostaDto> GetPublicacoesFeed(int idUsuario);
        List<PublicacaoFeedRespostaDto> GetPublicacoesFeedUsuario(int idUsuario);
=======
       
>>>>>>> 34874c067c4e500f51dbf02ceefb1ea516dfd0bd
    }
}
