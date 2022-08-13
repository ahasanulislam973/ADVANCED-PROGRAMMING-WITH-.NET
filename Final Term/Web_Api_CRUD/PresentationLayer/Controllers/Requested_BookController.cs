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
    public class Requested_BookController : ApiController
    {
        [Route("api/Requested_Book/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = Requested_BookService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/Requested_Book/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = Requested_BookService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/Requested_Book/create")]
        [HttpPost]
        public HttpResponseMessage Create(Requested_BookModel n)
        {
            var data = Requested_BookService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Requested_Book/update")]
        [HttpPost]
        public HttpResponseMessage Update(Requested_BookModel n)
        {
            var data = Requested_BookService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Requested_Book/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = Requested_BookService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
