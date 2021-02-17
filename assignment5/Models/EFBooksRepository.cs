using System;
using System.Linq;
namespace assignment5.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private BooksDBContext _context;

        public EFBooksRepository (BooksDBContext context)
        {
            _context = context;
        }

        public IQueryable<Books> Books => _context.Books;
    }
}
