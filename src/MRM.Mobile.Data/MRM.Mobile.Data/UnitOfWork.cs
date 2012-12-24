using System;
using MRM.Mobile.DomainModel.Models;

namespace MRM.Mobile.Data
{
    public interface IUnitOfWork
    {
        int Save();
        MRMContext Context { get; }
    }

    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private MRMContext _context;

        public UnitOfWork()
        {
            _context = new MRMContext();
        }

        public UnitOfWork(MRMContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public MRMContext Context
        {
            get { return _context; }

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
