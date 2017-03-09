using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyUtilits
{
    internal class Converter
    {
        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения
        /// </summary>
        public Dictionary<String, Double> metricaCurrent { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения длинны
        /// </summary>
        public Dictionary<String, Double> metricaLength { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения веса
        /// </summary>
        public Dictionary<String, Double> metricaWeight { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения температуры
        /// </summary>
        public Dictionary<String, Double> metricaTemperature { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения энергии
        /// </summary>
        public Dictionary<String, Double> metricaEnergy { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения объема
        /// </summary>
        public Dictionary<String, Double> metricaVolume { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения площади
        /// </summary>
        public Dictionary<String, Double> metricaArea { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения скорости
        /// </summary>
        public Dictionary<String, Double> metricaSpeed { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения времени
        /// </summary>
        public Dictionary<String, Double> metricaTime { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения мощности
        /// </summary>
        public Dictionary<String, Double> metricaPower { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения данных
        /// </summary>
        public Dictionary<String, Double> metricaData { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения давления
        /// </summary>
        public Dictionary<String, Double> metricaPressure { get; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения углов
        /// </summary>
        public Dictionary<String, Double> metricaAngle { get; }

        /// <summary>
        /// Конструктор класса Converter по умолчанию
        /// </summary>
        public Converter()
        {
            // Словарь единиц измерения длины
            metricaLength = new Dictionary<String, Double>();
            metricaLength.Add("нм", 0.000001);
            metricaLength.Add("мкм", 0.001);
            metricaLength.Add("мм", 1);
            metricaLength.Add("см", 10);
            metricaLength.Add("дм", 100);
            metricaLength.Add("м", 1000);
            metricaLength.Add("км", 1000000);
            metricaLength.Add("сух. миля", 1609344);
            metricaLength.Add("мор. миля", 1852000);

            // Словарь единиц измерения длины
            metricaWeight = new Dictionary<String, Double>();

            // Словарь единиц измерения температуры
            metricaTemperature = new Dictionary<String, Double>();
            metricaTemperature.Clear();
            metricaTemperature.Add("шкала Кельвина", 313.15);
            metricaTemperature.Add("шкала Цельсия", 40);
            metricaTemperature.Add("шкала Фаренгейта", 104);
            metricaTemperature.Add("шкала Ранкина", 563.67);
            metricaTemperature.Add("шкала Реомюра", 32);
            metricaTemperature.Add("шкала Рёмер", 28.5);
            metricaTemperature.Add("шкала Ньютон", 13.5);
            metricaTemperature.Add("шкала Делиль", 90);

            // Словарь единиц измерения энергии
            metricaEnergy = new Dictionary<String, Double>();

            // Словарь единиц измерения объма
            metricaVolume = new Dictionary<String, Double>();

            // Словарь единиц измерения пдлщади
            metricaArea = new Dictionary<String, Double>();

            // Словарь единиц измерения скорости
            metricaSpeed = new Dictionary<String, Double>();

            // Словарь единиц измерения времени
            metricaTime = new Dictionary<String, Double>();

            // Словарь единиц измерения мощности
            metricaPower = new Dictionary<String, Double>();

            // Словарь единиц измерения данных
            metricaData = new Dictionary<String, Double>();

            // Словарь единиц измерения давления
            metricaPressure = new Dictionary<String, Double>();

            // Словарь единиц измерения углов
            metricaAngle = new Dictionary<String, Double>();
        }

        /// <summary>
        /// Метод ConverterLogic содержит логику конвертации единиц измерения
        /// </summary>
        /// <param name="cbFrom">Содержит список единиц измерения, исходных данных</param>
        /// <param name="cbTo">Содержит список единиц измерения, конечного результата</param>
        /// <param name="cbMetrica">Содержит список конвертируемых единиц измерения</param>
        /// <param name="tbFrom">Содержит начальную строку-значение единицы измерения</param>
        /// <param name="tbTo">Содержит конечную строку-значение единицы измерения</param>
        public void ConverterLogic(ComboBox cbFrom, ComboBox cbTo, ComboBox cbMetrica, TextBox tbFrom, TextBox tbTo)
        {
            // Конвертация длины и веса
            Double metricaFrom = metricaCurrent[cbFrom.Text];
            Double metricaTo = metricaCurrent[cbTo.Text];
            Double convert = Convert.ToDouble(tbFrom.Text);
            switch (cbMetrica.Text)
            {
                case "Длина":tbTo.Text = (convert * metricaFrom / metricaTo).ToString();
                    break;
                case "Вес":tbTo.Text = (convert * metricaFrom / metricaTo).ToString();
                    break;
                case "Температура":
                    switch (cbFrom.Text)
                    {
                        case "шкала Кельвина":
                            break;
                        case "шкала Цельсия":
                            break;
                        case "шкала Фаренгейта":
                            break;
                        case "шкала Ранкина":
                            break;
                        case "шкала Реомюра":
                            break;
                        case "шкала Рёмер":
                            break;
                        case "шкала Ньютон":
                            break;
                        case "шкала Делиль":
                            break;
                    }
                    break;
                case "Энергия":
                    switch (cbFrom.Text)
                    {
                        case "Электрон-вольт":
                            break;
                        case "Джоулей":
                            break;
                        case "Килоджоулей":
                            break;
                        case "Тепловых калорий":
                            break;
                        case "Пищевых калорий":
                            break;
                        case "Фут-фунтов":
                            break;
                        case "Британских тепловых единиц":
                            break;
                    }
                    break;
                case "Объем":
                    break;
                case "Площадь":
                    break;
                case "Скорость":
                    switch (cbFrom.Text)
                    {
                        case "см/сек":
                            break;
                        case "м/сек":
                            break;
                        case "футов/сек":
                            break;
                        case "миль/час":
                            break;
                        case "узлов":
                            break;
                        case "число Маха":
                            break;
                    }
                    break;
                case "Время":
                    switch (cbFrom.Text)
                    {
                        case "микросекунд":
                            break;
                        case "миллисекунд":
                            break;
                        case "секунд":
                            break;
                        case "минут":
                            break;
                        case "часов":
                            break;
                        case "дней":
                            break;
                        case "недель":
                            break;
                        case "лет":
                            break;
                    }
                    break;
                case "Мощность":
                    switch (cbFrom.Text)
                    {
                        case "ватт":
                            break;
                        case "киловатт":
                            break;
                        case "мегаватт":
                            break;
                        case "лошадиных сил":
                            break;
                        case "фут-фунтов/мин":
                            break;
                        case "БТЕ/мин":
                            break;
                    }
                    break;
                case "Данные":
                    switch (cbFrom.Text)
                    {
                        case "Бит":
                            break;
                        case "Байт":
                            break;
                        case "Килобит":
                            break;
                        case "Кибибиты":
                            break;
                        case "Килобайт":
                            break;
                        case "Кибибайты":
                            break;
                        case "Мегабит":
                            break;
                        case "Мебибиты":
                            break;
                        case "Мегабайт":
                            break;
                        case "Мебибайты":
                            break;
                        case "Гигабит":
                            break;
                        case "Гибибиты":
                            break;
                        case "Гигабайт":
                            break;
                        case "Гибибайты":
                            break;
                        case "Терабит":
                            break;
                        case "Тебибиты":
                            break;
                        case "Терабайт":
                            break;
                        case "Тебибайты":
                            break;
                        case "Петабит":
                            break;
                        case "Пебибиты":
                            break;
                        case "Петабайт":
                            break;
                        case "Пебибайты":
                            break;
                        case "Эксабиты":
                            break;
                        case "Эксбибиты":
                            break;
                        case "Эксабайты":
                            break;
                        case "Эксбибайты":
                            break;
                        case "Зетабиты":
                            break;
                        case "Зебибиты":
                            break;
                        case "Зетабайты":
                            break;
                        case "Зебибайты":
                            break;
                        case "Йоттабиты":
                            break;
                        case "Цобибиты":
                            break;
                        case "Йоттабайты":
                            break;
                        case "Йобибайты":
                            break;
                    }
                    break;
                case "Давление":
                    switch (cbFrom.Text)
                    {
                        case "Атмосферы":
                            break;
                        case "Бары":
                            break;
                        case "Паскали":
                            break;
                        case "Килопаскали":
                            break;
                        case "Милиметры ртутного столба":
                            break;
                        case "Фунты на квадратный дюйм":
                            break;
                    }
                    break;
                case "Угол":
                    switch (cbFrom.Text)
                    {
                        case "Градусы":
                            break;
                        case "Радианы":
                            break;
                        case "Градианы":
                            break;
                    }
                    break;
            }
        }
    }
}