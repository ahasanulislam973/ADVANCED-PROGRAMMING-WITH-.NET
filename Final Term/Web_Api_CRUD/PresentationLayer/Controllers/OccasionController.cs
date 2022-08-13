using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class OccasionController : ApiController
    {
        [Route("api/Occasion/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = OccasionService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/Occasion/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = OccasionService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/Occasion/create")]
        [HttpPost]
        public HttpResponseMessage Create(OccasionModel n)
        {
            var data = OccasionService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Occasion/update")]
        [HttpPost]



        public HttpResponseMessage Update(OccasionModel n)
        {
            var data = OccasionService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Occasion/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = OccasionService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
