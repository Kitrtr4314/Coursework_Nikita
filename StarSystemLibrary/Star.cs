using System;

namespace StarSystemLibrary
{
    /// <summary>
    /// Класс, представляющий звезду.
    /// </summary>
    public class Star : SpaceObject
    {
        public override float Mass { get; set; }
        public override float EquatorialDiameter { get; set; }
        public override int Age { get; set; }

        /// <summary>
        /// Светимость звезды (в солнечных светимостях).
        /// </summary>
        public float Luminosity { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Светимость: {Luminosity} L☉";
        }

        public override void UpdateProperties(float mass, float diameter, int age)
        {
            Mass = mass;
            EquatorialDiameter = diameter;
            Age = age;
        }
    }
}
