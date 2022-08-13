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
    public class Borrowed_BookController : ApiController
    {
        [Route("api/Borrowed_Book/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = Borrowed_BookService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/Borrowed_Book/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = Borrowed_BookService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/Borrowed_Book/create")]
        [HttpPost]
        public HttpResponseMessage Create(Borrowed_BookModel n)
        {
            var data = Borrowed_BookService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Borrowed_Book/update")]
        [HttpPost]
        public HttpResponseMessage Update(Borrowed_BookModel n)
        {
            var data = Borrowed_BookService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Borrowed_Book/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = Borrowed_BookService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
