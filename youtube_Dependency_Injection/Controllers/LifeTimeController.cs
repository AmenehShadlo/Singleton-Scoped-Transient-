using Microsoft.AspNetCore.Mvc;
using youtube_Dependency_Injection.Services;

namespace youtube_Dependency_Injection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifeTimeController : ControllerBase
    {
        private readonly ILifeTimeService _lifeTimeService1;

        private readonly ILifeTimeService _lifeTimeService2;

        public LifeTimeController(ILifeTimeService lifeTimeService1, ILifeTimeService lifeTimeService2)
        {
            _lifeTimeService1 = lifeTimeService1;
            _lifeTimeService2 = lifeTimeService2;
        }

        [HttpGet("getlifetimes")]
        public ActionResult<List<LifeTime>> GetLifeTimes()
        {
            _lifeTimeService1.AddToLifeTime();
            _lifeTimeService2.AddToLifeTime();
            return _lifeTimeService2.GetLifeTimes();
        }

    }
}
