using Domain_Layer;
using Domain_Layer.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Service_Layer.ServiceAbstraction;

namespace SocialMediaApp.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public TestController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        [HttpGet]
        public async Task<ActionResult> test()
        {
            
            return Ok(serviceManager.UserService.getAllUsers());
        }
    }
}
