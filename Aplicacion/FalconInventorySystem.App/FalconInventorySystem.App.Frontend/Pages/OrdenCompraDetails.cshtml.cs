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
    public class OrdenCompraDetailsModel : PageModel
    {
        private readonly IRepositoryPurchaseOrder repositoryPurchaseOrder;
        private readonly IRepositoryPurchaseOrderItem repositoryPurchaseOrderItem;
        private readonly IRepositorySupplier repositorySupplier;
        private readonly IRepositoryProduct repositoryProduct;
        private readonly IRepositoryState repositoryState;

        [TempData]
        public int PurchaseOrderID { get; set; } = 0; 
        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }
        [BindProperty]
        public PurchaseOrderItem PurchaseOrderItem { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
        public State State { get; set; }


        public List<PurchaseOrder> PurchaseOrderList { get; set; }
        public List<PurchaseOrderItem> PurchaseOrderItemsList { get; set; }
        public List<Supplier> SupplierList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<State> StateList { get; set; }

        public OrdenCompraDetailsModel(
            IRepositoryPurchaseOrder repositoryPurchaseOrder,
            IRepositoryPurchaseOrderItem repositoryPurchaseOrderItem,
            IRepositorySupplier repositorySupplier,
            IRepositoryProduct repositoryProduct,
            IRepositoryState repositoryState
        )
        {
            this.repositoryPurchaseOrder = repositoryPurchaseOrder;
            this.repositoryPurchaseOrderItem = repositoryPurchaseOrderItem;
            this.repositorySupplier = repositorySupplier;
            this.repositoryProduct = repositoryProduct;
            this.repositoryState = repositoryState;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            var supplierList = repositorySupplier.GetSuppliersAll();
            return supplierList;
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

        public IEnumerable<PurchaseOrderItem> GetPurchaseOrderItemsByPurchaseOrderId(int id)
        {
            var purchaseOrderItemList = repositoryPurchaseOrderItem.GetPurchaseOrderItemByPurchaseOrderId(id);
            return purchaseOrderItemList;
        }

        public IActionResult OnGet(int ? PurchaseOrderId)
        {
            if (PurchaseOrderId.HasValue)
            {
                PurchaseOrder = repositoryPurchaseOrder.GetPurchaseOrderById(PurchaseOrderId.Value);
                HttpContext.Session.SetInt32("PurchaseOrderID", PurchaseOrder.Id);
            }
            else
            {
                PurchaseOrder = new PurchaseOrder();
            }

            SupplierList = new List<Supplier>();
            SupplierList.AddRange(GetSuppliers());

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            PurchaseOrderItemsList = new List<PurchaseOrderItem>();
            if (PurchaseOrderId.HasValue)
            {
                PurchaseOrderItemsList.AddRange(GetPurchaseOrderItemsByPurchaseOrderId(PurchaseOrderId.Value));
            }

            return Page();
        }

        public IActionResult OnPostOrdenCompra()
        {
            var newPurchaseOrder = PurchaseOrder;
            var ordenCompraCreated = repositoryPurchaseOrder.CreatePurchaseOrder(newPurchaseOrder);
            HttpContext.Session.SetInt32("PurchaseOrderID", ordenCompraCreated.Id);

            SupplierList = new List<Supplier>();
            SupplierList.AddRange(GetSuppliers());

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            PurchaseOrderItemsList = new List<PurchaseOrderItem>();

            int POI = (int)HttpContext.Session.GetInt32("PurchaseOrderID");
            if (POI != 0)
            {
                PurchaseOrderItemsList.AddRange(GetPurchaseOrderItemsByPurchaseOrderId(POI));
            }

            return Page();
        }

        public void OnPostOrdenCompraItem()
        {
            PurchaseOrderItem.PurchaseOrderId = (int)HttpContext.Session.GetInt32("PurchaseOrderID");
            PurchaseOrderItem.StateId = 2;
            repositoryPurchaseOrderItem.CreatePurchaseOrderItem(PurchaseOrderItem);

            SupplierList = new List<Supplier>();
            SupplierList.AddRange(GetSuppliers());

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            PurchaseOrderItemsList = new List<PurchaseOrderItem>();
            int POI = (int)HttpContext.Session.GetInt32("PurchaseOrderID");
            if (POI != 0)
            {
                PurchaseOrderItemsList.AddRange(GetPurchaseOrderItemsByPurchaseOrderId(POI));
            }
        }
    }
}
