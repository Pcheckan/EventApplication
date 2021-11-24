using EventApplication.Interfaces;
using EventApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventApplication.Controllers
{
    public class EventController : Controller
    {

        private UsersInterfaces _usersInterfaces;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public EventController(
           UsersInterfaces usersInterfaces,
           IHttpContextAccessor httpContextAccessor)
        {
            _usersInterfaces = usersInterfaces;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> EventRecomended()
        {
            var SessionData = JsonConvert.DeserializeObject<Users>(_session.GetString("AuthCertificate"));
            if (SessionData != null)
            {
                Users data = await _usersInterfaces.GetProfileDataByEmail(SessionData.Email);
                RecommendEvents(data);
                return View(data);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        public IActionResult EventSearch()
        {
            return View();
        }
        public void RecommendEvents(Users data)
        {

        }
    }
}
