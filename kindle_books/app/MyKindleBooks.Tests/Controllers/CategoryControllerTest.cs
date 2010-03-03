using System.Collections.Generic;
using MbUnit.Framework;
using MyKindleBooks.Controllers;
using MyKindleBooks.DataAccess;
using MyKindleBooks.Domain;
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
        public void Test_Calls_Index_Calls_CategoryRepository_Calls_GetAllCategoriesWithSubcategories()
        {
            mockery = new MockRepository();
            mockSession = mockery.DynamicMock<ISession>();
            mockCategoryRepository = mockery.DynamicMock<ICategoryRepository>();

            var catController = new CategoryController(mockCategoryRepository);

            using(mockery.Record()) {
                Expect.Call(
                    mockCategoryRepository.GetAllCategoriesWithSubcategories())
                    .Return(new List<Category>());
            }

            using (mockery.Playback()) {
                catController.Index();
            }

            mockery.VerifyAll();
        }
    }
}
