using System;
using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador v)
        {
            throw new NotImplementedException();
        }
    }
}
