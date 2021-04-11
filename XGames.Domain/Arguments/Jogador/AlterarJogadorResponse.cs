using System;
using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Jogador
{
    public class AlterarJogadorResponse : IResponse
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Message { get; private set; }

        public static explicit operator AlterarJogadorResponse(Entities.Jogador entidade)
        {
            return new AlterarJogadorResponse()
            {
                Email = entidade.Email.Endereco,
                Id = entidade.Id,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                Message = "Operação realizada com sucesso!"
            };
        }
    }
}
