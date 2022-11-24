using Assessment.Domain.Model;

namespace Assessment.Domain.Extensions;

public static class TerrestrialPlanetExtensions
{
    public static void Colonize(this CelestialBody celestialBody){   
    if(celestialBody is TerrestrialPlanet && celestialBody is IHabitable){
    Console.WriteLine( celestialBody.Name + " can be colonize!");
    }}
}
