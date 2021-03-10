using System;
using Microsoft.AspNetCore.Mvc;
using assignment5.Models;
namespace assignment5.Components
{
    //Makes a viewcomponent so that we can display a cart summary in the top right hand corner
        public class CartSummaryViewComponent : ViewComponent
        {
            private Cart cart;
            public CartSummaryViewComponent(Cart cartService)
            {
                cart = cartService;
            }
            public IViewComponentResult Invoke()
            {
                return View(cart);
            }
        }
}
