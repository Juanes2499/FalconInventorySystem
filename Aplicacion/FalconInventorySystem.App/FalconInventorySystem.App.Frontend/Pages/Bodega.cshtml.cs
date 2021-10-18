using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class BodegaModel : PageModel
    {
       private readonly IRepositoryWarehouse repositoryWarehouse;

        [BindProperty]
        public Warehouse WareHouse { get; set; }
        public List<Warehouse> WareHouseList { get; set; }

        public BodegaModel(IRepositoryWarehouse repositoryWarehouse)
        {
            this.repositoryWarehouse = repositoryWarehouse;
        }

        public IEnumerable<Warehouse> GetWareHouses()
        {
            var warehouseList = repositoryWarehouse.GetAllWarehouses();
            return warehouseList;
        }

        public void OnGet()
        {
            WareHouseList = new List<Warehouse>();
            WareHouseList.AddRange(GetWareHouses());
        }

        public IActionResult OnPost()
        {
            var newWareHouse = WareHouse;
            var WareHouseCreated = repositoryWarehouse.CreateWarehouse(newWareHouse);
            WareHouse = null;
            WareHouseList = new List<Warehouse>();
            WareHouseList.AddRange(GetWareHouses());
            return RedirectToPage("Bodega");
        }
    }
}
