using prmToolkit.NotificationPattern;
using System;
using XGames.Domain.Enum;
using XGames.Domain.Extensions;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 e 32 caracteres");
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 e 32 caracteres");

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(nome, email);
        }

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public EnumSituacaoJogador Status { get; private set; }

    }
}
