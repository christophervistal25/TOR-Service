namespace TOR.API.DTOs;

public class ClaimsDTO
{
    public List<ClaimDTO> Claims { get; set; }
}

public class ClaimDTO
{
    public string Type { get; set; }
    public string Value { get; set; }
}