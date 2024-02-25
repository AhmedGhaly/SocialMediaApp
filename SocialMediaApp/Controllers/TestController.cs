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
            //throw new NotImplementedException();
            
            return Ok(serviceManager.UserService.getAllUsers());
        }


        [HttpGet("GetById/{id}")]
        public async Task<ActionResult> getById(int id)
        {
            if (id == 0)
                throw new CustomException("this id not found ...");

            return Ok(serviceManager.UserService.getById(id));
        }

    }
}
