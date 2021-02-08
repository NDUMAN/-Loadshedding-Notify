using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PushNotify.Controllers
{
    public class ValuesController : ApiController
    {
        static async Task<string> Pusher()
        {

            using (var client = new HttpClient())
            {
                var resp = await client.GetStringAsync("http://loadshedding.eskom.co.za/LoadShedding/getstatus"); // 2

                //string Notification = "";

                if (resp== "1")
                {
                    resp = "No Loadshedding Today";
                }
                else if(resp== "2")
                {
                    resp = "Stage 1 Load shedding Today";
                }
                else if (resp == "3")
                {
                    resp = "Stage 2 Load shedding Today";
                }
                else if (resp == "4")
                {
                    resp = "Stage 3 Load shedding Today";
                }
                else if (resp == "5")
                {
                    resp = "Stage 4 Load shedding Today";
                }
                else if (resp == "6")
                {
                    resp = "Stage 5 Load shedding Today";
                }
                else if (resp == "7")
                {
                    resp = "Stage 6 Load shedding Today";
                }
                else if (resp == "8")
                {
                    resp = "Stage 7 Load shedding Today";
                }
                else if (resp == "9")
                {
                    resp = "Stage 8 Load shedding Today";
                }

                return resp;
            }
            

        }
        // GET api/values
        [Route("api/values/6")]
        public IEnumerable<string> Get()
        {
           

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("api/values")]
        public async Task<string> Gets()
        {

            return await Pusher();
            //return "value";
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
}
