using System;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;

namespace XGames.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(string email, string senha);
        Guid AdicionarJogador(Jogador request);
    }
}
