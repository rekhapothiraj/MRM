using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MRM.Mobile.DomainModel.Models
{
    [Serializable]
    [DataContract]
    public class Site
    {
        public Site()
        {
            this.MeetingRooms = new List<MeetingRoom>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual ICollection<MeetingRoom> MeetingRooms { get; set; }
    }
}
