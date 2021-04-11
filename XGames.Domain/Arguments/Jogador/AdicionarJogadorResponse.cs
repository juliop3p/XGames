using System;
using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador entidade)
        {
            return new AdicionarJogadorResponse()
            {
                Id = entidade.Id,
                Message = "Usuário criado com sucesso!"
            };
        }
    }
}
