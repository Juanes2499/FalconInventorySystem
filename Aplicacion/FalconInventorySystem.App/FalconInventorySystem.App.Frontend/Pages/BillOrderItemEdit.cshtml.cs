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
    public class BillOrdeItemEditModel : PageModel
    {
        private readonly IRepositoryBillOrder repositoryBillOrder;
        private readonly IRepositoryBillOrderItem repositoryBillOrderItem;
        private readonly IRepositoryProduct repositoryProduct;
        private readonly IRepositoryState repositoryState;

        [TempData]
        public int BillOrderID { get; set; } = 0;
        [BindProperty]
        public BillOrderItem BillOrderItem { get; set; }
        public Product Product { get; set; }
        public State State { get; set; }
        
        public List<BillOrderItem> BillOrderItemsList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<State> StateList { get; set; }

        

        public BillOrdeItemEditModel(
            IRepositoryBillOrderItem repositoryBillOrderItem,
            IRepositoryProduct repositoryProduct,
            IRepositoryState repositoryState
        )
        {
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
        public IActionResult OnGet(int? billOrderItemId)
        {
            if (billOrderItemId.HasValue)
            {
                BillOrderItem = repositoryBillOrderItem.GetBillOrderItemId(billOrderItemId.Value);
            }
            else
            {
                BillOrderItem = new BillOrderItem();
            }
            ProductList = new List<Product>();
            ProductList.AddRange(GetProducts());

            StateList = new List<State>();
            StateList.AddRange(GetStates());
            return Page();
        }
    }
}
