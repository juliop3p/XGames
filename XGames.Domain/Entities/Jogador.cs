using prmToolkit.NotificationPattern;
using System;
using XGames.Domain.Enum;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {

        }
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNotEmail(x => x.Email.Endereco, "Informe um e-mail válido")
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 e 32 caracteres");
        }

        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; private set; }
        public EnumSituacaoJogador Status { get; set; }

    }
}
