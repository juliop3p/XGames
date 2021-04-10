using System;
using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
