public class PaginatedList<T> : List<T>
{
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }

    public PaginatedList(List<T> items, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(items.Count / (double)pageSize);

        AddRange(items.Skip((pageIndex - 1) * pageSize).Take(pageSize));
    }

    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;

    public static PaginatedList<T> Create(List<T> source, int pageIndex, int pageSize)
    {
        return new PaginatedList<T>(source, pageIndex, pageSize);
    }
}
