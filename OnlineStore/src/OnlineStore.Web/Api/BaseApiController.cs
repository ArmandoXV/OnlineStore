using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
