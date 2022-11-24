namespace Assessment.Domain.Model;

public class StarSystem
{
    public string? Name { get; set; }

    private List<CelestialBody> _celestialBodies = new List<CelestialBody>();

    public IReadOnlyCollection<CelestialBody> CelestialBodies => _celestialBodies;

    public void AddCelestialBody(CelestialBody celestialBody)
    {
        _celestialBodies.Add(celestialBody);
    }
}
