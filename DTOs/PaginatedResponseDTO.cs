namespace TOR.API.DTOs;

public class PaginatedResponseDTO<T>
{
    public int currentPage { get; set; }
    public string term { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages { get; set; }
    public List<T> Data { get; set; } = new List<T>();
    
}