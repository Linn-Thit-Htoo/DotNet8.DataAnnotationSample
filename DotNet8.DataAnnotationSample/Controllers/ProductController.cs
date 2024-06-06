using DotNet8.DataAnnotationSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.DataAnnotationSample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateProduct([FromBody] ProductModel productModel)
    {
        return Ok(productModel);
    }
}