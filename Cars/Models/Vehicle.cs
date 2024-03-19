namespace Cars.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string? CarPlate { get; set; }
    public int Km { get; set; }
    public string? Model { get; set; }
    public string? Color { get; set; }
    public string? GearType { get; set; }
    public string? BrandName { get; set; }
    public Brand? Brand { get; set; }
}

