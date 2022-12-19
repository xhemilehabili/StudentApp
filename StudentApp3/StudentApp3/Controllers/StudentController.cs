using Microsoft.AspNetCore.Mvc;
using StudentApp3.Models;
using StudentApp3.VM;

namespace StudentApp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            //Note: Merren te dhenat nga databaza

            var allStudents = new List<Models.Student>()
            {
                new Models.Student()
                {
                    Id = 1,
                    FirstName = "Student 1",
                    LastName = "Student 1",
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    GraduationYear = 2023,
                    IsActive = true,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                },
                new Models.Student()
                {
                    Id = 2,
                    FirstName = "Student 2",
                    LastName = "Student 2",
                    DateOfBirth = DateTime.Now.AddYears(-21),
                    GraduationYear = 2023,
                    IsActive = true,
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                }
            };
            return Ok(allStudents);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            var studentcontroller = new Models.Student();

            student.Id = 1;

            student.DateCreated = DateTime.UtcNow;
            student.DateUpdated = null;

            return Created("", student);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            var student = new Models.Student()
            {
                Id = 1,
                FirstName = "Serxhina",
                LastName = "Rrahmani",
                GraduationYear = 2023,
                IsActive = true,
                DateOfBirth = DateTime.Now.AddYears(-20),
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromBody] Models.Student student, int id)
        {

            var studentcontroller = new Models.Student()
            {
                Id = 1,
                FirstName = "Serxhina",
                LastName = "Rrahmani",
                GraduationYear = 2023,
                IsActive = true,
                DateOfBirth = DateTime.Now.AddYears(-20),

                DateCreated = DateTime.UtcNow,
                DateUpdated = null
            };

            student.FirstName = student.FirstName;
            student.LastName = student.LastName;
            student.GraduationYear = student.GraduationYear;
            student.DateOfBirth = DateTime.Now.AddYears(-20);

            return Ok($"Student with id = {id} was updated");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {

            return Ok($"Student with id {id} deleted");
        }



    }

}
