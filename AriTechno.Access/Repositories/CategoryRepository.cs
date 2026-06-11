using AriTechno.Access.Repositories.Interfaces;
using AriTechno.Database;
using AriTechno.Database.Entities;

namespace AriTechno.Access.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(AriTechnoDB ariTechnoDB) : base(ariTechnoDB)
    {


    }

    public int ProductCount(int categoryId)
    {
        throw new NotImplementedException();
    }
}
