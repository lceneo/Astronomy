using System.Drawing;
using System.IO;

namespace Astronomy
{
     public enum Planets: byte 
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
    }

    public class Planet
    {
        public Planet(Planets name, long aphelion, long perihelion, long semiMajorAxis, int orbitalPeriod)
        {
            this.Name = name;
            this.PlanetImage = Image.FromFile(Path.Combine(@"C:\Users\Iceneo\Downloads\planets", $"{Name}.png"));
            this.Aphelion = aphelion;
            this.Perihelion = perihelion;
            this.SemiMajorAxis = semiMajorAxis;
            this.OrbitalPeriod = orbitalPeriod;
        }

        public Planets Name { get; private set; }
        public Image PlanetImage { get; private set; }
        public long Aphelion { get; private set; } 
        public long Perihelion { get; private set; }
        public long SemiMajorAxis { get; private set; }
        public int OrbitalPeriod { get; private set; }

        public override string ToString()
        {
            return $"Name: {Name}\r\n Aphelion: {Aphelion}\r\nPerihelion: {Perihelion}\r\nSemi-Major Axis: {SemiMajorAxis}\r\n Orbital Period: {OrbitalPeriod}";
        }
    }
}
