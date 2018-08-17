using EBunnyShop.Data.Infrastructure;
using EBunnyShop.Data.Repositories;
using EBunnyShop.Model.Models;
using EBunnyShop.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace EBunnyShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepo;
        private Mock<IUnitOfWork> _mockUnitOW;
        private IPostCategoryService _postCateService;
        private List<PostCategory> lstPostCate;

        [TestInitialize]
        public void Init()
        {
            _mockRepo = new Mock<IPostCategoryRepository>();
            _mockUnitOW = new Mock<IUnitOfWork>();
            _postCateService = new PostCategoryService(_mockRepo.Object, _mockUnitOW.Object);
            lstPostCate = new List<PostCategory>()
            {
                new PostCategory() {ID = 1, Name = "PC1", Status = true},
                new PostCategory() {ID = 1, Name = "PC2", Status = true},
                new PostCategory() {ID = 1, Name = "PC3", Status = true}
            };
        }

        [TestMethod]
        public void PostCategory_Get_GetAll()
        {
            _mockRepo.Setup(m => m.GetAll(null)).Returns(lstPostCate);
            var res = _postCateService.GetAll().ToList();
            Assert.AreEqual(3, res.Count);
        }

        [TestMethod]
        public void PostCategory_Post_CreatePostCate()
        {
            PostCategory cate = new PostCategory();
            cate.ID = 1;
            cate.Name = "Test 1";
            cate.Alias = "Test";
            cate.Status = true;

            _mockRepo.Setup(m => m.Add(cate)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });

            var res = _postCateService.Add(cate);
            Assert.AreEqual(1, res.ID);
        }
    }
}