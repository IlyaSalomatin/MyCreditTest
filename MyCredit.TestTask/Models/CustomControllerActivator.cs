using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using MyCredit.TestTask.Controllers;
using MyCredit.TestTask.Handlers.Сommands;

namespace MyCredit.TestTask.Models
{
    public class CustomControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request,HttpControllerDescriptor controllerDescriptor,Type controllerType)
        {
            var controllerName = controllerDescriptor.ControllerName;
            var body1 = new SayHiEveryone();
            var body2 = new SayHiThere();
            if (controllerName == "Hi") return new HiController(body1);
            return new HelloController(body2);
            
        }
    }
}