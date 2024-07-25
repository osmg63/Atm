namespace Atm.Api.Data.DynamicPagination;

public class PagedRequest
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string Filter { get; set; }
    public string Sort { get; set; }
}