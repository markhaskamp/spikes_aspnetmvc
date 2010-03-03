using MbUnit.Framework;
using MyKindleBooks.Controllers;
using MyKindleBooks.DataAccess;
using NHibernate;
using Rhino.Mocks;

namespace MyKindleBooks.Tests.Controllers
{
    [TestFixture]
    public class CategoryControllerTest
    {
        private MockRepository mockery;
        private ISession mockSession;
        private ICategoryRepository mockCategoryRepository;

        [Test]
        public void TestMethod1()
        {
            mockery = new MockRepository();
            mockCategoryRepository = mockery.DynamicMock<ICategoryRepository>();
            mockSession = mockery.DynamicMock<ISession>();
            var catController = new CategoryController(mockCategoryRepository);

            using(mockery.Record()) {
                mockCategoryRepository.GetAllCategoriesWithSubcategories(mockSession);
            }

            using (mockery.Playback()) {
                catController.Index();
            }

            mockery.VerifyAll();
                
        }
    }
}
