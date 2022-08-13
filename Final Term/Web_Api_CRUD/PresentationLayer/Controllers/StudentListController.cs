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
    public class StudentListController : ApiController
    {
        [Route("api/student/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = StudentListService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/student/get/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = StudentListService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/student/create")]
        [HttpPost]
        public HttpResponseMessage Create(StudentListModel n)
        {
            var data = StudentListService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/student/update")]
        [HttpPost]
        public HttpResponseMessage Update(StudentListModel n)
        {
            var data = StudentListService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/student/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = StudentListService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
