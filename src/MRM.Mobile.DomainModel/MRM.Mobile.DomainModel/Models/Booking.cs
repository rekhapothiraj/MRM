using System;
using System.Runtime.Serialization;

namespace MRM.Mobile.DomainModel.Models
{
    [Serializable]
    [DataContract]
    public class Booking
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int MeetingRoomId { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public System.DateTime FromTime { get; set; }
        [DataMember]
        public System.DateTime ToTime { get; set; }
        [DataMember]
        public virtual MeetingRoom MeetingRoom { get; set; }
        [DataMember]
        public virtual User User { get; set; }
    }
}
