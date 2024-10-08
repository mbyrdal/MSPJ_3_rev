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
        [Route("{name}/{nickName}/{times:int}")]
        // api/hellos/Hans/7
        public ActionResult<string> Get(string name, string nickName, int times)
        {
            string returnStr = $"Hello {name} aka {nickName} {times} times";
            return Ok(returnStr);
        }
        [HttpGet]
        [Route("{name}")]
        // api/hellos/Hans
        public ActionResult<string> Get(string name) {
            return Ok($"Hello {name}");
        }
        [HttpGet] 
        [Route("{name}/{nickName}")]
        public ActionResult<string> Get(string name, string nickName)
        {
            return Ok($"Hello {name} aka {nickName}");
        }
        [HttpGet]
        [Route("{name}/{times:int}")]
        public ActionResult<string> Get(string name, int times)
        {
            return Ok($"Hello {name} {times} times");
        }


        // api/hellos
        [HttpPost]
        public void PostSomething([FromBody] string inVal) { }

    }
}
