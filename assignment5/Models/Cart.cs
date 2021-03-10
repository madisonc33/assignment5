using System;
using System.Collections.Generic;
using System.Linq;
namespace assignment5.Models
{
     
    public class Cart
    {
        //creates a list of type cart line object which is created at the bottom.
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //When the addItems method is called, if that item has not been added before, it creates a new line and adds the information. If it has been added, it just increases the quantity
        public virtual void AddItem(Books book, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //removes all items with the matching ID that is passed
        public virtual void RemoveItem(Books book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //clears the whole cart (not used anywhere yet)
        public virtual void Clear() => Lines.Clear();

        //method to computer the sum of the cart
        public decimal ComputeTotalSum() => Lines.Sum(e => (decimal)e.Book.Price * e.Quantity);

        //creates the cartline class that is used in this class
        public class CartLine
        {
            public int CartLineID { get; set; }

            public Books Book { get; set; }

            public int Quantity { get; set; }
        }
           
    }
}
