using System;
using System.Collections.Generic;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;
using XGames.Domain.Interfaces.Repositories.Base;

namespace XGames.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador : IRepositoryBase<Jogador, Guid>
    {
        //Jogador AutenticarJogador(string email, string senha);
        //Jogador AdicionarJogador(Jogador jogador);
        //IEnumerable<Jogador> ListarJogador();
        //Jogador ObterPorId(Guid Id);
        //Jogador AlterarJogador(string endereco, string senha);
    }
}
