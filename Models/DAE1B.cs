namespace TOR.API.Models;

public class DAE1B
{
    public int Id { get; set; }
    public int EstablishmentId { get; set; }
    public Establishment Establishment { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    
    public int CreatedById { get; set; }
    public User CreatedBy { get; set; }
    
    public int DAE1AId { get; set; }
    public DAE1A DAE1A { get; set; }
    
    public int OthersUnspecified { get; set; }
    public int NonPhilippineResidences { get; set; }
    public int OverSeasFilipinos { get; set; }
    public int PhilippinesResidentFilipinoNationality { get; set; }
    public int PhilippinesResidentForeignNationality { get; set; }
    public int TotalPhilippinesResident { get; set; }
    public int TotalNonPhilippinesResident { get; set; }
    public int TotalOverseasFilipinos { get; set; }
    public int TotalGuestWithUnspecifiedResidence { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}