using XGames.Domain.Interfaces.Arguments;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string UltimoNome { get; set; }
        public string PrimeiroNome { get; set; }
    }
}
