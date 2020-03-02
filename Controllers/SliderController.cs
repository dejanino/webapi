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
    public class SliderController : ApiController
    {
        private Slider[] slides = new Slider[]
        {
            new Slider { id = 1, imageurl = "Images/slider-image1.jpg", title = "Social Media Management", description = "Social media management is the process of managing your online presence on social media platforms", url = "http://www.google.com" },
            new Slider { id = 2, imageurl = "Images/slider-image2.jpg", title = "Graphic & Web Design", description = "Web & Graphic Design, is the creation of graphics, typography, graphs, and images to communicate an idea.", url = "http://www.facebook.com" },
            new Slider { id = 3, imageurl = "Images/slider-image3.jpg", title = "Marketing Communication", description = "Marketing Communication can be defined as the methodologies and tactics adopted by the companies.", url = "http://www.linkedin.com" }
        };

        // GET: api/Slider
        [ResponseType(typeof(IEnumerable<Slider>))]

        public IEnumerable<Slider> Get()
        {
            return slides;
        }

        // GET: api/Slider/5
        public IHttpActionResult Get(int id)
        {
            var slide = slides.FirstOrDefault((c) => c.id == id);
            if (slide == null)
            {
                return null;
            }
            return Ok(slide);
        }

        // POST: api/Slider
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Slider/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Slider/5
        public void Delete(int id)
        {
        }
    }
}
