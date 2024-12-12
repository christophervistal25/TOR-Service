namespace TOR.API.Models;

public class Setting
{
    public int Id { get; set; }
    public string KeyName { get; set; }
    public string KeyValue { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}