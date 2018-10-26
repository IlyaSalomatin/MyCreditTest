using System.Web.Http;
using MyCredit.TestTask.Models.Interfaces;

namespace MyCredit.TestTask.Controllers
{
    public class HelloController : ApiController
    {
        private readonly IGreeter _iGreeter;
        
        public HelloController(IGreeter iGreeter) 
        {
            _iGreeter = iGreeter;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("hello")]
        public string Get()
        {
            return _iGreeter.SayHello();
        }
    }
}
