namespace Assessment.Domain.Model; 

public class Satellite: CelestialBody
{

    public CelestialBody? Planet {get; internal set;}

    public Satellite(CelestialBody planet){
        Planet = planet;
      
    }
    
}
