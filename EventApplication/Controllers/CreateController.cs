using EventApplication.Models;
using EventApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace EventApplication.Controllers
{

    public class CreateController : Controller
    {
        [BindProperty]
        public EventsVM Model { get; set; }
        public void InsertNewEvent()
        {
            SqlConnection conn = new SqlConnection("Data Source=eventapplication-server.database.windows.net;Initial Catalog=eventapplication-DB;Persist Security Info=True;User ID=eventapplication-server-admin;Password=WebAppPassword!@#");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.CreateNewEvent @Name, @Location, @Time, @Date, @Status, @Category", conn);
                insert.Parameters.AddWithValue("@Name", Model.Name);
                insert.Parameters.AddWithValue("@Location", Model.Location);
                insert.Parameters.AddWithValue("@Time", Model.Time);
                insert.Parameters.AddWithValue("@Date", Model.Date);
                insert.Parameters.AddWithValue("@Status", "Planned");
                insert.Parameters.AddWithValue("@Category", Model.Category);
                conn.Open();
                insert.ExecuteNonQuery();
                conn.Close();

            }
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(EventsVM Response)
        {
            if (ModelState.IsValid)
            {
                SqlConnection conn = new SqlConnection("Data Source=eventapplication-server.database.windows.net;Initial Catalog=eventapplication-DB;Persist Security Info=True;User ID=eventapplication-server-admin;Password=WebAppPassword!@#");
                {
                    SqlCommand insert = new SqlCommand("EXEC dbo.CreateNewEvent @Name, @Location, @Time, @Date, @Status, @Category", conn);
                    insert.Parameters.AddWithValue("@Name", Response.Name);
                    insert.Parameters.AddWithValue("@Location", Response.Location);
                    insert.Parameters.AddWithValue("@Time", Response.Time);
                    insert.Parameters.AddWithValue("@Date", Response.Date);
                    insert.Parameters.AddWithValue("@Status", "Planned");
                    insert.Parameters.AddWithValue("@Category", Response.Category);
                    conn.Open();
                    insert.ExecuteNonQuery();
                    conn.Close();

                }
                return View("Thanks", Response);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Thanks()
        {
            return View();
        }
    }



}
