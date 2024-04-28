using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMS_DEMO.Controllers
{
    public class BuyerController : ApiController
    {
        [HttpGet]
        [Route("api/buyer/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = BuyerService.GetBuyerById(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/buyer/create")]
        public HttpResponseMessage Create(BuyerDTO b)
        {
            BuyerService.Create(b);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Route("api/buyer/all")]
        public HttpResponseMessage Get()
        {
            var data = BuyerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/buyer/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            BuyerService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPut]
        [Route("api/buyer/update")]
        public HttpResponseMessage Update(BuyerDTO b)
        {
            BuyerService.Update(b);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
