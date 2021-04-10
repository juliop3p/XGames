using XGames.Domain.Interfaces.Arguments;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest : IRequest
    {
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
