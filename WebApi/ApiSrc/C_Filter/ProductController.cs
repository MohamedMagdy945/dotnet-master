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
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid product id!");

            return Ok(new { Id = id, Name = "Product " + id });
        }
    }
}
