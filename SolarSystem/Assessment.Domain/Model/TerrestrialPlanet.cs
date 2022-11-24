namespace Assessment.Domain.Model;

public sealed class TerrestrialPlanet : Planet, IHabitable, ICanBeTerraformed
{
    public bool HasWater {get;set;}
    public TerrestrialPlanet(CelestialBody star) : base(star)
    {
    }
    public bool CanSustainLife() {
        return (AtmosphereComponents!.Contains("oxigen") && HasWater);
    }
     public bool CanBeTerraformed() {
       return false;
    }
}
