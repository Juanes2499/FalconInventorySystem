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
    public class ItemTransactionDeleteModel : PageModel
    {
        private readonly IRepositoryItemTransaction repositoryItemTransaction;

        [BindProperty]
        public ItemTransaction ItemTransaction { get; set; }

        public ItemTransactionDeleteModel(
            IRepositoryItemTransaction repositoryItemTransaction
        )
        {
            this.repositoryItemTransaction = repositoryItemTransaction;
        }

        public IActionResult OnGet(int itemTransactionId)
        {
            ItemTransaction = repositoryItemTransaction.GetItemTransactionId(itemTransactionId);

            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryItemTransaction.DeleteItemTransaction(ItemTransaction.Id);
            return RedirectToPage("ItemTransaction");
        }
    }
}
