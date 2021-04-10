using XGames.Domain.Interfaces.Arguments;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
    }
}
