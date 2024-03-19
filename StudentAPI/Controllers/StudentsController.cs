using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private Dictionary<int, Student> students;

        public StudentsController(Dictionary<int, Student> students)
        {
            this.students = students;
        }

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return students.Values.ToList();
        }
    }
}
