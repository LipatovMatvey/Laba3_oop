using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba3_oop
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Текущий активный объект интернет-магазина
        /// </summary>
        private InternetShop CurrentShop;

        /// <summary>
        /// Коллекция для хранения всех созданных объектов интернет-магазинов
        /// </summary>
        private List<InternetShop> ShopsList;

        /// <summary>
        /// Объект билдера
        /// </summary>
        ShopBuilder CurrentShopBuilder = new DefaultShopBuilder();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ShopsList = new List<InternetShop>();
            comboBox2.SelectedIndex = 3;
            BoxMessage.ShowNativeMessageBox("Приветствие", "Лабораторная работа № 3. Порождающие паттерны \n\rBuilder(Строитель)\n\rГруппа: " +
                "24ВП2\r\nБригада 11: Кузнецов Н.Д. Липатов М.В.", BoxMessage.InfoCode);
        }

        /// <summary>
        /// Обработчик кнопки закрытия
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void BtnBack(object sender, EventArgs e)
        {
            //BoxMessage.ShowNativeMessageBox("Покатствие", "Ждем Вас снова!", BoxMessage.InfoCode);
            Close();
        }

        /// <summary>
        /// Обработчик кнопки создания объекта интернет-магазина
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();
                string address = textBox2.Text.Trim();

                if (!InputChecker.IsValidShopName(name))
                {
                    BoxMessage.ShowNativeMessageBox("Ошибка", "Имя магазина некорректно", BoxMessage.ErrorCode);
                    return;
                }
                if (!InputChecker.IsValidAddress(address))
                {
                    BoxMessage.ShowNativeMessageBox("Ошибка", "Адрес магазина некорректен", BoxMessage.ErrorCode);
                    return;
                }

                int purchases = (int)numericUpDown1.Value;
                int products = (int)numericUpDown2.Value;
                double avgCheck = (double)numericUpDown3.Value;
                double rating = (double)numericUpDown4.Value;
                int active = comboBox1.SelectedIndex;
                bool isActive = active == 0 ? true : false;
                string BuilderName = (string)comboBox2.SelectedItem;
                switch (BuilderName)
                {
                    case "По умолчанию":
                        CurrentShop = CurrentShopBuilder.Build();
                        showFieldsData(CurrentShop);
                        break;
                    case "Крупный":
                        CurrentShop = CurrentShopBuilder.Build();
                        break;
                    case "Маленький":
                        CurrentShop = CurrentShopBuilder.Build();
                        break;
                    case "Премиум":
                        CurrentShop = CurrentShopBuilder.Build();
                        break;
                }
                BoxMessage.ShowNativeMessageBox("Успех", "Объект создан с при помощи билдера " + BuilderName, BoxMessage.SuccessCode);
                ShopsList.Add(CurrentShop);
                UpdateObjectsCount();
                UpdateObjectsList();
                DisplayCurrentShopInfo();
            }
            catch (ArgumentException ex)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", $"Ошибка создания: {ex.Message}", BoxMessage.ErrorCode);
            }
        }

        /// <summary>
        /// Обновляет отображение количества созданных объектов в интерфейсе
        /// </summary>
        private void UpdateObjectsCount()
        {
            lblObjectCount.Text = $"Создано объектов: {ShopsList.Count}";
        }

        /// <summary>
        /// Обновляет список объектов в комбобоксе
        /// </summary>
        private void UpdateObjectsList()
        {
            cmbObjectsList.Items.Clear();
            for (int i = 0; i < ShopsList.Count; i++)
            {
                string displayName = $"Объект {i + 1}: {ShopsList[i].Name}";
                if (ShopsList[i] == CurrentShop)
                {
                    displayName += " (текущий)";
                }
                cmbObjectsList.Items.Add(displayName);
            }
            if (CurrentShop != null)
            {
                int currentIndex = ShopsList.IndexOf(CurrentShop);
                if (currentIndex >= 0)
                {
                    cmbObjectsList.SelectedIndex = currentIndex;
                }
                lblCurrentObject.Text = $"Текущий объект: {CurrentShop.Name}";
            }
            else
            {
                lblCurrentObject.Text = "Текущий объект: не выбран";
            }
        }

        /// <summary>
        /// Отображает информацию о текущем объекте в текстовом поле
        /// </summary>
        private void DisplayCurrentShopInfo()
        {
            if (CurrentShop == null)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", "Сначала создайте объект!", BoxMessage.ErrorCode);
                return;
            }
            txtDisplayInfo.Clear();
            txtDisplayInfo.AppendText(CurrentShop.ToString());
        }

        /// <summary>
        /// Обработчик кнопки очистки текстового поля
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtDisplayInfo.Clear();
        }

        /// <summary>
        /// Обработчик кнопки отображения полной информации о текущем объекте
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            DisplayCurrentShopInfo();
        }

        /// <summary>
        /// Удаление выбранного объекта
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            if (cmbObjectsList.SelectedIndex >= 0 && cmbObjectsList.SelectedIndex < ShopsList.Count)
            {
                int indexToDelete = cmbObjectsList.SelectedIndex;
                string deletedName = ShopsList[indexToDelete].Name;
                int result = BoxMessage.ShowNativeMessageBox("Подтверждение", $"Удалить объект '{deletedName}'?", BoxMessage.ConfirmCode);
                if (result == 6)
                {
                    ShopsList.RemoveAt(indexToDelete);
                    if (ShopsList.Count == 0)
                    {
                        CurrentShop = null;
                        txtDisplayInfo.Clear();
                    }
                    else if (CurrentShop != null && indexToDelete <= ShopsList.IndexOf(CurrentShop))
                    {
                        CurrentShop = ShopsList[0];
                        DisplayCurrentShopInfo();
                    }
                    UpdateObjectsCount();
                    UpdateObjectsList();
                    resetFields();
                    txtDisplayInfo.Text = "";
                    BoxMessage.ShowNativeMessageBox("Успех", "Объект удален", BoxMessage.SuccessCode);
                }
            }
            else
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", "Выберите объект для удаления!", BoxMessage.ErrorCode);
            }
        }

        /// <summary>
        /// Сброс значений полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        /// <summary>
        /// Очищает все поля формы
        /// </summary>
        private void resetFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0.00m;
            numericUpDown4.Value = 0.0m;
            comboBox1.SelectedIndex = -1;
        }

        /// <summary>
        /// Обработчик события выбора объекта в списке
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void cmbObjectsList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CurrentShop = ShopsList[cmbObjectsList.SelectedIndex];
            UpdateObjectsList();
            DisplayCurrentShopInfo();
            showFieldsData(CurrentShop);
            BoxMessage.ShowNativeMessageBox("Успех", $"Переключено на объект: {CurrentShop.Name}", BoxMessage.SuccessCode);
        }

        /// <summary>
        /// Заполняет поля формы данными из указанного объекта интернет-магазина
        /// </summary>
        /// <param name="shop">Объект интернет-магазина</param>
        private void showFieldsData(InternetShop shop)
        {
            textBox1.Text = shop.Name;
            textBox2.Text = shop.Address;
            numericUpDown1.Value = shop.PurchaseCount;
            numericUpDown2.Value = shop.ProductCount;
            numericUpDown3.Value = (decimal)shop.AverageCheck;
            numericUpDown4.Value = (decimal)shop.Rating;
            comboBox1.SelectedIndex = shop.IsActive == true ? 0 : 1;
        }

        /// <summary>
        /// Обработчик кнопки очистки текстового поля
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplayInfo.Clear();

        }

        /// <summary>
        /// Обработчик кнопки отображения полной информации о текущем объекте
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void btnShowInfo_Click_1(object sender, EventArgs e)
        {
            DisplayCurrentShopInfo();
        }

        /// <summary>
        /// Заполняет поля формы значениями по умолчанию в зависимости от выбранного типа магазина
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие</param>
        /// <param name="e">Аргументы события</param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            if (index == -1)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", "Сначала выберите тип магазина", BoxMessage.ErrorCode);
                return;
            }
            switch (index)
            {
                case 0:
                    textBox1.Text = "Крупный интернет-магазин";
                    textBox2.Text = "Не указан";
                    numericUpDown1.Value = 1500;
                    numericUpDown2.Value = 5000;
                    numericUpDown3.Value = 5000.0m;
                    numericUpDown4.Value = 4.5m;
                    comboBox1.SelectedIndex = 0;
                    CurrentShopBuilder = new LargeShopBuilder();
                    break;
                case 1:
                    textBox1.Text = "Маленький интернет-магазин";
                    textBox2.Text = "Не указан";
                    numericUpDown1.Value = 40;
                    numericUpDown2.Value = 150;
                    numericUpDown3.Value = 400.0m;
                    numericUpDown4.Value = 3.4m;
                    comboBox1.SelectedIndex = 0;
                    CurrentShopBuilder = new SmallShopBuilder();
                    break;
                case 2:
                    textBox1.Text = "Премиум интернет-магазин";
                    textBox2.Text = "Не указан";
                    numericUpDown1.Value = 2500;
                    numericUpDown2.Value = 5000;
                    numericUpDown3.Value = 5000.0m;
                    numericUpDown4.Value = 4.9m;
                    comboBox1.SelectedIndex = 0;
                    CurrentShopBuilder = new PremiumShopBuilder();
                    break;
                case 3:
                    textBox1.Text = "Noname";
                    textBox2.Text = "Noaddress";
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    numericUpDown3.Value = 0.0m;
                    numericUpDown4.Value = 0.0m;
                    comboBox1.SelectedIndex = 1;
                    CurrentShopBuilder = new DefaultShopBuilder();
                    break;
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле ввода названия магазина
        /// Передаёт введённое имя текущему строителю
        /// </summary>
        /// <param name="sender">Поле ввода textBox1</param>
        /// <param name="e">Аргументы события</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textHolder)
            {
                CurrentShopBuilder.InstallName(textHolder.Text);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле ввода адреса магазина
        /// Передаёт введённый адрес текущему строителю
        /// </summary>
        /// <param name="sender">Поле ввода textBox2</param>
        /// <param name="e">Аргументы события</param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textHolder)
            {
                CurrentShopBuilder.InstallAddress(textHolder.Text);
            }
        }

        /// <summary>
        /// Обработчик изменения количества покупок
        /// Передаёт новое значение строителю
        /// </summary>
        /// <param name="sender">Элемент numericUpDown1</param>
        /// <param name="e">Аргументы события</param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.NumericUpDown valueHolder)
            {
                CurrentShopBuilder.InstallPurchaseCount((int)valueHolder.Value);
            }
        }

        /// <summary>
        /// Обработчик изменения количества товаров
        /// Передаёт новое значение строителю
        /// </summary>
        /// <param name="sender">Элемент numericUpDown2</param>
        /// <param name="e">Аргументы события</param>
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.NumericUpDown valueHolder)
            {
                CurrentShopBuilder.InstallProductCount((int)valueHolder.Value);
            }
        }

        /// <summary>
        /// Обработчик изменения среднего чека
        /// Передаёт новое значение строителю
        /// </summary>
        /// <param name="sender">Элемент numericUpDown3</param>
        /// <param name="e">Аргументы события</param>
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.NumericUpDown valueHolder)
            {
                CurrentShopBuilder.InstallAverageCheck((double)valueHolder.Value);
            }
        }

        /// <summary>
        /// Обработчик изменения рейтинга магазина
        /// Передаёт новое значение строителю
        /// </summary>
        /// <param name="sender">Элемент numericUpDown4</param>
        /// <param name="e">Аргументы события</param>
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.NumericUpDown valueHolder)
            {
                CurrentShopBuilder.InstallRating((double)valueHolder.Value);
            }
        }

        /// <summary>
        /// Обработчик изменения выбора статуса активности магазина
        /// Устанавливает флаг активности в строителе
        /// </summary>
        /// <param name="sender">Элемент comboBox1</param>
        /// <param name="e">Аргументы события</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.ComboBox valueHolder)
            {
                bool status = comboBox1.SelectedIndex == 1 ? true : false;
                CurrentShopBuilder.InstallIsActive(status);
            }
        }

        /// <summary>
        /// Обработчик выбора типа магазина
        /// Заполняет поля формы значениями-примерами и переключает текущий строитель
        /// </summary>
        /// <param name="sender">Элемент comboBox2</param>
        /// <param name="e">Аргументы события</param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;

            switch (index)
            {
                case 0:
                    textBox1.Text = "Крупный интернет-магазин";
                    textBox2.Text = "Не указан";
                    numericUpDown1.Value = 1500;
                    numericUpDown2.Value = 5000;
                    numericUpDown3.Value = 5000.0m;
                    numericUpDown4.Value = 4.5m;
                    comboBox1.SelectedIndex = 0;
                    CurrentShopBuilder = new LargeShopBuilder();
                    break;
                case 1:
                    textBox1.Text = "Маленький интернет-магазин";
                    textBox2.Text = "Не указан";
                    numericUpDown1.Value = 40;
                    numericUpDown2.Value = 150;
                    numericUpDown3.Value = 400.0m;
                    numericUpDown4.Value = 3.4m;
                    comboBox1.SelectedIndex = 0;
                    CurrentShopBuilder = new SmallShopBuilder();
                    break;
                case 2:
                    textBox1.Text = "Премиум интернет-магазин";
                    textBox2.Text = "Не указан";
                    numericUpDown1.Value = 2500;
                    numericUpDown2.Value = 5000;
                    numericUpDown3.Value = 5000.0m;
                    numericUpDown4.Value = 4.9m;
                    comboBox1.SelectedIndex = 0;
                    CurrentShopBuilder = new PremiumShopBuilder();
                    break;
                case 3:
                    textBox1.Text = "Noname";
                    textBox2.Text = "Noaddress";
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    numericUpDown3.Value = 0.0m;
                    numericUpDown4.Value = 0.0m;
                    comboBox1.SelectedIndex = 1;
                    CurrentShopBuilder = new DefaultShopBuilder();
                    break;
            }
        }
    }
}
