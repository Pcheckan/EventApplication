using EventApplication.Interfaces;
using EventApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EventApplication.Controllers
{
    public class HomeController : Controller
    {
        private UsersInterfaces _usersInterfaces;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public HomeController(
            UsersInterfaces usersInterfaces,
            IHttpContextAccessor httpContextAccessor)
        {
            _usersInterfaces = usersInterfaces;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }
         
        public async Task<IActionResult> Profile()
        {
            var SessionData = JsonConvert.DeserializeObject<Users>(_session.GetString("AuthCertificate"));
            if (SessionData != null)
            {
                Users data = await _usersInterfaces.GetProfileDataByEmail(SessionData.Email);
                return View(data);
            }
            else {
                return RedirectToAction("Index", "Login"); 
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
