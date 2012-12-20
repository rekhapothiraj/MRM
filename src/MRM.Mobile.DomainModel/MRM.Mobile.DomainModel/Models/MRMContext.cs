using System.Data.Entity;
using MRM.Mobile.DomainModel.Models.Mapping;
using NUnit.Framework;
using System.Linq;

namespace MRM.Mobile.DomainModel.Models
{
    public class MRMContext : DbContext
    {
        static MRMContext()
        {
            Database.SetInitializer<MRMContext>(null);
        }

		public MRMContext()
			: base("Name=MRMContext")
		{
		}

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new MeetingRoomMap());
            modelBuilder.Configurations.Add(new SiteMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }


    [TestFixture]
    public class  MRMContextTest
    {

        [Test]
        public void SouldCallContextAndGEtSites()
        {
            var mrmContext = new MRMContext();
            mrmContext.Sites.ToList();
        }
    }
}
