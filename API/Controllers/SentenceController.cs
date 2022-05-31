using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using BEL;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SentenceController : ApiController
    {
        // GET api/<controller>
        [Route("api/Sententce/Get")]
        [HttpGet]
        public HttpResponseMessage GetSentence()
        {
            

            try
            {
                var rs = SentenceService.Get();

                return Request.CreateResponse(HttpStatusCode.OK, rs);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, "Fail to Get");
            }
        }




    }
}