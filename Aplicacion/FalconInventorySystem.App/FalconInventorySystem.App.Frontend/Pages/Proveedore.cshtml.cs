using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class ProveedorModel : PageModel
    {
        private readonly ILogger<ProveedorModel> _logger;

        public ProveedorModel(ILogger<ProveedorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
