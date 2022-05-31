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
        public List<SentenceModel> Get()
        {
            return SentenceService.Get();
        }



        // POST api/<controller>
        

        

    }
}