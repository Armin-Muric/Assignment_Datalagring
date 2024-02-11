using Assignment_Datalagring.Contexts;
using Assignment_Datalagring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Datalagring.Repositories
{
    internal class AddressRepository : Repo<AddressEntity>
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }
    }
}
