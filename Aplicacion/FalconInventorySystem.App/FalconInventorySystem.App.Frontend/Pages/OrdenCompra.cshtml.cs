using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class OrdenCompraModel : PageModel
    {
        private readonly ILogger<OrdenCompraModel> _logger;

        public OrdenCompraModel(ILogger<OrdenCompraModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
