namespace Atm.Api.Data.DynamicPagination
{
    public class PaginatedList<T>
    {
        public List<T> Items { get; }
        public int PageIndex { get; }
        public int TotalPages { get; }
        public string Filter { get; set; }
        public string Sort { get; set; }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public PaginatedList(List<T> items, int pageIndex, int totalPages, string filter, string sort)
        {
            Items = items;
            PageIndex = pageIndex;
            TotalPages = totalPages;
            Filter = filter;
            Sort = sort;
        }

    }
}
