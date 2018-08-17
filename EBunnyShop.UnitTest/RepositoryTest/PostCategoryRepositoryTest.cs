using EBunnyShop.Data.Infrastructure;
using EBunnyShop.Data.Repositories;
using EBunnyShop.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace EBunnyShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IUnitOfWork unitOfWork;
        IPostCategoryRepository objPostCateRep;

        [TestInitialize]
        public void Init()
        {
            dbFactory = new DbFactory();
            unitOfWork = new UnitOfWork(dbFactory);
            objPostCateRep = new PostCategoryRepository(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Get_GetAllPostCate()
        {
            var list = objPostCateRep.GetAll().ToList();
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void PostCategory_Post_CreatePostCategory()
        {
            PostCategory cate = new PostCategory();
            cate.Name = "Test 1";
            cate.Alias = "Test1";
            cate.Status = true;

            var result = objPostCateRep.Add(cate);
            unitOfWork.Commit();

            Assert.AreEqual(1, result.ID);

        }
    }
}