using System;
using System.Collections.Generic;
using System.Text;

namespace DiningEasy.Model
{
    public static class Manager
    {
        /// <summary>
        /// Текущая выбранная столовая
        /// </summary>
        public static ICanteen CurrentCanteen;

        /// <summary>
        /// Текущий источник данных
        /// </summary>
        public static IStorage Storage { get; } = new StorageInbuilt();
    }
}
