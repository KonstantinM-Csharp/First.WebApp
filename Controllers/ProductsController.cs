using Firsts.WebApp.Models;
using Firsts.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Firsts.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsService productsService)
        {
            this.ProductsService = productsService;
        }
        public JsonFileProductsService ProductsService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsService.GetProducts();
        }
		[Route("Rate")]
		[HttpGet]
		public ActionResult Get([FromQuery] string ProductId, [FromQuery] int Rating)
		{
            ProductsService.AddRating(ProductId, Rating);
			return Ok();
		}
	}
}
