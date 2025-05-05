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

        [HttpGet("{s:alpha}", Name = "GetStudentByName")]
        //[Route("name")]
        public string GetStudentByName(string name)
        {
            var result = StudentRepasitory.Students.Where(s => s.StudentName == name).FirstOrDefault();
            return result.StudentName;
        }

        [HttpDelete("{id:int}")]
        public bool DeleteStudent(int id)
        {
            var result = StudentRepasitory.Students.FirstOrDefault(c => c.Id == id);
            StudentRepasitory.Students.Remove(result);
            return true;


        }

    }
}
