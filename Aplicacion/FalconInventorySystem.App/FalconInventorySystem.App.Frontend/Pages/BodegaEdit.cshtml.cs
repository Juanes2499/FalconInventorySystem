using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;

namespace FalnconInventorySystem.App.Frontend.Pages
{
    public class BodegaEditModel : PageModel
    {
        private readonly IRepositoryWarehouse repositoryWarehouse;

        [BindProperty]
        public Warehouse WareHouse { get; set; }
        public List<Warehouse> WareHouseList { get; set; }

        public BodegaEditModel(IRepositoryWarehouse repositoryWarehouse)
        {
            this.repositoryWarehouse = repositoryWarehouse;
        }

        public IActionResult OnGet(int wareHouseId)
        {
            WareHouse = repositoryWarehouse.GetWarehouseById(wareHouseId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryWarehouse.UpdateWarehouse(WareHouse);
            return RedirectToPage("./Bodega");
        }
    }
}

