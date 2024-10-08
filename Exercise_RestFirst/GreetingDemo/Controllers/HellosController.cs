using Microsoft.AspNetCore.Mvc;

namespace GreetingDemo.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class HellosController : ControllerBase {

        [HttpGet]
        // api/hellos
        public ActionResult<string> Index() {
            return Ok("Hello");
        }

        [HttpGet]
        [Route("{name}")]
        // api/hellos/Hans
        public ActionResult<string> Get(string name)
        {
            return Ok($"Hello {name}");
        }

        // Fix ambiguity using route constraints (problem -> what types are name, times, nickName etc.?)
        // https://learn.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
        [HttpGet]
        [Route("{name}/{times:int}")]
        // api/hellos/Hans/7
        public ActionResult<string> Get(string name, int times)
        {
            string returnStr = $"Hello {name} * {times}";
            return Ok(returnStr);
        }
        
        [HttpGet]
        [Route("{name}/{nickName}")]
        // api/hellos/Hans/Nickname
        public ActionResult<string> Get(string name, string nickname)
        {
            string returnStr = $"Hi {name} aka {nickname}";
            return Ok(returnStr);
        }
        
        // api/hellos
        [HttpPost]
        public void PostSomething([FromBody] string inVal) { }

    }
}
