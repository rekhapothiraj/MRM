using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MRM.Mobile.DomainModel.Models.Mapping
{
    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Booking");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.MeetingRoomId).HasColumnName("MeetingRoomId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.FromTime).HasColumnName("FromTime");
            this.Property(t => t.ToTime).HasColumnName("ToTime");

            // Relationships
            this.HasRequired(t => t.MeetingRoom)
                .WithMany(t => t.Bookings)
                .HasForeignKey(d => d.MeetingRoomId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Bookings)
                .HasForeignKey(d => d.UserId);

        }
    }
}
