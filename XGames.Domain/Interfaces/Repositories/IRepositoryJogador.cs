using System;
using System.Collections.Generic;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;

namespace XGames.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);
        Jogador AdicionarJogador(Jogador request);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterPorId(Guid Id);
        Jogador AlterarJogador(string endereco, string senha);
    }
}
