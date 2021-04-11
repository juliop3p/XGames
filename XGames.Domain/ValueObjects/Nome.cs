using prmToolkit.NotificationPattern;

namespace XGames.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50)
                .IfNullOrInvalidLength(x => x.UltimoNome, 3, 50);
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
