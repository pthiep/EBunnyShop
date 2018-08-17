using EBunnyShop.Data.Infrastructure;
using EBunnyShop.Model.Models;

namespace EBunnyShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {

    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}