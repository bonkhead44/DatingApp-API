using DatingApp_Api.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp_Api.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _dBContext;
        public UnitOfWork(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<bool> SaveChanges()
        {
            return await _dBContext.SaveChangesAsync() > 0; 
        }
    }
}
