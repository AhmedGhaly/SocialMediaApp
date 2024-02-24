using Domain_Layer;
using Domain_Layer.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace SocialMediaApp.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public TestController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult> test()
        {
            var r = await unitOfWork.Users.GetByIdAsync(1);
            return Ok(r);
        }
    }
}
