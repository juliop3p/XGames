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

            //var request = new AutenticarJogadorRequest();
            //request.Email = "julio@gmail.com";
            //request.Senha = "123456";

            //var response = service.AutenticarJogador(request);

            var AdicionarRequest = new AdicionarJogadorRequest() 
            { 
                PrimeiroNome = "Julio",
                UltimoNome = "Cesar",
                Email = "julio@gmail.com",
                Senha = "123456",

            };
            Console.WriteLine("Criei instância do meu objeto request");


            var responseAdd = service.AdicionarJogador(AdicionarRequest);

            Console.WriteLine("Serviço é valido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });


            Console.ReadKey();
        }
    }
}
