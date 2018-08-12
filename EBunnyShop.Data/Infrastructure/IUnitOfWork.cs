namespace EBunnyShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}