using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TOR.API.Models;

namespace TOR.API.Data;

public class ApplicationDBContext : IdentityDbContext<User>

{
    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
    }


    public DbSet<User?> Users { get; set; }

    public DbSet<Municipality> Municipalities { get; set; }

    public DbSet<Establishment> Establishments { get; set; }

    public DbSet<AccomodationClassification> AccomodationClassifications { get; set; }

    public DbSet<Country> Countries { get; set; }

    public DbSet<DAE1A> DAE1As { get; set; }
    public DbSet<DAE1ADetail> DAE1ADetails { get; set; }

    public DbSet<DAE1B> DAE1Bs { get; set; }
    public DbSet<DAE1BDetail> DAE1BDetails { get; set; }

    public DbSet<DAE2> DAE2s { get; set; }
    public DbSet<DAE2VolumePerSex> DAE2VolumePerSexes { get; set; }

    public DbSet<Setting> Settings { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        List<IdentityRole> roles = new List<IdentityRole>
        {
            new() { Name = "Admin", NormalizedName = "ADMIN" },
            new() { Name = "User", NormalizedName = "USER" }
        };

        builder.Entity<IdentityRole>().HasData(roles);


        var countries = new List<Country>
        {
            new() { Id = 1, Name = "BRUNEI", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 2, Name = "CAMBODIA", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 3, Name = "INDONESIA", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 4, Name = "LAOS", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 5, Name = "MALAYSIA", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 6, Name = "MYANMAR", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 7, Name = "SINGAPORE", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 8, Name = "THAILAND", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 9, Name = "VIETNAM", Region = "ASEAN", Continent = "ASIA" },
            new() { Id = 10, Name = "CHINA", Region = "EAST ASIA", Continent = "ASIA" },
            new() { Id = 11, Name = "HONGKONG", Region = "EAST ASIA", Continent = "ASIA" },
            new() { Id = 12, Name = "JAPAN", Region = "EAST ASIA", Continent = "ASIA" },
            new() { Id = 13, Name = "KOREA", Region = "EAST ASIA", Continent = "ASIA" },
            new() { Id = 14, Name = "TAIWAN", Region = "EAST ASIA", Continent = "ASIA" },
            new() { Id = 15, Name = "BANGLADESH", Region = "SOUTH ASIA", Continent = "ASIA" },
            new() { Id = 16, Name = "INDIA", Region = "SOUTH ASIA", Continent = "ASIA" },
            new() { Id = 17, Name = "IRAN", Region = "SOUTH ASIA", Continent = "ASIA" },
            new() { Id = 18, Name = "NEPAL", Region = "SOUTH ASIA", Continent = "ASIA" },
            new() { Id = 19, Name = "PAKISTAN", Region = "SOUTH ASIA", Continent = "ASIA" },
            new() { Id = 20, Name = "SRI LANKA", Region = "SOUTH ASIA", Continent = "ASIA" },
            new() { Id = 21, Name = "BAHRAIN", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 22, Name = "EGYPT", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 23, Name = "ISRAEL", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 24, Name = "JORDAN", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 25, Name = "KUWAIT", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 26, Name = "SAUDI ARABIA", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 27, Name = "UNITED ARAB EMIRATES", Region = "MIDDLE EAST", Continent = "ASIA" },
            new() { Id = 28, Name = "CANADA", Region = "NORTH AMERICA", Continent = "AMERICA" },
            new() { Id = 29, Name = "MEXICO", Region = "NORTH AMERICA", Continent = "AMERICA" },
            new() { Id = 30, Name = "USA", Region = "NORTH AMERICA", Continent = "AMERICA" },
            new() { Id = 31, Name = "ARGENTINA", Region = "SOUTH AMERICA", Continent = "AMERICA" },
            new() { Id = 32, Name = "BRAZIL", Region = "SOUTH AMERICA", Continent = "AMERICA" },
            new() { Id = 33, Name = "COLOMBIA", Region = "SOUTH AMERICA", Continent = "AMERICA" },
            new() { Id = 34, Name = "PERU", Region = "SOUTH AMERICA", Continent = "AMERICA" },
            new() { Id = 35, Name = "VENEZUELA", Region = "SOUTH AMERICA", Continent = "AMERICA" },
            new() { Id = 36, Name = "AUSTRIA", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 37, Name = "BELGIUM", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 38, Name = "FRANCE", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 39, Name = "GERMANY", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 40, Name = "LUXEMBOURG", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 41, Name = "NETHERLANDS", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 42, Name = "SWITZERLAND", Region = "WESTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 43, Name = "DENMARK", Region = "NORTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 44, Name = "FINLAND", Region = "NORTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 45, Name = "IRELAND", Region = "NORTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 46, Name = "NORWAY", Region = "NORTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 47, Name = "SWEDEN", Region = "NORTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 48, Name = "UNITED KINGDOM", Region = "NORTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 49, Name = "GREECE", Region = "SOUTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 50, Name = "ITALY", Region = "SOUTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 51, Name = "PORTUGAL", Region = "SOUTHERN EUROPE", Continent = "EUROPE" },
            new() { Id = 52, Name = "SPAIN", Region = "SOUTHERN EUROPE", Continent = "EUROPE" },
            new()
            {
                Id = 53, Name = "UNION OF SERBIA AND MONTENEGRO", Region = "SOUTHERN EUROPE", Continent = "EUROPE"
            },
            new()
            {
                Id = 54, Name = "COMMONWEALTH OF INDEPENDENT STATES", Region = "EASTERN EUROPE", Continent = "EUROPE"
            },
            new() { Id = 55, Name = "POLAND", Region = "EASTERN EUROPE", Continent = "EUROPE" },
            new() { Id = 56, Name = "RUSSIA", Region = "EASTERN EUROPE", Continent = "EUROPE" },
            new()
            {
                Id = 57, Name = "AUSTRALIA", Region = "AUSTRALASIA/PACIFIC", Continent = "AUSTRALASIA/PACIFIC"
            },
            new() { Id = 58, Name = "GUAM", Region = "AUSTRALASIA/PACIFIC", Continent = "AUSTRALASIA/PACIFIC" },
            new() { Id = 59, Name = "NAURU", Region = "AUSTRALASIA/PACIFIC", Continent = "AUSTRALASIA/PACIFIC" },
            new()
            {
                Id = 60, Name = "NEW ZEALAND", Region = "AUSTRALASIA/PACIFIC", Continent = "AUSTRALASIA/PACIFIC"
            },
            new()
            {
                Id = 61, Name = "PAPUA NEW GUINEA", Region = "AUSTRALASIA/PACIFIC", Continent = "AUSTRALASIA/PACIFIC"
            },
            new() { Id = 62, Name = "NIGERIA", Region = "AFRICA", Continent = "AFRICA" },
            new() { Id = 63, Name = "SOUTH AFRICA", Region = "AFRICA", Continent = "AFRICA" }
        };


        builder.Entity<Country>().HasData(countries);


        List<AccomodationClassification> accomodationClassifications = new List<AccomodationClassification>
        {
            new() { Id = 1, Name = "Hotel", Code = "HTL", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 2, Name = "Condotel", Code = "CON", Status = "Active", DateCreated = DateTime.UtcNow },
            new()
            {
                Id = 3, Name = "Serviced Residence", Code = "SER", Status = "Active", DateCreated = DateTime.UtcNow
            },
            new() { Id = 4, Name = "Resort", Code = "RES", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 5, Name = "Apartelle", Code = "APA", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 6, Name = "Motel", Code = "MOT", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 7, Name = "Pension House", Code = "PEN", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 8, Name = "Home Stay Site", Code = "HSS", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 9, Name = "Tourist Inn", Code = "TIN", Status = "Active", DateCreated = DateTime.UtcNow },
            new() { Id = 10, Name = "Others", Code = "OTH", Status = "Active", DateCreated = DateTime.UtcNow },
        };

        builder.Entity<AccomodationClassification>().HasData(accomodationClassifications);


        List<Municipality> municipalities = new List<Municipality>
        {
            new() { Id = 1, Name = "Carrascal", Contact = "09123456789", Email = "carrascal@gmail.com", },
            new() { Id = 2, Name = "Cantilan", Contact = "09123456789", Email = "cantilan@gmail.com", },
            new() { Id = 3, Name = "Madrid", Contact = "09123456789", Email = "madrid@gmail.com", },
            new() { Id = 4, Name = "Carmen", Contact = "09123456789", Email = "carmen@gmail.com", },
            new() { Id = 5, Name = "Lanuza", Contact = "09123456789", Email = "lanuza@gmail.com", },
            new() { Id = 6, Name = "Cortes", Contact = "09123456789", Email = "cortes@gmail.com", },
            new() { Id = 7, Name = "Tandag City", Contact = "09123456789", Email = "tandag@gmail.com", },
            new() { Id = 8, Name = "Tago", Contact = "09123456789", Email = "tago@gmail.com", },
            new() { Id = 9, Name = "Lingig", Contact = "09123456789", Email = "lingig@gmail.com", },
            new() { Id = 10, Name = "Tagbina", Contact = "09123456789", Email = "tagbina@gmail.com", },
            new() { Id = 11, Name = "Bislig", Contact = "09123456789", Email = "bislig@gmail.com", },
            new() { Id = 12, Name = "Marihatag", Contact = "09123456789", Email = "marihatag@gmail.com", },
            new() { Id = 13, Name = "Cagwait", Contact = "09123456789", Email = "cagwait@gmail.com", },
            new() { Id = 14, Name = "Bayabas", Contact = "09123456789", Email = "bayabas@gmail.com", },
            new() { Id = 15, Name = "Lianga", Contact = "09123456789", Email = "lianga@gmail.com", },
            new()
            {
                Id = 16, Name = "Hinatuan", Contact = "09123456789", Email = "hinatuan@gmail.com",
            },
            new()
            {
                Id = 17, Name = "Carmen", Contact = "09123456789", Email = "carmen@gmail.com",
            },
            new()
            {
                Id = 18, Name = "Barobo", Contact = "09123456789", Email = "barobo@gmail.com",
            }
        };

        builder.Entity<Municipality>().HasData(municipalities);

        builder.Entity<Establishment>()
            .HasIndex(e => e.AEIDCode)
            .IsUnique();


        base.OnModelCreating(builder);
    }
}