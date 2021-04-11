using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;
using XGames.Domain.Interfaces.Repositories;
using XGames.Domain.Interfaces.Services;
using XGames.Domain.Resources;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            Jogador jogador = new Jogador(nome, email, request.Senha);

            if (jogador.IsInvalid())
            {
                return null;
            }
                Guid id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest"));
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador);

            if (jogador.IsInvalid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);

            return response;
        }

        private bool IsEmail(string email)
        {

            return false;
        }
    }
}
