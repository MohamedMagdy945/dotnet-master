using Microsoft.AspNetCore.Mvc;

namespace ApiSrc.C_Filter
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(MyAuthorizationFilter))]
    [ServiceFilter(typeof(MyResourceFilter))]
    [ServiceFilter(typeof(MyActionFilter))]
    [ServiceFilter(typeof(MyResultFilter))]
    [ServiceFilter(typeof(MyExceptionFilter))]
    public class ProductController : ControllerBase
    {

    }
}
