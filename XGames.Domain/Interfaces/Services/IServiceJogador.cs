using System;
using XGames.Domain.Arguments.Base;
using XGames.Domain.Arguments.Jogador;

namespace XGames.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);

        ResponseBase ExcluirJogador(Guid id);
    }
}
