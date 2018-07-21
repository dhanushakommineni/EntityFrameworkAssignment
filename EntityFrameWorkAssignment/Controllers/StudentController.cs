using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWorkAssignment.DataContext;
using EntityFrameWorkAssignment.Model;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWorkAssignment.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (var StudentContext = new StudentData())
            {
                var StudentsList = new List<StudentModel>();
                StudentsList = StudentContext.StudentsDetails.ToList();
                return Ok(StudentsList);
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody]StudentModel StudentObject)
        {
            using (var StudentContext = new StudentData())
            {
                StudentContext.StudentsDetails.Add(StudentObject);
                StudentContext.SaveChanges();
            }
            return Ok("StudentAdded");
        }
        [HttpPut]
        public ActionResult Put([FromBody]StudentModel StudentObject)
        {
            using (var StudentContext = new StudentData())
            {
                StudentContext.StudentsDetails.Update(StudentObject);
                StudentContext.SaveChanges();
            }
            return Ok("StudentUpdated");
        }
        [HttpDelete]
        public ActionResult Delete([FromBody]StudentModel StudentObject)
        {
            using (var StudentContext = new StudentData())
            {
                StudentContext.StudentsDetails.Remove(StudentObject);
                StudentContext.SaveChanges();
            }
            return Ok("StudentDeleted");
        }
    }
}