using System;
using System.Linq;
namespace assignment5.Models
{

    public interface IBooksRepository
    {
        IQueryable<Books> Books { get; }
    }
    
}
