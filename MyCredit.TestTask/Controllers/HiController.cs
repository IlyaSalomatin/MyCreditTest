using System.Web.Http;
using MyCredit.TestTask.Models.Interfaces;

namespace MyCredit.TestTask.Controllers
{
    public class HiController : ApiController
    {
        private readonly IGreeter _iGreeter;

        public HiController(IGreeter iGreeter)
        {
            _iGreeter = iGreeter;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("hi")]
        public string Get()
        {
            return _iGreeter.SayHello();
        }
    }
}
