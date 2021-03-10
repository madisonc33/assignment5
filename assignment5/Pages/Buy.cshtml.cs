using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using assignment5.Models;
using assignment5.Infrastructure;

namespace assignment5.Pages
{
    //model to go with our Razor Page. allows us to get all the books from the db and access them.
    public class BuyModel : PageModel
    {
        private IBooksRepository repository;

        public BuyModel(IBooksRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //these methods execute whenever we receive a post method that matched. The post is defined in a form and can match the asp-page-handler name
        //adds item to the cart
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Books book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            //took out from ch 9
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            //took out from ch 9
            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //removes the item from the car
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveItem(Cart.Lines.First(cl => cl.Book.BookId == bookId).Book);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

    }
}
