namespace RZ_PlaipherShifr
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBefore = new System.Windows.Forms.TextBox();
            this.textAfter = new System.Windows.Forms.TextBox();
            this.mode_work = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matrixShowCheckbox = new System.Windows.Forms.CheckBox();
            this.exportResultButton = new System.Windows.Forms.Button();
            this.countsymlabel = new System.Windows.Forms.Label();
            this.countsym = new System.Windows.Forms.DomainUpDown();
            this.passphrase2 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.delFileCheckbox = new System.Windows.Forms.CheckBox();
            this.passphrase = new System.Windows.Forms.TextBox();
            this.abouttext = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.autorText = new System.Windows.Forms.Label();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.en_language = new System.Windows.Forms.RadioButton();
            this.ru_language = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBefore
            // 
            this.textBefore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBefore.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBefore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBefore.Location = new System.Drawing.Point(93, 290);
            this.textBefore.Multiline = true;
            this.textBefore.Name = "textBefore";
            this.textBefore.Size = new System.Drawing.Size(1124, 137);
            this.textBefore.TabIndex = 0;
            this.textBefore.Enter += new System.EventHandler(this.textBefore_Enter);
            this.textBefore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBefore_KeyDown);
            this.textBefore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBefore_KeyPress);
            this.textBefore.Leave += new System.EventHandler(this.textBefore_Leave);
            // 
            // textAfter
            // 
            this.textAfter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textAfter.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textAfter.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textAfter.Location = new System.Drawing.Point(94, 556);
            this.textAfter.Multiline = true;
            this.textAfter.Name = "textAfter";
            this.textAfter.ReadOnly = true;
            this.textAfter.Size = new System.Drawing.Size(1124, 137);
            this.textAfter.TabIndex = 1;
            this.textAfter.Text = "Здесь будет отображаться результат";
            this.textAfter.TextChanged += new System.EventHandler(this.textAfter_TextChanged);
            // 
            // mode_work
            // 
            this.mode_work.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mode_work.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode_work.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mode_work.FormattingEnabled = true;
            this.mode_work.Items.AddRange(new object[] {
            "Шифрование ",
            "Расшифрование",
            "Шифрование с добавлением сигнатуры",
            "Расшифрование с проверкой сигнатуры"});
            this.mode_work.Location = new System.Drawing.Point(756, 225);
            this.mode_work.Name = "mode_work";
            this.mode_work.Size = new System.Drawing.Size(461, 38);
            this.mode_work.TabIndex = 2;
            this.mode_work.TextChanged += new System.EventHandler(this.mode_work_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.matrixShowCheckbox);
            this.panel1.Controls.Add(this.exportResultButton);
            this.panel1.Controls.Add(this.countsymlabel);
            this.panel1.Controls.Add(this.countsym);
            this.panel1.Controls.Add(this.passphrase2);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.delFileCheckbox);
            this.panel1.Controls.Add(this.passphrase);
            this.panel1.Controls.Add(this.abouttext);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveToFileButton);
            this.panel1.Controls.Add(this.autorText);
            this.panel1.Controls.Add(this.loadFromFileButton);
            this.panel1.Controls.Add(this.en_language);
            this.panel1.Controls.Add(this.mode_work);
            this.panel1.Controls.Add(this.ru_language);
            this.panel1.Controls.Add(this.textBefore);
            this.panel1.Controls.Add(this.textAfter);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 846);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // matrixShowCheckbox
            // 
            this.matrixShowCheckbox.AutoSize = true;
            this.matrixShowCheckbox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.matrixShowCheckbox.Location = new System.Drawing.Point(385, 229);
            this.matrixShowCheckbox.Name = "matrixShowCheckbox";
            this.matrixShowCheckbox.Size = new System.Drawing.Size(365, 34);
            this.matrixShowCheckbox.TabIndex = 18;
            this.matrixShowCheckbox.Text = "Отобразить матрицу кодирования";
            this.matrixShowCheckbox.UseVisualStyleBackColor = true;
            this.matrixShowCheckbox.Visible = false;
            this.matrixShowCheckbox.CheckedChanged += new System.EventHandler(this.matrixShowCheckbox_CheckedChanged);
            // 
            // exportResultButton
            // 
            this.exportResultButton.BackColor = System.Drawing.Color.Blue;
            this.exportResultButton.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.exportResultButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.exportResultButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportResultButton.Location = new System.Drawing.Point(337, 699);
            this.exportResultButton.Name = "exportResultButton";
            this.exportResultButton.Size = new System.Drawing.Size(331, 85);
            this.exportResultButton.TabIndex = 17;
            this.exportResultButton.Text = "Отправить результат на расшифрование";
            this.exportResultButton.UseVisualStyleBackColor = false;
            this.exportResultButton.Visible = false;
            this.exportResultButton.Click += new System.EventHandler(this.exportResultButton_Click);
            // 
            // countsymlabel
            // 
            this.countsymlabel.AutoSize = true;
            this.countsymlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countsymlabel.Location = new System.Drawing.Point(773, 509);
            this.countsymlabel.Name = "countsymlabel";
            this.countsymlabel.Size = new System.Drawing.Size(230, 17);
            this.countsymlabel.TabIndex = 16;
            this.countsymlabel.Text = "Число символов в парольной фразе";
            // 
            // countsym
            // 
            this.countsym.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countsym.Items.Add("20");
            this.countsym.Items.Add("19");
            this.countsym.Items.Add("18");
            this.countsym.Items.Add("17");
            this.countsym.Items.Add("16");
            this.countsym.Items.Add("15");
            this.countsym.Items.Add("14");
            this.countsym.Items.Add("13");
            this.countsym.Items.Add("12");
            this.countsym.Items.Add("11");
            this.countsym.Items.Add("10");
            this.countsym.Items.Add("9");
            this.countsym.Items.Add("8");
            this.countsym.Items.Add("7");
            this.countsym.Items.Add("6");
            this.countsym.Items.Add("5");
            this.countsym.Items.Add("4");
            this.countsym.Location = new System.Drawing.Point(833, 465);
            this.countsym.Name = "countsym";
            this.countsym.ReadOnly = true;
            this.countsym.Size = new System.Drawing.Size(120, 31);
            this.countsym.TabIndex = 15;
            // 
            // passphrase2
            // 
            this.passphrase2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passphrase2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.passphrase2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passphrase2.Location = new System.Drawing.Point(328, 496);
            this.passphrase2.Name = "passphrase2";
            this.passphrase2.Size = new System.Drawing.Size(438, 35);
            this.passphrase2.TabIndex = 14;
            this.passphrase2.Text = "Введите парольную фразу ещё раз";
            this.passphrase2.Enter += new System.EventHandler(this.passphrase2_Enter);
            this.passphrase2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passphrase2_KeyDown);
            this.passphrase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passphrase2_KeyPress);
            this.passphrase2.Leave += new System.EventHandler(this.passphrase2_Leave);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Blue;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(1024, 446);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(193, 85);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Начать обработку";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // delFileCheckbox
            // 
            this.delFileCheckbox.AutoSize = true;
            this.delFileCheckbox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.delFileCheckbox.Location = new System.Drawing.Point(792, 734);
            this.delFileCheckbox.Name = "delFileCheckbox";
            this.delFileCheckbox.Size = new System.Drawing.Size(425, 34);
            this.delFileCheckbox.TabIndex = 12;
            this.delFileCheckbox.Text = "Удалить при сохранении исходный файл";
            this.delFileCheckbox.UseVisualStyleBackColor = true;
            this.delFileCheckbox.Visible = false;
            // 
            // passphrase
            // 
            this.passphrase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passphrase.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.passphrase.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passphrase.Location = new System.Drawing.Point(328, 446);
            this.passphrase.Name = "passphrase";
            this.passphrase.Size = new System.Drawing.Size(438, 35);
            this.passphrase.TabIndex = 11;
            this.passphrase.Text = "Введите парольную фразу";
            this.passphrase.Enter += new System.EventHandler(this.passphrase_Enter);
            this.passphrase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passphrase_KeyDown);
            this.passphrase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passphrase_KeyPress);
            this.passphrase.Leave += new System.EventHandler(this.passphrase_Leave);
            // 
            // abouttext
            // 
            this.abouttext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.abouttext.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.abouttext.ForeColor = System.Drawing.Color.Black;
            this.abouttext.Location = new System.Drawing.Point(93, 79);
            this.abouttext.Multiline = true;
            this.abouttext.Name = "abouttext";
            this.abouttext.Size = new System.Drawing.Size(1124, 126);
            this.abouttext.TabIndex = 10;
            this.abouttext.Text = resources.GetString("abouttext.Text");
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Navy;
            this.title.Location = new System.Drawing.Point(414, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(446, 40);
            this.title.TabIndex = 9;
            this.title.Text = "Реализация шифра Плейфера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(929, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 6;
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveToFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.saveToFileButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.saveToFileButton.Location = new System.Drawing.Point(93, 699);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(204, 85);
            this.saveToFileButton.TabIndex = 5;
            this.saveToFileButton.Text = "Сохранить в файл";
            this.saveToFileButton.UseVisualStyleBackColor = false;
            this.saveToFileButton.Visible = false;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // autorText
            // 
            this.autorText.AutoSize = true;
            this.autorText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.autorText.ForeColor = System.Drawing.Color.Navy;
            this.autorText.Location = new System.Drawing.Point(877, 782);
            this.autorText.Name = "autorText";
            this.autorText.Size = new System.Drawing.Size(341, 30);
            this.autorText.TabIndex = 7;
            this.autorText.Text = "Автор: Зайцева Ирина А-13а-20";
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.BackColor = System.Drawing.Color.LimeGreen;
            this.loadFromFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.loadFromFileButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.loadFromFileButton.Location = new System.Drawing.Point(93, 446);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(204, 85);
            this.loadFromFileButton.TabIndex = 4;
            this.loadFromFileButton.Text = "Загрузить из файла";
            this.loadFromFileButton.UseVisualStyleBackColor = false;
            this.loadFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // en_language
            // 
            this.en_language.AutoSize = true;
            this.en_language.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.en_language.Location = new System.Drawing.Point(248, 228);
            this.en_language.Name = "en_language";
            this.en_language.Size = new System.Drawing.Size(97, 34);
            this.en_language.TabIndex = 3;
            this.en_language.Text = "English";
            this.en_language.UseVisualStyleBackColor = true;
            this.en_language.CheckedChanged += new System.EventHandler(this.en_language_CheckedChanged);
            // 
            // ru_language
            // 
            this.ru_language.AutoSize = true;
            this.ru_language.Checked = true;
            this.ru_language.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ru_language.Location = new System.Drawing.Point(93, 227);
            this.ru_language.Name = "ru_language";
            this.ru_language.Size = new System.Drawing.Size(107, 34);
            this.ru_language.TabIndex = 2;
            this.ru_language.TabStop = true;
            this.ru_language.Text = "Русский";
            this.ru_language.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1293, 847);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр Плейфера";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBefore;
        private System.Windows.Forms.TextBox textAfter;
        private System.Windows.Forms.ComboBox mode_work;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton en_language;
        private System.Windows.Forms.RadioButton ru_language;
        private System.Windows.Forms.Label autorText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button loadFromFileButton;
        private System.Windows.Forms.TextBox abouttext;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox delFileCheckbox;
        private System.Windows.Forms.TextBox passphrase;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox passphrase2;
        private System.Windows.Forms.DomainUpDown countsym;
        private System.Windows.Forms.Label countsymlabel;
        private System.Windows.Forms.Button exportResultButton;
        private System.Windows.Forms.CheckBox matrixShowCheckbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

