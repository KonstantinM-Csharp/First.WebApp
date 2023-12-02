using Firsts.WebApp.Models;
using Firsts.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Firsts.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService ProductsService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductsService productsService)
        {
            _logger = logger;
            ProductsService = productsService;
        }

        public void OnGet()
        {
            Products = ProductsService.GetProducts();
        }
    }
}