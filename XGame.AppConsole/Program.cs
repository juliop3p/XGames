using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instância do meu objeto request");

            request.Email = "julio@gmail.com";
            request.Senha = "123456";

            var response = service.AutenticarJogador(request);

            Console.WriteLine("Serviço é valido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });


            Console.ReadKey();
        }
    }
}
