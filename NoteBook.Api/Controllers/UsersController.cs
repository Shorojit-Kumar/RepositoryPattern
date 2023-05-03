
using Microsoft.AspNetCore.Mvc;
using NoteBook.DataService.Data;
using NoteBook.Entities.DbSet;
using NoteBook.Entities.Dtos;

namespace NoteBook.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {

        private readonly AppDbContext _context;

        public UsersController(AppDbContext db)
        {
            _context = db;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }


        [HttpPost]
        [Route("AddUsers")]
        public IActionResult AddUsers(UserDto user)
        {
            var _user=new Users();
            _user.FirstName=user.FirstName;
            _user.LastName=user.LastName;
            _user.Email=user.Email;
            _user.Phone=user.Phone;
            _user.DateOfBirth=Convert.ToDateTime(user.DateOfBirth);
            _user.Country=user.Country;
            
            _context.Users.Add(_user);
            _context.SaveChanges();

            var mes=new {
                Message="Success",
                User=_user
            };
            
            return Ok(mes);
        }















    }

}