namespace Assessment.Domain.Model;

public abstract class Planet : CelestialBody
{
    protected CelestialBody? Star { get; set; }
    public IReadOnlyList<CelestialBody>? Satellites => _satellites;
    private List<CelestialBody>? _satellites = new List<CelestialBody>();
    public Planet(CelestialBody? star)
    {
        Star = star;
    }

    public void AddSatellite(CelestialBody satellite)
    {
        _satellites?.Add(satellite);
    }

      public bool HasSatelliteMoons(){
        return _satellites?.Count> 0;
    }
}