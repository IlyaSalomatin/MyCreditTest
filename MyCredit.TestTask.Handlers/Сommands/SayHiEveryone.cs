using MyCredit.TestTask.Models.Interfaces;

namespace MyCredit.TestTask.Handlers.Сommands
{
    public class SayHiEveryone : IGreeter
    {
        public string SayHello()
        {
            return "Hi Everyone!";
        }
    }
}