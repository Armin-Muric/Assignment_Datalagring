using Assignment_Datalagring.Contexts;
using Assignment_Datalagring.Entities;

namespace Assignment_Datalagring.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
