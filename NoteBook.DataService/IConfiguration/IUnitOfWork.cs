using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.DataService.IRepository;

namespace NoteBook.DataService.IConfiguration
{
    public interface IUnitOfWork
    {
        IUsersRepository Users {get;}

        Task CompleteAsync();
    }
}