using System.Linq;
using MRM.Mobile.DomainModel.Models;
using MRM.Mobile.InfraStructure;
using MRM.Mobile.Service;
using NUnit.Framework;

namespace MRM.Mobile.Services.IntegrationTest
{
    [TestFixture]
    public class DataServiceTest
    {
        private IDataService _dataService;

        [SetUp]
        public void SetUp()
        {
            _dataService = DependencyResolver.Resolve<MRM.Mobile.Service.IDataService>();
        }

        [Test]
        public void ShouldGetListOfSites()
        {

            var enumerable = _dataService.GetSites();
            
            Assert.That(enumerable.Count(), Is.GreaterThan(0));
        }

        [Test]
        public void ShouldAddNewSiteToDb()
        {
            var site = new Site();
            site.Name = "TestSite";

            var addSite = _dataService.AddSite(site);

            Assert.That(addSite,Is.True);

            var enumerable = _dataService.GetSites();
            Assert.That(enumerable.Count(),Is.EqualTo(3));
        }
    }
}
