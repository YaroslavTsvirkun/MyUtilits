using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtilits
{
    class Converter
    {
        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения
        /// </summary>
        public Dictionary<String, Double> metricaCurrent { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения длинны
        /// </summary>
        public Dictionary<String, Double> metricaLength { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения веса
        /// </summary>
        public Dictionary<String, Double> metricaWeight { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения температуры
        /// </summary>
        public Dictionary<String, Double> metricaTemperature { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения энергии
        /// </summary>
        public Dictionary<String, Double> metricaEnergy { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения объема
        /// </summary>
        public Dictionary<String, Double> metricaVolume { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения площади
        /// </summary>
        public Dictionary<String, Double> metricaArea { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения скорости
        /// </summary>
        public Dictionary<String, Double> metricaSpeed { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения времени
        /// </summary>
        public Dictionary<String, Double> metricaTime { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения мощности
        /// </summary>
        public Dictionary<String, Double> metricaPower { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения данных
        /// </summary>
        public Dictionary<String, Double> metricaData { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения давления
        /// </summary>
        public Dictionary<String, Double> metricaPressure { get; set; }

        /// <summary>
        /// Переменная класса Dictionary для создания словаря единиц измерения углов
        /// </summary>
        public Dictionary<String, Double> metricaAngle { get; set; }

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
            double metricaFrom = metricaCurrent[cbFrom.Text];
            double metricaTo = metricaCurrent[cbTo.Text];
            double convert = Convert.ToDouble(tbFrom.Text);
            switch (cbMetrica.Text)
            {
                case "Длина":
                    tbTo.Text = (convert * metricaFrom / metricaTo).ToString();
                    break;
                case "Вес":
                    tbTo.Text = (convert * metricaFrom / metricaTo).ToString();
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
                    break;
                case "Объем":
                    break;
                case "Площадь":
                    break;
                case "Скорость":
                    break;
                case "Время":
                    break;
                case "Мощность":
                    break;
                case "Данные":
                    break;
                case "Давление":
                    break;
                case "Угол":
                    break;
            } // tbTo.Text = ((((9 / 5) * convert) + 32) * (metricaFrom / metricaTo)).ToString();
        }
    }
}