using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class ProductoModel : PageModel
    {
        private readonly ILogger<ProductoModel> _logger;

        public ProductoModel(ILogger<ProductoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
