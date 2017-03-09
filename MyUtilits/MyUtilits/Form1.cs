using System;
using System.Windows.Forms;

namespace MyUtilits
{
    public partial class Utilaties : Form
    {
        /// <summary>
        /// Начальное значение счетчика
        /// </summary>
        Int32 count = 0;

        /// <summary>
        /// Переменная класса Random для хранения случайных чисел
        /// </summary>
        Random rnd;

        /// <summary>
        /// Массив специальнных символов для генерации паролей
        /// </summary>
        Char[] spec_char = new Char[] { '*','-','/','=','+','_','(',')','&','^','%','$','#','@','!','"','№',';',':','?','|'};

        /// <summary>
        /// Переменная класса MetricaConverter
        /// </summary>
        MetricaConverter m;

        /// <summary>
        /// Метод Utilaties инициализирует форму "Utilaties"
        /// </summary>
        public Utilaties()
        {
            // Инициализируем форму
            InitializeComponent();

            // Генератор случайных чисел 
            rnd = new Random();

            m = new MetricaConverter();

            // При запуске программы начинаем с единиц измерения длинны
            m.MetricaStart(cbMetrica);
        }

        /// <summary>
        /// Метод Form1_Load инициализирует форму программы
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNotePad();
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
            clbPassword.SetItemChecked(2, true);
            clbPassword.SetItemChecked(3, true);
        }

        /// <summary>
        /// Метод ItemExit_Click позволят обработать событие кнопки "Выход"
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void ItemExit_Click(object sender, EventArgs e) => this.Close();
        
