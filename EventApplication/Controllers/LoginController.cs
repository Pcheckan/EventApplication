using EventApplication.Interfaces;
using EventApplication.Models;
using EventApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace EventApplication.Controllers
{
    public class LoginController : Controller
    {
        private UsersInterfaces _usersInterfaces; 
        private readonly IHttpContextAccessor _httpContextAccessor; 
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public LoginController(
            UsersInterfaces usersInterfaces,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _usersInterfaces = usersInterfaces;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(UsersVM viewmodel)
        {
            var err = ModelState.Values.SelectMany(x => x.Errors).Select(e => e.ErrorMessage);
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("State");
            ModelState.Remove("Gender");
            ModelState.Remove("PhoneNumber");
            ModelState.Remove("ConfirmPassword");
            ModelState.Remove("Interest1");
            ModelState.Remove("Interest2");
            ModelState.Remove("Interest3");

            if (ModelState.IsValid)
            {
                Users usersdetails = await _usersInterfaces.Login(viewmodel.Email, viewmodel.Password);
                
                if (usersdetails != null)
                {
                    UsersVM newLoginCred = new UsersVM()
                    {
                        Id = usersdetails.Id,
                        Email = usersdetails.Email,
                        FirstName = usersdetails.FirstName,
                        LastName = usersdetails.LastName
                    };
                    _session.SetString("AuthCertificate", JsonConvert.SerializeObject(newLoginCred));

                    return RedirectToAction("Profile", "Home");
                }
                else {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
         
        public IActionResult LogOut()
        { 
            _session.Clear();
            _session.SetString("AuthCertificate", "");  
            return RedirectToAction("Index", "Home");
        }
    }

}
