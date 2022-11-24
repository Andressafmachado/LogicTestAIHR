namespace Assessment.Domain.Model;

public interface IUniverseItem { string? CelestialBodyName();};

public abstract class CelestialBody 
{
    public string? Name { get; set; }
    public byte[] Picture { get; set; } = Array.Empty<byte>();
    public double SunDistanceInMillionKm { get; set; }
    public int OrbitalPeriodInDays { get; set; }   
    public double? MassInSeptillionKg { get; set; }
    public List<string>? AtmosphereComponents { get; set; }


}
