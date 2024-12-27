using System;

namespace StarSystemLibrary
{
    /// <summary>
    /// Абстрактный класс, представляющий объект космической системы.
    /// </summary>
    public abstract class SpaceObject
    {
        /// <summary>
        /// Имя объекта.
        /// </summary>
        public abstract string Name { get; set; }
        
        /// <summary>
        /// Масса объекта (в килограммах).
        /// </summary>
        public abstract float Mass { get; set; }

        /// <summary>
        /// Диаметр по экватору объекта (в километрах).
        /// </summary>
        public abstract float EquatorialDiameter { get; set; }

        /// <summary>
        /// Возраст объекта (в миллионах лет).
        /// </summary>
        public abstract int Age { get; set; }

        /// <summary>
        /// Метод для получения информации об объекте.
        /// </summary>
        /// <returns>Строка с информацией об объекте.</returns>
        public virtual string GetInfo()
        {
            return $"Масса: {Mass} кг, Диаметр: {EquatorialDiameter} км, Возраст: {Age} млн лет";
        }

        /// <summary>
        /// Абстрактный метод для обновления свойств объекта.
        /// </summary>
        /// <param name="mass">Масса объекта.</param>
        /// <param name="diameter">Диаметр по экватору объекта.</param>
        /// <param name="age">Возраст объекта.</param>
        public abstract void UpdateProperties(float mass, float diameter, int age);
    }
}
