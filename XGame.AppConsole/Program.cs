using System;
using System.Linq;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instância do servico...");

            var request = new AdicionarJogadorRequest() 
            { 
                PrimeiroNome = "Julio",
                UltimoNome = "Cesar",
                Email = "julio@gmail.com",
                Senha = "123456",

            };
            Console.WriteLine("Criei instância do meu objeto request");


            var response = service.AdicionarJogador(request);

            Console.WriteLine("Serviço é valido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });


            Console.ReadKey();
        }
    }
}
