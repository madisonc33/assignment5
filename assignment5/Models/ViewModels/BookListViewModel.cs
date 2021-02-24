using System;
using System.Collections.Generic;
namespace assignment5.Models.ViewModels
{
    //makes our list of books that come back from the query iterable
    public class BookListViewModel
    {
        public IEnumerable<Books> Books { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
