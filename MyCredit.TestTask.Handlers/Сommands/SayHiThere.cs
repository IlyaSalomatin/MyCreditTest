using MyCredit.TestTask.Models.Interfaces;

namespace MyCredit.TestTask.Handlers.Сommands
{
    public class SayHiThere :IGreeter
    {
        public string SayHello()
        {
            return "Hi There!";
        }
    }
}