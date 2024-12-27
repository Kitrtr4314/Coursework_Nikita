using System;

namespace StarSystemLibrary
{
    /// <summary>
    /// Класс, представляющий луну.
    /// </summary>
    public class Moon : SpaceObject
    {
        public override string ToString()
        {
            return Name;
        }
        public override string Name { get; set; }
        public override float Mass { get; set; }
        public override float EquatorialDiameter { get; set; }
        public override int Age { get; set; }

        /// <summary>
        /// Название планеты, вокруг которой вращается луна.
        /// </summary>
        public string PlanetName { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Орбита вокруг планеты: {PlanetName}";
        }

        public override void UpdateProperties(float mass, float diameter, int age, string name)
        {
            Mass = mass;
            EquatorialDiameter = diameter;
            Age = age;
            Name = name;
        }
    }
}
