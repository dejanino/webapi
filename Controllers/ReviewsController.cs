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
    public class ReviewsController : ApiController
    {
        private static Student[] students = new Student[]
        {
            new Student { id = 1, imageurl = "Images/tst-image1.jpg", name = "Jackson", position = "Shopify Developer" },
            new Student { id = 2, imageurl = "Images/tst-image2.jpg", name = "Camila", position = "Marketing Manager" },
            new Student { id = 3, imageurl = "Images/tst-image3.jpg", name = "Barbie", position = "Art Director" },
            new Student { id = 4, imageurl = "Images/tst-image4.jpg", name = "Andrio", position = "Web Developer" }
        };

        private Review[] reviews = new Review[]
        {
            new Review { id = 1, reviewtext = "You really do help young creative minds to get quality education and professional job search assistance. I’d recommend it to everyone!", grade = 3, student = students[0] },
            new Review { id = 2, reviewtext = "Trying something new is exciting! Thanks for the amazing law course and the great teacher who was able to make it interesting.", grade = 5, student = students[1] },
            new Review { id = 3, reviewtext = "Donec erat libero, blandit vitae arcu eu, lacinia placerat justo. Sed sollicitudin quis felis vitae hendrerit.", grade = 4, student = students[2] },
            new Review { id = 4, reviewtext = "Nam eget mi eu ante faucibus viverra nec sed magna. Vivamus viverra sapien ex, elementum varius ex sagittis vel.", grade = 1, student = students[3] }
        };

        // GET: api/Reviews
        [ResponseType(typeof(IEnumerable<Review>))]

        public IEnumerable<Review> Get()
        {
            return reviews;
        }

        // GET: api/Reviews/5
        public IHttpActionResult Get(int id)
        {
            var review = reviews.FirstOrDefault((c) => c.id == id);
            if (review == null)
            {
                return null;
            }
            return Ok(review);
        }

        // POST: api/Review
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Review/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Review/5
        public void Delete(int id)
        {
        }
    }
}
