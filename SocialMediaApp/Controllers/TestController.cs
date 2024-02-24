using Domain_Layer.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace SocialMediaApp.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult test()
        {
            throw new CustomException("this is a error");
        }
    }
}
