using Assignment_Datalagring.Contexts;
using Assignment_Datalagring.Entities;

namespace Assignment_Datalagring.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
