using EventApplication.Interfaces;
using EventApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EventApplication.DAL
{
    public class UsersDAL : UsersInterfaces
    {
        public async Task<Users> Login(string Email, string Password)
        {
            using (AppDBContext context = new AppDBContext())
            {
                Users data = await context.Users.SingleOrDefaultAsync(x => x.Email == Email && x.Password == Password);

                return data;
            }
        }

        public async Task<Users> Register(Users model)
        {
            using (AppDBContext context = new AppDBContext())
            {
                Users data = await context.Users.FirstOrDefaultAsync(x => x.Email == model.Email);

                if (data == null)
                { 
                    await context.Users.AddAsync(model);
                    await context.SaveChangesAsync(); 
                    Users userdata = await context.Users.FirstOrDefaultAsync(x => x.Email == model.Email); 
                    return userdata;
                }
                return null;
            }
        }

        public async Task<Users> GetProfileDataByEmail(string Email)
        {
            using (AppDBContext context = new AppDBContext())
            {
                var data = await context.Users.FirstOrDefaultAsync(x => x.Email == Email);
                return data;
            }
        }
    }
}
