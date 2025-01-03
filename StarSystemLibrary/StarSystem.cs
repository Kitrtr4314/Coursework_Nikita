using System;
using System.Collections.Generic;
using System.Linq;

namespace StarSystemLibrary
{
    /// <summary>
    /// Класс, представляющий звёздную систему.
    /// </summary>
    public class StarSystem
    {
        /// <summary>
        /// Список объектов в звёздной системе (звёзды, планеты, луны).
        /// </summary>
        private readonly List<SpaceObject> _spaceObjects;

        public StarSystem()
        {
            _spaceObjects = new List<SpaceObject>();
        }

        /// <summary>
        /// Добавить объект в звёздную систему.
        /// </summary>
        /// <param name="spaceObject">Космический объект для добавления.</param>
        public void AddSpaceObject(SpaceObject spaceObject)
        {
            if (spaceObject == null)
                throw new ArgumentNullException(nameof(spaceObject));

            _spaceObjects.Add(spaceObject);
        }

        /// <summary>
        /// Удалить объект из звёздной системы.
        /// </summary>
        /// <param name="spaceObject">Космический объект для удаления.</param>
        public void RemoveSpaceObject(SpaceObject spaceObject)
        {
            if (spaceObject == null)
                throw new ArgumentNullException(nameof(spaceObject));

            _spaceObjects.Remove(spaceObject);
        }

        /// <summary>
        /// Получить список всех объектов в звёздной системе.
        /// </summary>
        /// <returns>Список объектов.</returns>
        public List<SpaceObject> GetAllSpaceObjects()
        {
            return new List<SpaceObject>(_spaceObjects);
        }
        
        /// <summary>
        /// Отсортировать объекты по указанному критерию (по умолчанию по возрастанию).
        /// </summary>
        /// <param name="keySelector">Функция для выбора ключа сортировки.</param>
        /// <typeparam name="TKey">Тип ключа сортировки.</typeparam>
        public void SortSpaceObjects<TKey>(Func<SpaceObject, TKey> keySelector)
        {
            _spaceObjects.Sort((x, y) => Comparer<TKey>.Default.Compare(keySelector(x), keySelector(y)));
        }
    }
}
