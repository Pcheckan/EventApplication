using EventApplication.Interfaces;
using EventApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace EventApplication.Controllers
{
    public class EventController : Controller
    {
        SqlCommand command = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;

        List<Events> events = new List<Events>();
        List<Events> searchEvents = new List<Events>();

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

        // page load for event recommend
        public async Task<IActionResult> EventRecomended()
        {
            var SessionData = JsonConvert.DeserializeObject<Users>(_session.GetString("AuthCertificate"));
            if (SessionData != null)
            {
                Users data = await _usersInterfaces.GetProfileDataByEmail(SessionData.Email);
                RecommendEvents(data);

                con.ConnectionString = "Data Source=eventapplication-server.database.windows.net;Initial Catalog=eventapplication-DB;Persist Security Info=True;User ID=eventapplication-server-admin;Password=WebAppPassword!@#";

                FetchData();
                return View(events);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        // fetch data for event recommend
        private void FetchData()
        {

            try
            {
                con.Open();
                command.Connection = con;
                command.CommandText = "SELECT TOP (1000) [Name],[Location],[Time],[Date],[Status],[Category] FROM [dbo].[Events]";
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    searchEvents.Add(new Events()
                    {
                        Name=dr["Name"].ToString(),
                        Location=dr["Location"].ToString(),
                        Time=dr["Time"].ToString(),
                        Date=dr["Date"].ToString(),
                       Status=dr["Status"].ToString(),
                        Category=dr["Category"].ToString(),


                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Event Search functionality
        public string SearchTerm { get; set; }
        private void searchData()
        {
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandText = "SELECT TOP (1000) [Name],[Location],[Time],[Date],[Status],[Category] FROM [dbo].[Events] WHERE Category ='" + SearchTerm+"'";
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    events.Add(new Events()
                    {
                        Name = dr["Name"].ToString(),
                        Location = dr["Location"].ToString(),
                        Time = dr["Time"].ToString(),
                        Date = dr["Date"].ToString(),
                        Status = dr["Status"].ToString(),
                        Category = dr["Category"].ToString(),


                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        // On page load for EventSearch
        public IActionResult EventSearch()
        {
            con.ConnectionString = "Data Source=eventapplication-server.database.windows.net;Initial Catalog=eventapplication-DB;Persist Security Info=True;User ID=eventapplication-server-admin;Password=WebAppPassword!@#";

            searchData();
            return View(searchEvents);
        }
        public void RecommendEvents(Users data)
        {
 
        }


    }
}
