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
    public class CoursesController : ApiController
    {
        private static Teacher[] teachers = new Teacher[]
        {
            new Teacher { id = 1, avatarurl = "Images/author-image1.jpg", name = "Mark Wilson", slogan = "I love Teaching", facebook = "https://www.facebook.com", twitter="https://twitter.com/", google = "", instagram = "https://instagram.com", email = "", linkedin = "" },
            new Teacher { id = 2, avatarurl = "Images/author-image2.jpg", name = "Catherine", slogan = "Education is the key!", facebook = "", twitter="", google = "https://www.google.com", instagram = "https://instagram.com", email = "", linkedin = "" },
            new Teacher { id = 3, avatarurl = "Images/author-image3.jpg", name = "Jessie Ca", slogan = "I like Online Courses", facebook = "", twitter="https://twitter.com/", google = "", instagram = "", email = "test@test.com", linkedin = "" },
            new Teacher { id = 4, avatarurl = "Images/author-image4.jpg", name = "Andrew Berti", slogan = "Learning is fun", facebook = "", twitter="https://twitter.com/", google = "https://www.google.com", instagram = "", email = "", linkedin = "https://linkedin.com" }
        };

        private Course[] courses = new Course[]
        {
            new Course { id = 1, image = "Images/courses-image1.jpg", date = new DateTime(2020, 8, 18), title = "Social Media Management", description = "Social media management is the process of managing your online presence on social media platforms", duration = 8, teacher = teachers[0] },
            new Course { id = 2, image = "Images/courses-image2.jpg", date = new DateTime(2020, 7, 03), title = "Graphic & Web Design", description = "Web & Graphic Design, is the creation of graphics, typography, graphs, and images to communicate an idea.", duration = 16, teacher = teachers[1] },
            new Course { id = 3, image = "Images/courses-image3.jpg", date = new DateTime(2020, 5, 12), title = "Marketing Communication", description = "Marketing Communication can be defined as the methodologies and tactics adopted by the companies.", duration = 12, teacher = teachers[2] },
            new Course { id = 4, image = "Images/courses-image4.jpg", date = new DateTime(2020, 3, 14), title = "Summer Kids", description = "Book after school classes and camps near you with one registration form.", duration = 36, teacher = teachers[3]  },
            new Course { id = 5, image = "Images/courses-image5.jpg", date = new DateTime(2020, 11, 01), title = "Business & Management", description = "Business and Management are the disciplines devoted to organizing, analyzing, and planning various types of business opera", duration = 8, teacher = teachers[1] },
        };

        // GET: api/Course
        [ResponseType(typeof(IEnumerable<Course>))]

        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET: api/Course/5
        public IHttpActionResult Get(int id)
        {
            var course = courses.FirstOrDefault((c) => c.id == id);
            if (course == null)
            {
                return null;
            }
            return Ok(course);
        }

        // POST: api/Course
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Course/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
        }
    }
}
