// See https://aka.ms/new-console-template for more information

using Assessment.Domain.Extensions;
using Assessment.Domain.Model;

var solarSystem = new StarSystem();

//Star
var sun = new DwarfYellowStar() { Name = "Sun" };
solarSystem.AddCelestialBody(sun);

//data
var earth = new TerrestrialPlanet(sun) { Name = "Earth", SunDistanceInMillionKm = 149.6, OrbitalPeriodInDays = 365, MassInSeptillionKg = 5.97 };
var mars = new TerrestrialPlanet(sun) { Name = "Mars", SunDistanceInMillionKm = 228, OrbitalPeriodInDays = 687, MassInSeptillionKg = 0.642}; 
var venus = new TerrestrialPlanet(sun) { Name = "Venus", SunDistanceInMillionKm = 108.2, OrbitalPeriodInDays = 225, MassInSeptillionKg = 4.87 };
var mercury = new TerrestrialPlanet(sun) { Name = "Mercury", SunDistanceInMillionKm = 57.9, OrbitalPeriodInDays = 88, MassInSeptillionKg = 0.330};
var uranus = new IceGiant(sun) { Name = "Uranus", SunDistanceInMillionKm = 2867, OrbitalPeriodInDays = 30589, MassInSeptillionKg = 86.8 };
var neptune = new IceGiant(sun) { Name = "Neptune", SunDistanceInMillionKm = 4515, OrbitalPeriodInDays = 60190, MassInSeptillionKg = 102 };
var jupiter = new GasGiant(sun) { Name = "Jupiter", SunDistanceInMillionKm = 778.5, OrbitalPeriodInDays = 4331, MassInSeptillionKg = 1898 };
var saturn = new GasGiant(sun) { Name = "Saturn", SunDistanceInMillionKm = 1432, OrbitalPeriodInDays = 10747, MassInSeptillionKg = 568 };
var ceres = new DwarfPlanet(sun) { Name = "Ceres", SunDistanceInMillionKm = 413, OrbitalPeriodInDays = 1682, MassInSeptillionKg = 9.1 };
var eris = new DwarfPlanet(sun) { Name = "Eris", SunDistanceInMillionKm = 10125, OrbitalPeriodInDays = 203670 };
var haumea = new DwarfPlanet(sun) { Name = "Haumea", OrbitalPeriodInDays = 104025 };
var makemake = new DwarfPlanet(sun) { Name = "Makemake", OrbitalPeriodInDays = 111325 };
var pluto = new DwarfPlanet(sun) { Name = "Pluto", OrbitalPeriodInDays = 90520 };
var moon = new Satellite(earth) {Name = "Moon", OrbitalPeriodInDays = 9855};
var deimos = new Satellite(mars) {Name = "Deimos", OrbitalPeriodInDays = 10000};
var phobos = new Satellite(mars) {Name = "Phobos", OrbitalPeriodInDays = 10000};
var titania = new Satellite(uranus) {Name = "Titania", OrbitalPeriodInDays = 10000};
var miranda = new Satellite(uranus) {Name = "Miranda", OrbitalPeriodInDays = 10000};
var triton = new Satellite(neptune) {Name = "Triton", OrbitalPeriodInDays = 10000};
var europa = new Satellite(jupiter) {Name = "Europa", OrbitalPeriodInDays = 10000};
var hanymede = new Satellite(jupiter) {Name = "Hanymede", OrbitalPeriodInDays = 10000};
var io = new Satellite(jupiter) {Name = "Io", OrbitalPeriodInDays = 10000};
var enceladus = new Satellite(saturn){Name = "Enceladus", OrbitalPeriodInDays = 10000};
var titan = new Satellite(saturn){Name = "Titan", OrbitalPeriodInDays = 10000};
var charon = new Satellite(pluto){Name = "Charon", OrbitalPeriodInDays = 10000};
var hydra = new Satellite(pluto){Name = "Hydra", OrbitalPeriodInDays = 10000};
var kerberos = new Satellite(pluto){Name = "Kerberos", OrbitalPeriodInDays = 10000};
var nix = new Satellite(pluto){Name = "Nix", OrbitalPeriodInDays = 10000};
var styx = new Satellite(pluto){Name = "Styx", OrbitalPeriodInDays = 10000};

//add satellites to planets
earth.AddSatellite(moon);
mars.AddSatellite(deimos);
mars.AddSatellite(phobos);
neptune.AddSatellite(triton);
uranus.AddSatellite(titania);
uranus.AddSatellite(miranda);
jupiter.AddSatellite(europa);
jupiter.AddSatellite(hanymede);
jupiter.AddSatellite(io);
saturn.AddSatellite(enceladus);
saturn.AddSatellite(titan);
pluto.AddSatellite(charon);
pluto.AddSatellite(hydra);
pluto.AddSatellite(kerberos);
pluto.AddSatellite(nix);
pluto.AddSatellite(styx);

//Planets
solarSystem.AddCelestialBody(earth);
solarSystem.AddCelestialBody(mars);
solarSystem.AddCelestialBody(venus);
solarSystem.AddCelestialBody(mercury);
solarSystem.AddCelestialBody(uranus);
solarSystem.AddCelestialBody(neptune);
solarSystem.AddCelestialBody(jupiter);
solarSystem.AddCelestialBody(saturn);
solarSystem.AddCelestialBody(ceres);
solarSystem.AddCelestialBody(eris);
solarSystem.AddCelestialBody(haumea);
solarSystem.AddCelestialBody(makemake);
solarSystem.AddCelestialBody(pluto);

//Satellites
solarSystem.AddCelestialBody(moon);
solarSystem.AddCelestialBody(moon);
solarSystem.AddCelestialBody(deimos);
solarSystem.AddCelestialBody(phobos);
solarSystem.AddCelestialBody(triton);
solarSystem.AddCelestialBody(titania);
solarSystem.AddCelestialBody(miranda);
solarSystem.AddCelestialBody(europa);
solarSystem.AddCelestialBody(hanymede);
solarSystem.AddCelestialBody(io);
solarSystem.AddCelestialBody(enceladus);
solarSystem.AddCelestialBody(titan);
solarSystem.AddCelestialBody(charon);
solarSystem.AddCelestialBody(hydra);
solarSystem.AddCelestialBody(kerberos);
solarSystem.AddCelestialBody(nix);
solarSystem.AddCelestialBody(styx);

var orderedCelestialBodies = solarSystem.CelestialBodies.OrderBy(c => c.OrbitalPeriodInDays);
foreach (var item in orderedCelestialBodies)
{
    Console.WriteLine(item.Name);
    TerrestrialPlanetExtensions.Colonize(item);
}

