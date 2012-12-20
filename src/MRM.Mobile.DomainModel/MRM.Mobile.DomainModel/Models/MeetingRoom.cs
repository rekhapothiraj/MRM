using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MRM.Mobile.DomainModel.Models
{
    [Serializable]
    [DataContract]
    public class MeetingRoom
    {
        public MeetingRoom()
        {
            this.Bookings = new List<Booking>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int SiteId { get; set; }
        [DataMember]
        public virtual ICollection<Booking> Bookings { get; set; }
        [DataMember]
        public virtual Site Site { get; set; }
    }
}
