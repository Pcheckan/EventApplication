using AutoMapper;
using EventApplication.Interfaces;
using EventApplication.Models;
using EventApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EventApplication.Controllers
{
    public class RegisterController : Controller
    {
        private UsersInterfaces _usersInterfaces; 
        private readonly IMapper _mapper;
        public RegisterController(
            UsersInterfaces usersInterfaces,
            IMapper mapper
            )
        {
            _usersInterfaces = usersInterfaces;
            _mapper = mapper;
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

            if (ModelState.IsValid)
            {
                Users model = _mapper.Map<Users>(viewmodel);

                if (model.Id == 0)
                {
                    Users save = await _usersInterfaces.Register(model); 
                }
            } 
            return View();
        }
    }
}
