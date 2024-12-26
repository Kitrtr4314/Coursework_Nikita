using System;

namespace StarSystemLibrary
{
    /// <summary>
    /// Класс, представляющий планету.
    /// </summary>
    public class Planet : SpaceObject
    {
        public override float Mass { get; set; }
        public override float EquatorialDiameter { get; set; }
        public override int Age { get; set; }

        /// <summary>
        /// Количество лун у планеты.
        /// </summary>
        public int MoonsCount { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Количество лун: {MoonsCount}";
        }

        public override void UpdateProperties(float mass, float diameter, int age)
        {
            Mass = mass;
            EquatorialDiameter = diameter;
            Age = age;
        }
    }
}
