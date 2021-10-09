using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class VentasModel : PageModel
    {
        private readonly ILogger<VentasModel> _logger;

        public VentasModel(ILogger<VentasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
