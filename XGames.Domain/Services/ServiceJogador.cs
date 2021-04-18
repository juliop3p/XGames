using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using XGames.Domain.Arguments.Base;
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

            jogador = _repositoryJogador.Adicionar(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest"));
            }

            Jogador jogador = _repositoryJogador.ObterPorId(request.Id);

            if(jogador == null)
            {
                AddNotification("Id", "Dados não encontrado");
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            jogador.AlterarJogador(nome, email, jogador.Status);

            AddNotifications(jogador);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryJogador.Editar(jogador);

            return (AlterarJogadorResponse)jogador;
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

            jogador = _repositoryJogador.ObterPor(x => x.Email.Endereco == jogador.Email.Endereco, x => x.Senha == jogador.Senha);

            return (AutenticarJogadorResponse)jogador;
        }

        public ResponseBase ExcluirJogador(Guid id)
        {
            Jogador jogador = _repositoryJogador.ObterPorId(id);

            if(jogador == null)
            {
                AddNotification("Id", "Jogador não encontrado");
                return null;
            }

            _repositoryJogador.Remover(jogador);

            return new ResponseBase() { Message = "Operação realizada com sucesso!" };

        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            //return _repositoryJogador.ListarJogador().ToList().Select(jogador => (JogadorResponse)jogador).ToList();
            return _repositoryJogador.Listar().Select(jogador => (JogadorResponse)jogador).ToList();
        }

        private bool IsEmail(string email)
        {

            return false;
        }
    }
}
