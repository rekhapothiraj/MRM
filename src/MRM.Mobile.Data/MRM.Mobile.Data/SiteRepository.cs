using System;
using System.Collections.Generic;
using System.Linq;
using MRM.Mobile.DomainModel.Models;

namespace MRM.Mobile.Data
{
    public class SiteRepository : IRepository<Site>
    {
        private MRMContext _mrmContext;

        public SiteRepository(UnitOfWork uow)
        {
            _mrmContext = uow.Context;
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //public IQueryable<Site> Fetch()
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Site> GetAll()
        {
            return _mrmContext.Sites.ToList();
        }

        //public IEnumerable<Site> Find(Func<Site, bool> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public Site Single(Func<Site, bool> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public Site First(Func<Site, bool> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public void Add(Site entity)
        {
            _mrmContext.Sites.Add(entity);
            _mrmContext.SaveChanges();
        }

        //public void Delete(Site entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Attach(Site entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

        //public void SaveChanges(SaveOptions options)
        //{
        //    throw new NotImplementedException();
        //}
    }
}