using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BEL;
using BLL;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class WordsController : ApiController
    {
        // GET api/<controller>
        [Route("api/Words/Get")]
        [HttpGet]
        public HttpResponseMessage GetWords()
        {
            var rs = WordsService.Get();

            return Request.CreateResponse(HttpStatusCode.OK, rs);
        }

        

        // POST api/<controller>
        [Route("api/Words/Add")]
        [HttpPost]
        public HttpResponseMessage AddWords(WordsModel words)
        {
            WordsService.Add(words);
            return Request.CreateResponse(HttpStatusCode.Created,"words added");

        }

        
    }
}