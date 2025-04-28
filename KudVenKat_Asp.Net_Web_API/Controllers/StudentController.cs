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
            return StudentRepasitory.Students;
        }

        [HttpGet("{id:int}")]
        public Student GetStudentById(int id)
        {
            return StudentRepasitory.Students.Where(s => s.Id == id).FirstOrDefault();
        }
    }
}
