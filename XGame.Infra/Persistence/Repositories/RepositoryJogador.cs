using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Infra.Persistence.Repositories.Base;
using XGames.Domain.Entities;
using XGames.Domain.Interfaces.Repositories;

namespace XGame.Infra.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly XGameContext _context;

        public RepositoryJogador(XGameContext context) : base(context)
        {
            _context = context;
        }

        //public Jogador AdicionarJogador(Jogador jogador)
        //{
        //    _context.Jogadores.Add(jogador);
        //    _context.SaveChanges();
        //    return jogador;
        //}

        //public Jogador AlterarJogador(string endereco, string senha)
        //{
        //    throw new NotImplementedException();
        //}

        //public Jogador AutenticarJogador(string email, string senha)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Jogador> ListarJogador()
        //{
        //    return _context.Jogadores.ToList();
        //}

        //public Jogador ObterPorId(Guid Id)
        //{
        //    throw new NotImplementedException();
        //}

        //public int CalculaJogadores()
        //{
        //    string nome = "Paulo";
        //    string ultimoNome = "Marques";
        //    string sexo = string.Empty;

        //    IQueryable<Jogador> jogadores = _context.Jogadores.AsNoTracking().AsQueryable();

        //    if(!string.IsNullOrEmpty(nome))
        //    {
        //        jogadores = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(nome));
        //    }

        //    if(!string.IsNullOrEmpty(ultimoNome))
        //    {
        //        jogadores = jogadores.Where(x => x.Nome.UltimoNome.StartsWith(ultimoNome));
        //    }

        //    if(!string.IsNullOrEmpty(sexo))
        //    {
        //        jogadores = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(nome));
        //    }

        //    return jogadores.AsParallel().ToList().Count();

        //    // ToList -> faz com que a aplicação va ao BD
        //    // AsNoTracking() -> query mais rapidas, utilizar quando não for salvar dados no BD
        //    // AsParallel() -> para consultas mais pesadas, utiliza mais threads
        //}
    }
}
