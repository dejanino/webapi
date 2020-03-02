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
    public class TeachersController : ApiController
    {
        private Teacher[] teachers = new Teacher[]
        {
            new Teacher { id = 1, avatarurl = "Images/author-image1.jpg", name = "Mark Wilson", slogan = "I love Teaching", facebook = "https://www.facebook.com", twitter="https://twitter.com/", google = "", instagram = "https://instagram.com", email = "", linkedin = "" },
            new Teacher { id = 2, avatarurl = "Images/author-image2.jpg", name = "Catherine", slogan = "Education is the key!", facebook = "", twitter="", google = "https://www.google.com", instagram = "https://instagram.com", email = "", linkedin = "" },
            new Teacher { id = 3, avatarurl = "Images/author-image3.jpg", name = "Jessie Ca", slogan = "I like Online Courses", facebook = "", twitter="https://twitter.com/", google = "", instagram = "", email = "test@test.com", linkedin = "" },
            new Teacher { id = 4, avatarurl = "Images/author-image4.jpg", name = "Andrew Berti", slogan = "Learning is fun", facebook = "", twitter="https://twitter.com/", google = "https://www.google.com", instagram = "", email = "", linkedin = "https://linkedin.com" }
        };

        // GET: api/Teachers
        [ResponseType(typeof(IEnumerable<Teacher>))]

        public IEnumerable<Teacher> Get()
        {
            return teachers;
        }

        // GET: api/Teachers/5
        public IHttpActionResult Get(int id)
        {
            var teacher = teachers.FirstOrDefault((c) => c.id == id);
            if (teacher == null)
            {
                return null;
            }
            return Ok(teacher);
        }

        // POST: api/Teachers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Teachers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Teachers/5
        public void Delete(int id)
        {
        }
    }
}
