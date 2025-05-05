using KudVenKat_Asp.Net_Web_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace KudVenKat_Asp.Net_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name = "GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return Ok(StudentRepasitory.Students);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            if (id <= 0) // 404 - not found - client error
                return BadRequest($"Id must be greater then 0");

            var student = StudentRepasitory.Students.Where(i => i.Id == id).FirstOrDefault();

            if (student == null)
                return BadRequest($"The student with Id = {id} not found !");

            return student;
        }

        [HttpGet("{s:alpha}", Name = "GetStudentByName")]
        //[Route("name")]
        public ActionResult<Student> GetStudentByName(string name)
        {
            if (string.IsNullOrEmpty(name)) // 404 - not found - client error
                return BadRequest($"Name null bo'lishi mumkin emas !");

            var student = StudentRepasitory.Students.Where(i => i.StudentName == name).FirstOrDefault();

            if (student == null)
                return BadRequest($"The student with Name = {name} not found !");

            return student;
        }

        [HttpDelete("{id:int}")]                    
        public ActionResult<bool> DeleteStudent(int id)
        {
            if (id <= 0) // 404 - not found - client error
                return BadRequest($"Id must be greater then 0");

            var student = StudentRepasitory.Students.Where(i => i.Id == id).FirstOrDefault();

            if (student == null)
                return BadRequest($"The student with Id = {id} not found !");

            return true;

        }

    }
}
