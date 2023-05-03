using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.Entities.DbSet;

namespace NoteBook.DataService.IRepository
{
    public interface IUsersRepository:IGenericRepository<Users>
    {

        Task<Users> GetUserPerEmailAddress(string email);
        
    }
}