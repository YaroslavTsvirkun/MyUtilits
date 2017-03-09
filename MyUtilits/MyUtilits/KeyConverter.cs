using System;

namespace MyUtilits
{
    internal class KeyConverter
    {
        /// <summary>
        /// Массив для хранения ключей длины
        /// </summary>
        public String[] unitsLength { get; } = { "нм", "мкм", "мм", "см", "дм", "м", "км", "сух. миля",
            "мор. миля" };

        /// <summary>
        /// Массив для хранения ключей веса
        /// </summary>
        public String[] unitsWeight { get; } = { "нг", "мг", "г", "кг", "цт", "тона", "фунт", "унция" };

        /// <summary>
        /// Массив для хранения ключей температуры
        /// </summary>
        public String[] unitsTemperature { get; } = { "шкала Кельвина", "шкала Цельсия", "шкала Фаренгейта",
            "шкала Ранкина", "шкала Реомюра", "шкала Рёмер", "шкала Ньютон", "шкала Делиль" };
        
        /// <summary>                                                                                                            
        /// Массив для хранения ключей энергии                                                                                   
        /// </summary>
        public String[] unitsEnergy { get; } = { };

        /// <summary>
        /// Массив для хранения ключей объема
        /// </summary>
        public String[] unitsVolume { get; } = { };

        /// <summary>
        /// Массив для хранения ключей площади
        /// </summary>
        public String[] unitsArea { get; } = { };

        /// <summary>
        /// Массив для хранения ключей скорости
        /// </summary>
        public String[] unitsSpeed { get; } = { };

        /// <summary>
        /// Массив для хранения ключей времени
        /// </summary>
        public String[] unitsTime { get; } = { };

        /// <summary>
        /// Массив для хранения ключей мощности
        /// </summary>
        public String[] unitsPower { get; } = { };

        /// <summary>
        /// Массив для хранения ключей данных
        /// </summary>
        public String[] unitsData { get; } = { };

        /// <summary>
        /// Массив для хранения ключей давления
        /// </summary>
        public String[] unitsPressure { get; } = { };

        /// <summary>
        /// Массив для хранения ключей углов
        /// </summary>
        public String[] unitsAngle { get; } = { "Градусы", "Радианы", "Градианы", };

        /// <summary>
        /// Конструктор класса KeyConverter по умолчанию
        /// </summary>
        public KeyConverter() { }
    }
}