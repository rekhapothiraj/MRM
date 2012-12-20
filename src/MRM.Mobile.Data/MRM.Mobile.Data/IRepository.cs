using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using MRM.Mobile.DomainModel.Models;

namespace MRM.Mobile.Data
{
    /*
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> Fetch();
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T Single(Func<T, bool> predicate);
        T First(Func<T, bool> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Attach(T entity);
        void SaveChanges();
        void SaveChanges(SaveOptions options);
    }


    public class DataRepository<T> : IRepository<T> where T : class
    {
        private readonly ObjectContext _context;
        private ObjectSet<T> _objectSet;

        public DataRepository(ObjectContext context)
        {
            this._context = context;
            _objectSet = _context.CreateObjectSet<T>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Fetch()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _objectSet.Where<T>(predicate);
        }

        public T Single(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public T First(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges(SaveOptions options)
        {
            throw new NotImplementedException();
        }
    }
    */



}
