using Swashbuckle.Swagger;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApiSwaggerLab.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// 這是取得值的API
        /// </summary>
        /// <returns></returns>
        [SwaggerOperationFilter(typeof(ImageResponseType))]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    
    }


    internal class ImageResponseType : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            operation.produces.Clear();
            operation.produces.Add("image/jpg");
        }
    }
}
