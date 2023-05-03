
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoteBook.Entities.DbSet;

namespace NoteBook.DataService.Data{

    public class AppDbContext:IdentityDbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){

        }

        public virtual  DbSet<Users> Users { get; set; }
    }
}