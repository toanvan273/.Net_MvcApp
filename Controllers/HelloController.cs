using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers

public string Index()
{
    public class HelloController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

          // GET: HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method";
        }
    }
}