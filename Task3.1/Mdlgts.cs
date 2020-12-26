using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3._1
{
    /// <summary>
    /// Класс содержащий список делегатов
    /// обеспечивающий логику сортировки.
    /// </summary>
    public class Mdlgts
    {
        // Сортировки выбранные пользователями.
        internal Func<Student, Student, int> f = null;

        // Весь список методов для сортировки.
        private readonly List<Func<Student, Student, int>> delList;

        public Mdlgts(List<Func<Student, Student, int>> delList)
        {
            this.delList = delList;
        }
        
        /// <summary>
        /// Добавление способа сортировки.
        /// </summary>
        /// <param name="x">
        /// Индекс для delList.
        /// </param>
        /// <returns>
        /// Позиция в списке делегатов.
        /// </returns>
        internal int Add(int x)
        {
            f += delList[x - 1];
            return f.GetInvocationList().ToList().Count();             
        }
        
        /// <summary>
        /// Удаляем делегат сортировки.
        /// </summary>
        /// <param name="x"></param>
        internal void Remove(int x)
        {
            f -= delList[x - 1];            
        }

        // Сброс параметров сортировки.
        internal void Reset()
        {
            f = null;
        }
    }
}
