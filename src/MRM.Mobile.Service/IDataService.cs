using System;
using System.Collections.Generic;
using System.ServiceModel;
using MRM.Mobile.DomainModel.Models;

namespace MRM.Mobile.Service
{
    [ServiceContract]
   public interface IDataService : IDisposable
    {
        [OperationContract]
        IEnumerable<Site> GetSites();

        [OperationContract]
        IEnumerable<MeetingRoom> GetMeetingRooms();

        [OperationContract]
        IEnumerable<Booking> GetBookings();

        [OperationContract]
        bool AddSite(Site site);
        [OperationContract]
        bool AddMeetingRoom(MeetingRoom meetingRoom);
        [OperationContract]
        bool CreateNewBooking(Booking booking);
        [OperationContract]
        string Greet();
    }
}
