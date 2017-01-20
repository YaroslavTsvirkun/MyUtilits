using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace MyUtilits
{
    partial class Utilaties
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region "Код, автоматически созданный конструктором форм Windows, а переписанный мной"
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilaties));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNoteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDateAndTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConverter = new System.Windows.Forms.TabPage();
            this.cbMetrica = new System.Windows.Forms.ComboBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tabPagePassword = new System.Windows.Forms.TabPage();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbNewGenPassword = new System.Windows.Forms.TextBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.labPasswordLength = new System.Windows.Forms.Label();
            this.nudPassword = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tabPageNotebook = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPageCount = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnZero = new System.Windows.Forms.Button();
            this.bthMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabPageGenerator = new System.Windows.Forms.TabPage();
            this.chRandom = new System.Windows.Forms.CheckBox();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.numericUpDownBefore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConverter.SuspendLayout();
            this.tabPagePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassword)).BeginInit();
            this.tabPageNotebook.SuspendLayout();
            this.tabPageCount.SuspendLayout();
            this.tabPageGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.tsmiNoteBook,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ItemExit
            // 
            this.ItemExit.Name = "ItemExit";
            this.ItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.ItemExit.Size = new System.Drawing.Size(162, 22);
            this.ItemExit.Text = "Выход";
            this.ItemExit.Click += new System.EventHandler(this.ItemExit_Click);
            // 
            // tsmiNoteBook
            // 
            this.tsmiNoteBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.tsmiInsertDateAndTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.tsmiNoteBook.Name = "tsmiNoteBook";
            this.tsmiNoteBook.Size = new System.Drawing.Size(65, 20);
            this.tsmiNoteBook.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(193, 22);
            this.tsmiInsertDate.Text = "Дата";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(193, 22);
            this.tsmiInsertTime.Text = "Время";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // tsmiInsertDateAndTime
            // 
            this.tsmiInsertDateAndTime.Name = "tsmiInsertDateAndTime";
            this.tsmiInsertDateAndTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.tsmiInsertDateAndTime.Size = new System.Drawing.Size(193, 22);
            this.tsmiInsertDateAndTime.Text = "Дата и Время";
            this.tsmiInsertDateAndTime.Click += new System.EventHandler(this.tsmiInsertDateAndTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(193, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(193, 22);
            this.tsmiLoad.Text = "Загрузить";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // ItemAbout
            // 
            this.ItemAbout.Name = "ItemAbout";
            this.ItemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.ItemAbout.Size = new System.Drawing.Size(201, 22);
            this.ItemAbout.Text = "О программе";
            this.ItemAbout.Click += new System.EventHandler(this.ItemAbout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConverter);
            this.tabControl.Controls.Add(this.tabPagePassword);
            this.tabControl.Controls.Add(this.tabPageNotebook);
            this.tabControl.Controls.Add(this.tabPageCount);
            this.tabControl.Controls.Add(this.tabPageGenerator);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(292, 237);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageConverter
            // 
            this.tabPageConverter.Controls.Add(this.cbMetrica);
            this.tabPageConverter.Controls.Add(this.btnSwap);
            this.tabPageConverter.Controls.Add(this.tbTo);
            this.tabPageConverter.Controls.Add(this.tbFrom);
            this.tabPageConverter.Controls.Add(this.btnConverter);
            this.tabPageConverter.Controls.Add(this.cbTo);
            this.tabPageConverter.Controls.Add(this.cbFrom);
            this.tabPageConverter.Location = new System.Drawing.Point(4, 22);
            this.tabPageConverter.Name = "tabPageConverter";
            this.tabPageConverter.Size = new System.Drawing.Size(284, 211);
            this.tabPageConverter.TabIndex = 4;
            this.tabPageConverter.Text = "Конвертер";
            this.tabPageConverter.UseVisualStyleBackColor = true;
            // 
            // cbMetrica
            // 
            this.cbMetrica.FormattingEnabled = true;
            this.cbMetrica.Items.AddRange(new object[] {
            "Длина",
            "Вес",
            "Температура",
            "Энергия",
            "Объем",
            "Площадь",
            "Скорость",
            "Время",
            "Мощность",
            "Данные",
            "Давление",
            "Угол"});
            this.cbMetrica.Location = new System.Drawing.Point(83, 3);
            this.cbMetrica.Name = "cbMetrica";
            this.cbMetrica.Size = new System.Drawing.Size(121, 21);
            this.cbMetrica.TabIndex = 6;
            this.cbMetrica.Text = "Длина";
            this.cbMetrica.SelectedIndexChanged += new System.EventHandler(this.cbMetrica_SelectedIndexChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(104, 42);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<--->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(201, 74);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(83, 20);
            this.tbTo.TabIndex = 4;
            this.tbTo.TextChanged += new System.EventHandler(this.tbTo_TextChanged);
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(0, 71);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(86, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.TextChanged += new System.EventHandler(this.tbFrom_TextChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(92, 71);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(103, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Конвертировать";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "нм",
            "мкм",
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "сух. миля",
            "мор. миля"});
            this.cbTo.Location = new System.Drawing.Point(201, 44);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(83, 21);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "мм";
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "нм",
            "мкм",
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "сух. миля",
            "мор. миля"});
            this.cbFrom.Location = new System.Drawing.Point(0, 44);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(86, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "мм";
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // tabPagePassword
            // 
            this.tabPagePassword.Controls.Add(this.btnCopy);
            this.tabPagePassword.Controls.Add(this.tbNewGenPassword);
            this.tabPagePassword.Controls.Add(this.btnGeneratePassword);
            this.tabPagePassword.Controls.Add(this.labPasswordLength);
            this.tabPagePassword.Controls.Add(this.nudPassword);
            this.tabPagePassword.Controls.Add(this.clbPassword);
            this.tabPagePassword.Location = new System.Drawing.Point(4, 22);
            this.tabPagePassword.Name = "tabPagePassword";
            this.tabPagePassword.Size = new System.Drawing.Size(284, 211);
            this.tabPagePassword.TabIndex = 3;
            this.tabPagePassword.Text = "Пароли";
            this.tabPagePassword.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(151, 113);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbNewGenPassword
            // 
            this.tbNewGenPassword.Location = new System.Drawing.Point(9, 143);
            this.tbNewGenPassword.Name = "tbNewGenPassword";
            this.tbNewGenPassword.Size = new System.Drawing.Size(259, 20);
            this.tbNewGenPassword.TabIndex = 4;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(8, 113);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(136, 23);
            this.btnGeneratePassword.TabIndex = 3;
            this.btnGeneratePassword.Text = "Сгенирирувать пароль";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // labPasswordLength
            // 
            this.labPasswordLength.AutoSize = true;
            this.labPasswordLength.Location = new System.Drawing.Point(0, 71);
            this.labPasswordLength.Name = "labPasswordLength";
            this.labPasswordLength.Size = new System.Drawing.Size(82, 13);
            this.labPasswordLength.TabIndex = 2;
            this.labPasswordLength.Text = "Длина пароля:";
            this.labPasswordLength.Click += new System.EventHandler(this.labPasswordLength_Click);
            // 
            // nudPassword
            // 
            this.nudPassword.Location = new System.Drawing.Point(0, 87);
            this.nudPassword.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nudPassword.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassword.Name = "nudPassword";
            this.nudPassword.Size = new System.Drawing.Size(151, 20);
            this.nudPassword.TabIndex = 1;
            this.nudPassword.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPassword.ValueChanged += new System.EventHandler(this.nudPassword_ValueChanged);
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Специальные символы"});
            this.clbPassword.Location = new System.Drawing.Point(0, 0);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(151, 64);
            this.clbPassword.TabIndex = 0;
            this.clbPassword.SelectedIndexChanged += new System.EventHandler(this.clbPassword_SelectedIndexChanged);
            // 
            // tabPageNotebook
            // 
            this.tabPageNotebook.Controls.Add(this.rtbNotepad);
            this.tabPageNotebook.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotebook.Name = "tabPageNotebook";
            this.tabPageNotebook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotebook.Size = new System.Drawing.Size(284, 211);
            this.tabPageNotebook.TabIndex = 2;
            this.tabPageNotebook.Text = "Блокнот";
            this.tabPageNotebook.UseVisualStyleBackColor = true;
            this.tabPageNotebook.UseWaitCursor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(278, 205);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            this.rtbNotepad.UseWaitCursor = true;
            this.rtbNotepad.TextChanged += new System.EventHandler(this.rtbNotepad_TextChanged);
            // 
            // tabPageCount
            // 
            this.tabPageCount.Controls.Add(this.lblCount);
            this.tabPageCount.Controls.Add(this.btnZero);
            this.tabPageCount.Controls.Add(this.bthMinus);
            this.tabPageCount.Controls.Add(this.btnPlus);
            this.tabPageCount.Location = new System.Drawing.Point(4, 22);
            this.tabPageCount.Name = "tabPageCount";
            this.tabPageCount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCount.Size = new System.Drawing.Size(284, 211);
            this.tabPageCount.TabIndex = 0;
            this.tabPageCount.Text = "Счетчик";
            this.tabPageCount.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(117, 94);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(9, 89);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 2;
            this.btnZero.Text = "Reset";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // bthMinus
            // 
            this.bthMinus.Location = new System.Drawing.Point(55, 118);
            this.bthMinus.Name = "bthMinus";
            this.bthMinus.Size = new System.Drawing.Size(75, 23);
            this.bthMinus.TabIndex = 1;
            this.bthMinus.Text = "-";
            this.bthMinus.UseVisualStyleBackColor = true;
            this.bthMinus.Click += new System.EventHandler(this.bthMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(55, 60);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tabPageGenerator
            // 
            this.tabPageGenerator.Controls.Add(this.chRandom);
            this.tabPageGenerator.Controls.Add(this.btnRandomCopy);
            this.tabPageGenerator.Controls.Add(this.btnRandomClear);
            this.tabPageGenerator.Controls.Add(this.tbRandom);
            this.tabPageGenerator.Controls.Add(this.lblBefore);
            this.tabPageGenerator.Controls.Add(this.lblFrom);
            this.tabPageGenerator.Controls.Add(this.btnGen);
            this.tabPageGenerator.Controls.Add(this.lblRandom);
            this.tabPageGenerator.Controls.Add(this.numericUpDownBefore);
            this.tabPageGenerator.Controls.Add(this.numericUpDownFrom);
            this.tabPageGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenerator.Name = "tabPageGenerator";
            this.tabPageGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerator.Size = new System.Drawing.Size(284, 211);
            this.tabPageGenerator.TabIndex = 1;
            this.tabPageGenerator.Text = "Генератор";
            this.tabPageGenerator.UseVisualStyleBackColor = true;
            this.tabPageGenerator.Click += new System.EventHandler(this.tabPageGenerator_Click);
            // 
            // chRandom
            // 
            this.chRandom.AutoSize = true;
            this.chRandom.Location = new System.Drawing.Point(34, 33);
            this.chRandom.Name = "chRandom";
            this.chRandom.Size = new System.Drawing.Size(106, 17);
            this.chRandom.TabIndex = 9;
            this.chRandom.Text = "без повторений";
            this.chRandom.UseVisualStyleBackColor = true;
            this.chRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Location = new System.Drawing.Point(54, 188);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(75, 23);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Копировать";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.btnRandomCopy_Click);
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Location = new System.Drawing.Point(54, 167);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(75, 23);
            this.btnRandomClear.TabIndex = 7;
            this.btnRandomClear.Text = "Очистить";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.btnRandomClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(168, 6);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(100, 197);
            this.tbRandom.TabIndex = 6;
            this.tbRandom.TextChanged += new System.EventHandler(this.tbRandom_TextChanged);
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(3, 101);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(25, 13);
            this.lblBefore.TabIndex = 5;
            this.lblBefore.Text = "До:";
            this.lblBefore.Click += new System.EventHandler(this.lbtBefore_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(5, 56);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(23, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "От:";
            this.lblFrom.Click += new System.EventHandler(this.lbtFrom_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(54, 125);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "Число?";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(85, 151);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(13, 13);
            this.lblRandom.TabIndex = 2;
            this.lblRandom.Text = "?";
            this.lblRandom.Click += new System.EventHandler(this.lblRandom_Click);
            // 
            // numericUpDownBefore
            // 
            this.numericUpDownBefore.Location = new System.Drawing.Point(34, 99);
            this.numericUpDownBefore.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBefore.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownBefore.Name = "numericUpDownBefore";
            this.numericUpDownBefore.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBefore.TabIndex = 1;
            this.numericUpDownBefore.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownBefore.ValueChanged += new System.EventHandler(this.numericUpDownBefore_ValueChanged);
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(34, 56);
            this.numericUpDownFrom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownFrom.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFrom.TabIndex = 0;
            this.numericUpDownFrom.ValueChanged += new System.EventHandler(this.numericUpDownFrom_ValueChanged);
            // 
            // Utilaties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 261);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Utilaties";
            this.Text = "Utilaties";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageConverter.ResumeLayout(false);
            this.tabPageConverter.PerformLayout();
            this.tabPagePassword.ResumeLayout(false);
            this.tabPagePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassword)).EndInit();
            this.tabPageNotebook.ResumeLayout(false);
            this.tabPageCount.ResumeLayout(false);
            this.tabPageCount.PerformLayout();
            this.tabPageGenerator.ResumeLayout(false);
            this.tabPageGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem ItemExit;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem ItemAbout;
        private TabControl tabControl;
        private TabPage tabPageCount;
        private Label lblCount;
        private Button btnZero;
        private Button bthMinus;
        private Button btnPlus;
        private TabPage tabPageGenerator;
        private Label lblBefore;
        private Label lblFrom;
        private Button btnGen;
        private Label lblRandom;
        private NumericUpDown numericUpDownBefore;
        private NumericUpDown numericUpDownFrom;
        private TextBox tbRandom;
        private Button btnRandomClear;
        private Button btnRandomCopy;
        private CheckBox chRandom;
        private TabPage tabPageNotebook;
        private RichTextBox rtbNotepad;
        private ToolStripMenuItem tsmiNoteBook;
        private ToolStripMenuItem tsmiInsertDate;
        private ToolStripMenuItem tsmiInsertTime;
        private ToolStripMenuItem tsmiInsertDateAndTime;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiSave;
        private ToolStripMenuItem tsmiLoad;
        private TabPage tabPagePassword;
        private CheckedListBox clbPassword;
        private Label labPasswordLength;
        private NumericUpDown nudPassword;
        private TextBox tbNewGenPassword;
        private Button btnGeneratePassword;
        private Button btnCopy;
        private TabPage tabPageConverter;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Button btnConverter;
        private ComboBox cbTo;
        private ComboBox cbFrom;
        private Button btnSwap;
        private ComboBox cbMetrica;
    }
}