using EventApplication.Models;
using EventApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace EventApplication.Controllers
{
    public class SearchController : Controller
    {
        SqlCommand command = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataReader dr;

        List<Events> searchEvents = new List<Events>();

        [BindProperty]
        public SearchVM Model { get; set; }
        
        //Function for searching the database for certain events
        private void searchData()
        {
            try
            {
                con.Open();
                command.Connection = con;
                command.CommandText = "SELECT TOP (1000) [Name],[Location],[Time],[Date],[Status],[Category] FROM [dbo].[Events] WHERE Category ='" + Model.Category + "'";
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    searchEvents.Add(new Events()
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
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Search(SearchVM Response)
        {
            if (ModelState.IsValid)
            {
                //searchData();
                return View("SearchResults", searchEvents);
            }
            else
            {
                return View();
            }
        }
    }
}
