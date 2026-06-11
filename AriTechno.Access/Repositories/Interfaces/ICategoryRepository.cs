using AriTechno.Database.Entities;

namespace AriTechno.Access.Repositories.Interfaces
{
    public interface ICategoryRepository:IRepository<Category>
    {

        public int ProductCount(int categoryId);

    }
}
