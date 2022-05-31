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
        public List<WordsModel> Get()
        {
            return WordsService.Get();
        }

        

        // POST api/<controller>
        [Route("api/Words/Add")]
        [HttpPost]
        public void Add([FromBody] WordsModel words)
        {
            WordsService.Add(words);
        }

        
    }
}