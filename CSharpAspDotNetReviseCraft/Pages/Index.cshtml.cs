using CSharpAspDotNetReviseCraft.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpAspDotNetReviseCraft.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger JsonFileProductService productService)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}