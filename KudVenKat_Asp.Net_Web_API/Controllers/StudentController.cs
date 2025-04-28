using KudVenKat_Asp.Net_Web_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KudVenKat_Asp.Net_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = 1,
                    StudentName = "Ali",
                    Email = "Example@gmail.com",
                    Address = "Tashkent"
                },
                new Student
                {
                    Id = 1,
                    StudentName = "Ali",
                    Email = "Example@gmail.com",
                    Address = "Tashkent"
                }

            };
        }
    }
}
