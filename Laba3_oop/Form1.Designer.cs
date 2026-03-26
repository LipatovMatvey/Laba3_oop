using System.Windows.Forms.VisualStyles;

namespace Laba3_oop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            label8 = new Label();
            numericUpDown4 = new NumericUpDown();
            label9 = new Label();
            comboBox1 = new ComboBox();
            groupBoxDisplay = new GroupBox();
            txtDisplayInfo = new TextBox();
            btnShowInfo = new Button();
            btnClear = new Button();
            groupBoxInput = new GroupBox();
            groupBoxStatus = new GroupBox();
            resetButton = new Button();
            btnBack = new Button();
            label10 = new Label();
            groupBoxObjects = new GroupBox();
            lblCurrentObject = new Label();
            cmbObjectsList = new ComboBox();
            btnDeleteObject = new Button();
            lblObjectCount = new Label();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            groupBoxDisplay.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            groupBoxObjects.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Trebuchet MS", 11.25F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(18, 3);
            label1.Name = "label1";
            label1.Size = new Size(254, 60);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная работа №3\nСтуденты: Липатов М. Кузнецов Н.\r\nГруппа: 24ВП2";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(1, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 72);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(607, 11);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 1;
            label2.Text = "Тема: Порождающие паттерны";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Trebuchet MS", 9.75F);
            button1.Location = new Point(13, 18);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 2;
            button1.Text = "Создать объект";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Trebuchet MS", 9.75F);
            textBox1.Location = new Point(149, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F);
            label3.Location = new Point(13, 24);
            label3.Name = "label3";
            label3.Size = new Size(96, 36);
            label3.TabIndex = 4;
            label3.Text = "Наименование\r\nмагазина:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9.75F);
            label4.Location = new Point(13, 75);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 5;
            label4.Text = "Адрес магазина:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Trebuchet MS", 9.75F);
            textBox2.Location = new Point(149, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9.75F);
            label5.Location = new Point(13, 115);
            label5.Name = "label5";
            label5.Size = new Size(100, 18);
            label5.TabIndex = 7;
            label5.Text = "Число покупок:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown1.Location = new Point(166, 117);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(122, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 9.75F);
            label6.Location = new Point(13, 151);
            label6.Name = "label6";
            label6.Size = new Size(77, 36);
            label6.TabIndex = 9;
            label6.Text = "Количество\r\nтоваров:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown2.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown2.Location = new Point(165, 166);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(122, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 9.75F);
            label7.Location = new Point(13, 209);
            label7.Name = "label7";
            label7.Size = new Size(89, 18);
            label7.TabIndex = 11;
            label7.Text = "Средний чек:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(165, 206);
            numericUpDown3.Margin = new Padding(3, 2, 3, 2);
            numericUpDown3.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(122, 23);
            numericUpDown3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 9.75F);
            label8.Location = new Point(13, 242);
            label8.Name = "label8";
            label8.Size = new Size(120, 18);
            label8.TabIndex = 13;
            label8.Text = "Рейтинг магазина:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(165, 239);
            numericUpDown4.Margin = new Padding(3, 2, 3, 2);
            numericUpDown4.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(122, 23);
            numericUpDown4.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 9.75F);
            label9.Location = new Point(13, 277);
            label9.Name = "label9";
            label9.Size = new Size(112, 18);
            label9.TabIndex = 15;
            label9.Text = "Статус магазина:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Trebuchet MS", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Активен", "Неактивен" });
            comboBox1.Location = new Point(149, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 26);
            comboBox1.TabIndex = 16;
            // 
            // groupBoxDisplay
            // 
            groupBoxDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDisplay.Controls.Add(txtDisplayInfo);
            groupBoxDisplay.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxDisplay.Location = new Point(616, 100);
            groupBoxDisplay.Name = "groupBoxDisplay";
            groupBoxDisplay.Size = new Size(379, 314);
            groupBoxDisplay.TabIndex = 20;
            groupBoxDisplay.TabStop = false;
            groupBoxDisplay.Text = "Информация о магазине";
            // 
            // txtDisplayInfo
            // 
            txtDisplayInfo.Dock = DockStyle.Fill;
            txtDisplayInfo.Font = new Font("Consolas", 10F);
            txtDisplayInfo.Location = new Point(3, 19);
            txtDisplayInfo.Multiline = true;
            txtDisplayInfo.Name = "txtDisplayInfo";
            txtDisplayInfo.ReadOnly = true;
            txtDisplayInfo.ScrollBars = ScrollBars.Vertical;
            txtDisplayInfo.Size = new Size(373, 292);
            txtDisplayInfo.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShowInfo.Font = new Font("Trebuchet MS", 9.75F);
            btnShowInfo.Location = new Point(616, 421);
            btnShowInfo.Margin = new Padding(3, 4, 3, 4);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(128, 28);
            btnShowInfo.TabIndex = 38;
            btnShowInfo.Text = "Показать данные";
            btnShowInfo.Click += btnShowInfo_Click_1;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Font = new Font("Trebuchet MS", 9.75F);
            btnClear.Location = new Point(867, 421);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 28);
            btnClear.TabIndex = 37;
            btnClear.Text = "Очистить";
            btnClear.Click += btnClear_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(label9);
            groupBoxInput.Controls.Add(label3);
            groupBoxInput.Controls.Add(comboBox1);
            groupBoxInput.Controls.Add(textBox1);
            groupBoxInput.Controls.Add(label4);
            groupBoxInput.Controls.Add(textBox2);
            groupBoxInput.Controls.Add(label5);
            groupBoxInput.Controls.Add(numericUpDown1);
            groupBoxInput.Controls.Add(label6);
            groupBoxInput.Controls.Add(numericUpDown2);
            groupBoxInput.Controls.Add(label7);
            groupBoxInput.Controls.Add(numericUpDown3);
            groupBoxInput.Controls.Add(label8);
            groupBoxInput.Controls.Add(numericUpDown4);
            groupBoxInput.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxInput.Location = new Point(19, 103);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(306, 308);
            groupBoxInput.TabIndex = 18;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxStatus.Controls.Add(resetButton);
            groupBoxStatus.Controls.Add(button1);
            groupBoxStatus.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxStatus.Location = new Point(19, 417);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Size = new Size(306, 64);
            groupBoxStatus.TabIndex = 19;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Управление";
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.None;
            resetButton.Font = new Font("Trebuchet MS", 9.75F);
            resetButton.Location = new Point(155, 18);
            resetButton.Margin = new Padding(3, 4, 3, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(134, 32);
            resetButton.TabIndex = 17;
            resetButton.Text = "Сбросить поля";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Trebuchet MS", 9.75F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(887, 535);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 27;
            btnBack.Text = "ВЫХОД";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 9.75F);
            label10.Location = new Point(874, 380);
            label10.Name = "label10";
            label10.Size = new Size(0, 18);
            label10.TabIndex = 31;
            // 
            // groupBoxObjects
            // 
            groupBoxObjects.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxObjects.Controls.Add(lblCurrentObject);
            groupBoxObjects.Controls.Add(cmbObjectsList);
            groupBoxObjects.Controls.Add(btnDeleteObject);
            groupBoxObjects.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxObjects.Location = new Point(19, 487);
            groupBoxObjects.Name = "groupBoxObjects";
            groupBoxObjects.Size = new Size(306, 86);
            groupBoxObjects.TabIndex = 35;
            groupBoxObjects.TabStop = false;
            groupBoxObjects.Text = "Управление объектами";
            // 
            // lblCurrentObject
            // 
            lblCurrentObject.Anchor = AnchorStyles.None;
            lblCurrentObject.AutoSize = true;
            lblCurrentObject.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCurrentObject.ForeColor = Color.Black;
            lblCurrentObject.Location = new Point(9, 20);
            lblCurrentObject.Name = "lblCurrentObject";
            lblCurrentObject.Size = new Size(177, 18);
            lblCurrentObject.TabIndex = 0;
            lblCurrentObject.Text = "Текущий объект: не выбран";
            // 
            // cmbObjectsList
            // 
            cmbObjectsList.Anchor = AnchorStyles.None;
            cmbObjectsList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjectsList.Font = new Font("Trebuchet MS", 9.75F);
            cmbObjectsList.FormattingEnabled = true;
            cmbObjectsList.Location = new Point(9, 44);
            cmbObjectsList.Name = "cmbObjectsList";
            cmbObjectsList.Size = new Size(190, 26);
            cmbObjectsList.TabIndex = 1;
            cmbObjectsList.SelectionChangeCommitted += cmbObjectsList_SelectionChangeCommitted;
            // 
            // btnDeleteObject
            // 
            btnDeleteObject.Anchor = AnchorStyles.None;
            btnDeleteObject.BackColor = Color.White;
            btnDeleteObject.Font = new Font("Trebuchet MS", 9.75F);
            btnDeleteObject.Location = new Point(210, 38);
            btnDeleteObject.Name = "btnDeleteObject";
            btnDeleteObject.Size = new Size(90, 32);
            btnDeleteObject.TabIndex = 3;
            btnDeleteObject.Text = "Удалить";
            btnDeleteObject.UseVisualStyleBackColor = false;
            btnDeleteObject.Click += btnDeleteObject_Click;
            // 
            // lblObjectCount
            // 
            lblObjectCount.AutoSize = true;
            lblObjectCount.Font = new Font("Trebuchet MS", 9.75F);
            lblObjectCount.ForeColor = Color.Blue;
            lblObjectCount.Location = new Point(19, 82);
            lblObjectCount.Name = "lblObjectCount";
            lblObjectCount.Size = new Size(134, 18);
            lblObjectCount.TabIndex = 17;
            lblObjectCount.Text = "Создано объектов: 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(360, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 54);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип магазина";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Гипермаркет", "Минимаркет", "Премиум-магазин", "По умолчанию" });
            comboBox2.Location = new Point(7, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 26);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 580);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxObjects);
            Controls.Add(label10);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnShowInfo);
            Controls.Add(groupBoxDisplay);
            Controls.Add(groupBoxStatus);
            Controls.Add(groupBoxInput);
            Controls.Add(lblObjectCount);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 9.75F);
            MinimumSize = new Size(734, 619);
            Name = "Form1";
            Text = "Интернет-магазин (Вариант 11)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            groupBoxDisplay.ResumeLayout(false);
            groupBoxDisplay.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxObjects.ResumeLayout(false);
            groupBoxObjects.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private Label label8;
        private NumericUpDown numericUpDown4;
        private Label label9;
        private ComboBox comboBox1;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxStatus;
        private GroupBox groupBoxDisplay;
        private TextBox txtDisplayInfo;
        private Button btnShowInfo;
        private Button btnClear;
        private Button btnBack;
        private Label label10;
        private GroupBox groupBoxObjects;
        private ComboBox cmbObjectsList;
        private Button btnDeleteObject;
        private Label lblCurrentObject;
        private Button resetButton;
        private Label lblObjectCount;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
    }
}
