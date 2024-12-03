namespace ProductData.Models
{
    public class ProductDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    //public class PaginatedList<T>
    //{
    //    public IEnumerable<T> Items { get; set; }
    //    public int PageNumber { get; set; }
    //    public int TotalPages { get; set; }
    //    public bool HasPreviousPage => PageNumber > 1;
    //    public bool HasNextPage => PageNumber < TotalPages;
    //}

    public class PageIn
    {
        public int Totalitems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }

        public PageIn(int totalitems, int page, int pageSize = 10)
        {
            int totalPage = (int)Math.Ceiling((decimal)totalitems /(decimal)pageSize);
            int currentPage = page;
            int startPage = currentPage - 5;
            int endPage = currentPage - 4;

            if(startPage <= 0)
            {
                endPage = endPage - (startPage - 1);    
                startPage = +1;

            }
            if (endPage <= 0)             
            {
                endPage = totalPage;
                if(endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }

            Totalitems = totalPage;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPage = totalPage;
            StartPage = startPage;
            EndPage = endPage;

        }

    }

    

}
