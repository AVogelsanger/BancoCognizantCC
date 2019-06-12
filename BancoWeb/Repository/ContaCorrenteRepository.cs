using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using BancoDomain.Entity;
using BancoDomain.Persistence;
using System.Data.Entity;

namespace BancoWeb.Repository
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {

        private BancoContext _context;

        public ContaCorrenteRepository(BancoContext context)
        {
            _context = context;
        }


        public void Atualizar(ContaCorrente contaCorrente)
        {
            _context.Entry(contaCorrente).State = EntityState.Modified;
        }

        public IList<ContaCorrente> BuscarPor(Expression<Func<ContaCorrente, bool>> filtro)
        {
            return _context.ContasCorrentes.Where(filtro).ToList();
        }

        public ContaCorrente BuscarPorNumero(int numero)
        {
            return _context.ContasCorrentes.Find(numero);
        }

        public void Cadastrar(ContaCorrente contaCorrente)
        {
            _context.ContasCorrentes.Add(contaCorrente);
        }

        public void Excluir(int numero)
        {
            ContaCorrente cc = _context.ContasCorrentes.Find(numero);
            _context.ContasCorrentes.Remove(cc);
        }

        public IList<ContaCorrente> Listar()
        {
            return _context.ContasCorrentes.ToList();
        }
    }
}