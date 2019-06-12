using BancoDomain.Persistence;
using BancoWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoWeb.Unit
{
    public class UnitOfWork : IDisposable
    {

        private BancoContext _context = new BancoContext();

        private IContaCorrenteRepository _contaCorrente;

        public IContaCorrenteRepository ContaCorrenteRepository
        {
            get
            {
                if (_contaCorrente == null)
                {
                    _contaCorrente = new ContaCorrenteRepository(_context);
                }
                return _contaCorrente;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}