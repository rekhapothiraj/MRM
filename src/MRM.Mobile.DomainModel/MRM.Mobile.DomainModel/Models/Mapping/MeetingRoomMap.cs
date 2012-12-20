using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MRM.Mobile.DomainModel.Models.Mapping
{
    public class MeetingRoomMap : EntityTypeConfiguration<MeetingRoom>
    {
        public MeetingRoomMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MeetingRoom");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SiteId).HasColumnName("SiteId");

            // Relationships
            this.HasRequired(t => t.Site)
                .WithMany(t => t.MeetingRooms)
                .HasForeignKey(d => d.SiteId);

        }
    }
}
