using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;


namespace FalnconInventorySystem.App.Frontend.Pages
{
    public class BillOrdeDetailsModel : PageModel
    {
        private readonly IRepositoryBillOrder repositoryBillOrder;
        private readonly IRepositoryBillOrderItem repositoryBillOrderItem;
        private readonly IRepositoryProduct repositoryProduct;
        private readonly IRepositoryState repositoryState;

        [TempData]
        public int BillOrderID { get; set; } = 0; 
        [BindProperty]
        public BillOrder BillOrder { get; set; }
        [BindProperty]
        public BillOrderItem BillOrderItem { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
        public State State { get; set; }


        public List<BillOrder> BillOrderList { get; set; }
        public List<BillOrderItem> BillOrderItemsList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<State> StateList { get; set; }

        public BillOrdeDetailsModel (
            IRepositoryBillOrder repositoryBillOrder,
            IRepositoryBillOrderItem repositoryBillOrderItem,
            IRepositoryProduct repositoryProduct,
            IRepositoryState repositoryState
        )
        {
            this.repositoryBillOrder = repositoryBillOrder;
            this.repositoryBillOrderItem = repositoryBillOrderItem;
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

        public IEnumerable<BillOrderItem> GetBillOrderItemsByBillOrderId(int id)
        {
            var billOrderItemList = repositoryBillOrderItem.GetBillOrderItemByBillOrderId(id);
            return billOrderItemList;
        }

        public IActionResult OnGet(int ? BillOrderId)
        {
            if (BillOrderId.HasValue)
            {
                BillOrder = repositoryBillOrder.GetBillOrderId(BillOrderId.Value);
                HttpContext.Session.SetInt32("BillOrderID", BillOrder.Id);
            }
            else
            {
                BillOrder = new BillOrder();
            }

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            BillOrderItemsList = new List<BillOrderItem>();
            if (BillOrderId.HasValue)
            {
                BillOrderItemsList.AddRange(GetBillOrderItemsByBillOrderId(BillOrderId.Value));
            }

            return Page();
        }

        public IActionResult OnPostOrdenCompra()
        {
            var newBillOrder = BillOrder;
            var billOrdenCreated = repositoryBillOrder.CreateBillOrder(newBillOrder);
            HttpContext.Session.SetInt32("BillOrderID", billOrdenCreated.Id);

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            BillOrderItemsList = new List<BillOrderItem>();

            int POI = (int)HttpContext.Session.GetInt32("BillOrderID");
            if (POI != 0)
            {
                BillOrderItemsList.AddRange(GetBillOrderItemsByBillOrderId(POI));
            }

            return Page();
        }

        public void OnPostOrdenCompraItem()
        {
            BillOrderItem.BillOrderId = (int)HttpContext.Session.GetInt32("BillOrderID");
            repositoryBillOrderItem.CreateBillOrderItem(BillOrderItem);

            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());

            BillOrderItemsList = new List<BillOrderItem>();
            int POI = (int)HttpContext.Session.GetInt32("BillOrderID");
            if (POI != 0)
            {
                BillOrderItemsList.AddRange(GetBillOrderItemsByBillOrderId(POI));
            }
        }
    }
}
