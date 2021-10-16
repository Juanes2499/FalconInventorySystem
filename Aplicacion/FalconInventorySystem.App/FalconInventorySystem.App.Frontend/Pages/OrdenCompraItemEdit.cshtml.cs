using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;


namespace FalconInventorySystem.App.Frontend.Pages
{
    public class OrdenCompraItemEditModel : PageModel
    {
        private readonly IRepositoryPurchaseOrder repositoryPurchaseOrder;
        private readonly IRepositoryPurchaseOrderItem repositoryPurchaseOrderItem;
        private readonly IRepositorySupplier repositorySupplier;
        private readonly IRepositoryProduct repositoryProduct;
        private readonly IRepositoryState repositoryState;

        [TempData]
        public int PurchaseOrderID { get; set; } = 0;
        [BindProperty]
        public PurchaseOrderItem PurchaseOrderItem { get; set; }
        public Product Product { get; set; }
        public State State { get; set; }


        public List<PurchaseOrderItem> PurchaseOrderItemsList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<State> StateList { get; set; }

        public OrdenCompraItemEditModel(
            IRepositoryPurchaseOrderItem repositoryPurchaseOrderItem,
            IRepositoryProduct repositoryProduct,
            IRepositoryState repositoryState
        )
        {
            this.repositoryPurchaseOrderItem = repositoryPurchaseOrderItem;
            this.repositoryProduct = repositoryProduct;
            this.repositoryState = repositoryState;
        }

        public IEnumerable<Product> GetProducts()
        {
            var productList = repositoryProduct.GetAllProducts();
            return productList;
        }

        public IEnumerable<State> GetStates()
        {
            var stateList = repositoryState.GetAllStates();
            return stateList;
        }

        //public PurchaseOrderItem GetPurchaseOrderItemsById(int id)
        //{
        //    var purchaseOrderItem = repositoryPurchaseOrderItem.GetPurchaseOrderItemById(id);
        //    return purchaseOrderItem;
        //}

        public IActionResult OnGet(int? purchaseOrderItemId)
        {
            if (purchaseOrderItemId.HasValue)
            {
                PurchaseOrderItem = repositoryPurchaseOrderItem.GetPurchaseOrderItemById(purchaseOrderItemId.Value);
            }
            else
            {
                PurchaseOrderItem = new PurchaseOrderItem();
            }

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            return Page();
        }

        //public IActionResult OnPostOrdenCompra()
        //{
        //    var newPurchaseOrder = PurchaseOrder;
        //    var ordenCompraCreated = repositoryPurchaseOrder.CreatePurchaseOrder(newPurchaseOrder);
        //    HttpContext.Session.SetInt32("PurchaseOrderID", ordenCompraCreated.Id);

        //    SupplierList = new List<Supplier>();
        //    SupplierList.AddRange(GetSuppliers());

        //    ProductList = new List<Product>();
        //    ProductList.AddRange(GetProducts());

        //    StateList = new List<State>();
        //    StateList.AddRange(GetStates());

        //    PurchaseOrderItemsList = new List<PurchaseOrderItem>();

        //    int POI = (int)HttpContext.Session.GetInt32("PurchaseOrderID");
        //    if (POI != 0)
        //    {
        //        PurchaseOrderItemsList.AddRange(GetPurchaseOrderItemsByPurchaseOrderId(POI));
        //    }

        //    return Page();
        //}

        //public void OnPostOrdenCompraItem()
        //{
        //    PurchaseOrderItem.PurchaseOrderId = (int)HttpContext.Session.GetInt32("PurchaseOrderID");
        //    repositoryPurchaseOrderItem.CreatePurchaseOrderItem(PurchaseOrderItem);

        //    SupplierList = new List<Supplier>();
        //    SupplierList.AddRange(GetSuppliers());

        //    ProductList = new List<Product>();
        //    ProductList.AddRange(GetProducts());

        //    StateList = new List<State>();
        //    StateList.AddRange(GetStates());

        //    PurchaseOrderItemsList = new List<PurchaseOrderItem>();
        //    int POI = (int)HttpContext.Session.GetInt32("PurchaseOrderID");
        //    if (POI != 0)
        //    {
        //        PurchaseOrderItemsList.AddRange(GetPurchaseOrderItemsByPurchaseOrderId(POI));
        //    }
        //}
    }
}
