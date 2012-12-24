using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MRM.Mobile.DomainModel.Models.Mapping;
using NUnit.Framework;
using System.Linq;

namespace MRM.Mobile.DomainModel.Models
{
    public interface IMRMContext
    {
        IDbSet<Booking> Bookings { get; set; }
        IDbSet<MeetingRoom> MeetingRooms { get; set; }
        IDbSet<Site> Sites { get; set; }
        IDbSet<User> Users { get; set; }
    }

    public class MRMContext : DbContext, IMRMContext
    {
        static MRMContext()
        {
            Database.SetInitializer<MRMContext>(null);
        }

		public MRMContext()
            : base("Name=MRMContext")
		{
		    this.Configuration.LazyLoadingEnabled = false;
		    this.Configuration.ProxyCreationEnabled = false;
		}

        public IDbSet<Booking> Bookings { get; set; }
        public IDbSet<MeetingRoom> MeetingRooms { get; set; }
        public IDbSet<Site> Sites { get; set; }
        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new MeetingRoomMap());
            modelBuilder.Configurations.Add(new SiteMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
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
