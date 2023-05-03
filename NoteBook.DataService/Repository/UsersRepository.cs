using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NoteBook.DataService.Data;
using NoteBook.DataService.IRepository;
using NoteBook.Entities.DbSet;

namespace NoteBook.DataService.Repository
{
    public class UsersRepository:GenericRepository<Users>, IUsersRepository
    {
        
      public UsersRepository(AppDbContext context,ILogger logger):base(context,logger){

      }

        public override async Task<IEnumerable<Users>> All()
        {
           try{
               return  await dbset.Where(x=> x.Status==1).AsNoTracking().ToListAsync();
           }
           catch(Exception e){
             _logger.LogError(e,"{Repo} All methods has generated error",typeof(UsersRepository));
             return new List<Users>();
           }
           
        }
        public Task<Users> GetUserPerEmailAddress(string email)
        {
            throw new NotImplementedException();
        }
    }
}