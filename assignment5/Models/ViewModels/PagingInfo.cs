using System;
namespace assignment5.Models.ViewModels
{
    //this class is used to dynamically show the pages bar at the bottom of the page
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling(((decimal)TotalNumItems / ItemsPerPage)));
    }
}
