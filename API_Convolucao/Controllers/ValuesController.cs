using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BibliotecaMatematica;
using Newtonsoft.Json;

namespace API_Convolucao.Controllers
{
    public class ValuesController : ApiController
    {
        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return id.ToString();
        //}

        //// POST api/values
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}

        [HttpGet]
        public string Conv(string data)
        {
            var l_Data = JsonConvert.DeserializeObject<ConvObject>(data);

            return string.Join(", ", Convolucao.Convoluir(l_Data.vetor01, l_Data.vetor02));
        }

    public class ConvObject
        {
            public int[] vetor01 { get; set; }
            public int[] vetor02 { get; set; }
        }
    }
}
