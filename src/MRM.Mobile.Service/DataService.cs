using System;
using System.Collections.Generic;
using System.Diagnostics;
using MRM.Mobile.DomainModel.Models;
using System.Linq;

namespace MRM.Mobile.Service
{
    public class DataService : IDataService
    {
        private MRMContext _mrmContext;

        public DataService()
        {
            _mrmContext = new MRMContext();
        }

        public IEnumerable<Site> GetSites()
        {
            var sites = _mrmContext.Sites.ToList();
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
            throw new System.NotImplementedException();
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