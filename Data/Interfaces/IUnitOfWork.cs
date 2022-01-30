using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp_Api.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChanges();
    }
}
