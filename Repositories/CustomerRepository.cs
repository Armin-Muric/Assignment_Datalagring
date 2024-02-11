using Assignment_Datalagring.Contexts;
using Assignment_Datalagring.Entities;

namespace Assignment_Datalagring.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }
}
