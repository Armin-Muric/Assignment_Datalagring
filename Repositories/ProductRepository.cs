using Assignment_Datalagring.Contexts;
using Assignment_Datalagring.Entities;

namespace Assignment_Datalagring.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
