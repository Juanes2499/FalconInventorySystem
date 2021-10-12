using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class LoteModel : PageModel
    {
        private readonly ILogger<LoteModel> _logger;

        public LoteModel(ILogger<LoteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
