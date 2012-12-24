using System;
using System.Collections.Generic;
using System.Diagnostics;
using MRM.Mobile.Data;
using MRM.Mobile.DomainModel.Models;
using System.Linq;

namespace MRM.Mobile.Service
{
    public class DataService : IDataService
    {
        private MRMContext _mrmContext;
        private IRepository<Site> _siteRepository;
        //public DataService()
        //{
        //    _siteRepository = new SiteRepository(new UnitOfWork());
        //}
        

        public DataService(IRepository<Site> siteRepository)
        {
            // _mrmContext = new MRMContext();
            _siteRepository =  siteRepository;
        }

        public IEnumerable<Site> GetSites()
        {
            var sites = _siteRepository.GetAll();
                //_mrmContext.Sites.ToList();
            return sites;
        }

        public IEnumerable<MeetingRoom> GetMeetingRooms()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Booking> GetBookings()
        {
            throw new System.NotImplementedException();
        }

        public bool AddSite(Site site)
        {
            try
            {
                _siteRepository.Add(site);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddMeetingRoom(MeetingRoom meetingRoom)
        {
            throw new System.NotImplementedException();
        }

        public bool CreateNewBooking(Booking booking)
        {
            throw new System.NotImplementedException();
        }

        public string Greet()
        {
            Console.WriteLine("Greeting now");
            return "Hello";
        }

        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
    }
}