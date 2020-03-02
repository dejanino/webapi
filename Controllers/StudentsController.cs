using SEDCApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace SEDCApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private Student[] students = new Student[]
        {
            new Student { id = 1, imageurl = "Images/tst-image1.jpg", name = "Jackson", position = "Shopify Developer" },
            new Student { id = 2, imageurl = "Images/tst-image2.jpg", name = "Camila", position = "Marketing Manager" },
            new Student { id = 3, imageurl = "Images/tst-image3.jpg", name = "Barbie", position = "Art Director" },
            new Student { id = 4, imageurl = "Images/tst-image4.jpg", name = "Andrio", position = "Web Developer" }
        };

        // GET: api/Students
        [ResponseType(typeof(IEnumerable<Course>))]

        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Students/5
        public IHttpActionResult Get(int id)
        {
            var student = students.FirstOrDefault((c) => c.id == id);
            if (student == null)
            {
                return null;
            }
            return Ok(student);
        }

        // POST: api/Students
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Students/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
        }
    }
}