        /// <summary>
        /// Метод ItemAbout_Click позволяет обработать событие "О программе"
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void ItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа Utilaties, \nсодержит ряд небольших программ, \nкоторые могут пригодиться в жизни. \nРазработчик: Цвиркун Ярослав \nПредложения по улучшению программы: \nyaroslav.tsvirkun.1992@outlook.com", "О программе");
        }

        /// <summary>
        /// Метод lblCount_Click позаоляет обработать событие метки
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void lblCount_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Метод bthMinus_Click позволяет обработать событие кнопки " - "
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void bthMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = Convert.ToString(count);
        }

        /// <summary>
        /// Метод btnZero_Clic позволяет обработать событие кнопки "Resеt"
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnZero_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
        }

        /// <summary>
        /// Метод btnPlus_Click позволяет обработать событие кнопки " + "
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = Convert.ToString(count);
        }

        /// <summary>
        /// Метод numericUpDownBefore_ValueChanged позволяет обработать событие
        /// и задать минимальное значение для генератора случайных чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownFrom_ValueChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод numericUpDownBefore_ValueChanged позволяет обработать событие
        /// и задать максимальное значение для генератора случайных чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownBefore_ValueChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод lbtFrom_Click позволяет обработать событие " От: "
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbtFrom_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Метод lbtBefore_Click позволяет обработать событие " До: "
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbtBefore_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Метод btnGen_Click позволяе сгенирирувать случайное число 
        /// в диапазоне от lblFrom до lblFefore
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnGen_Click(object sender, EventArgs e)
        {
            int n = rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownBefore.Value) + 1);
            lblRandom.Text = Convert.ToString(n);
            if(chRandom.Checked == true)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownBefore.Value));
                    i++;
                    if (i > 1000000) break;
                }
                if (i < 1000000) tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
        }

        /// <summary>
        /// Метод lblRandom_Click позволяет обработать событие метки " ? "
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void lblRandom_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Метод btnRandomClear_Click позволяет обработать событие кнопки "Очистить"
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnRandomClear_Click(object sender, EventArgs e) => tbRandom.Clear();
        
        /// <summary>
        /// Метод btnRandomCopy_Click позволяет копировать данные 
        /// с текстового поля  tbRandom_TextChanged
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnRandomCopy_Click(object sender, EventArgs e) => Clipboard.SetText(tbRandom.Text);
        

        /// <summary>
        /// Метод tbRandom_TextChanged инициализирует текстовое поле генератора
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tbRandom_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод cbRandom_CheckedChanged создает переключатель " без повторений "
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void cbRandom_CheckedChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод tsmiInsertDate_Click позволяет вставлять дату в блокнот автоматически
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tsmiInsertDate_Click(object sender, EventArgs e) => 
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        
        /// <summary>
        /// Метод rtbNotepad_TextChanged инициализирует текстовое поле блокнота
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void rtbNotepad_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод tsmiInsertDate_Click позволяет вставлять время в блокнот автоматически
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tsmiInsertTime_Click(object sender, EventArgs e) =>
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        
        /// <summary>
        /// Метод tsmiInsertDateAndTime_Click позволяет вставлять 
        /// дату и время в блокнот автоматически и одновременно
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tsmiInsertDateAndTime_Click(object sender, EventArgs e) =>
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToShortTimeString() + "\n");
       
        /// <summary>
        /// Метод tsmiSave_Click позволяет сохранять блокнот
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении");
            }
        }

        /// <summary>
        /// Метод tsmiLoad_Click позволяет загрузить блокнот
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tsmiLoad_Click(object sender, EventArgs e) => LoadNotePad();
        
        /// <summary>
        /// Метод LoadNotePad позволяет загрузить блокнот автоматически
        /// </summary>
        private void LoadNotePad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }
        }

        /// <summary>
        /// Метод tabPageGenerator_Click инициализирует форму генератора
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tabPageGenerator_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Метод labPasswordLength_Click инициализирует поле " Длина пароля: "
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void labPasswordLength_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Метод btnGeneratePassword_Click позволяет создать случайный пароль
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for(int i = 0; i < nudPassword.Value; i++)
            {
                // Записываем в переменную число элементов списка
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                // В переменную s записываем выбранный элемент
                string s = clbPassword.CheckedItems[n].ToString();
                // создаем ветлящийся список символов для генерации паролей
                switch (s)
                {
                    case "Цифры" : password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы" : password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы" : password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default : password += spec_char[rnd.Next(spec_char.Length)];
                        break;
                }
                tbNewGenPassword.Text = password;
                Clipboard.SetText(password);
            }
        }

        /// <summary>
        /// Метод nudPassword_ValueChanged задает длину пароля
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void nudPassword_ValueChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод btnCopy_Click создает кнопку, и позволяет с копировать пароль
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnCopy_Click(object sender, EventArgs e) => Clipboard.SetText(tbNewGenPassword.Text);
        
        /// <summary>
        /// Метод clbPassword_SelectedIndexChanged создает список символов для создания паролей
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void clbPassword_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод btnConverter_Click создает кнопку и позволяет с конвертировать единицы измерения
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnConverter_Click(object sender, EventArgs e)
        {
            m.MetricaCon(cbFrom, cbTo, cbMetrica, tbFrom, tbTo);
        }

        /// <summary>
        /// Метод tbFrom_TextChanged создает поле для вода значения конвертируемой единицы
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tbFrom_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод tbTo_TextChanged создает поле для вывода значения, после конвертации
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void tbTo_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод cbFrom_SelectedIndexChanged выводит список единиц конвертации
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод cbTo_SelectedIndexChanged выводит список единиц конвертации
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void cbTo_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Метод btnSwap_Click зоздает кнопку, которая обменивает местами
        /// методы cbFrom_SelectedIndexChanged и cbTo_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        /// <summary>
        /// Метод cbMetrica_SelectedIndexChanged загружает словарь единиц конвертации
        /// </summary>
        /// <param name="sender">Принимает параметр любого типа</param>
        /// <param name="e">Аргумент события</param>
        private void cbMetrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            m.MetricaLogic(cbFrom, cbTo, cbMetrica, tbFrom, tbTo);
        }
    }
}