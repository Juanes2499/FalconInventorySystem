using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class AlmacenamientoModel : PageModel
    {
        private readonly ILogger<AlmacenamientoModel> _logger;

        public AlmacenamientoModel(ILogger<AlmacenamientoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
