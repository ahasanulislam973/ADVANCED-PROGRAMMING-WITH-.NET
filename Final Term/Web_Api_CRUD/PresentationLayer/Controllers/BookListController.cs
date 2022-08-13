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
    public class BookListController : ApiController
    {
        

        [Route("api/BookList/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = BookListService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/BookList/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = BookListService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/BookList/create")]
        [HttpPost]
        public HttpResponseMessage Create(BookListModel n)
        {
            var data = BookListService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/BookList/update")]
        [HttpPost]



        public HttpResponseMessage Update(BookListModel n)
        {
            var data = BookListService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/BookList/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = BookListService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
