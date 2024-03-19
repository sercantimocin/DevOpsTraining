using StudentAPI.Controllers;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.UnitTests
{
    public class StudentControllerTest
    {
        [Fact]
        public void GetAllStudentsAsync()
        {
            var student = new Student() { Id = 1, Name = "John" };

            Dictionary<int,Student> students = new Dictionary<int,Student>();
            students.Add(student.Id, student);

            var studentController = new StudentsController(students);

            var result = studentController.GetAllStudents();

            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(student,result.First());
        }
    }
}
