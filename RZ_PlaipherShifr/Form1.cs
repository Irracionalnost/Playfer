using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RZ_PlaipherShifr
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> russian_language = new Dictionary<string, string>()
        {
            ["globtitle"] = "Шифр Плейфера",
            ["title"] = "Реализация шифра Плейфера",
            ["load_from_file"] = "Загрузить из файла",
            ["save_to_file"] = "Сохранить в файл",
            ["abouttext"] = "Поддерживается работа на русском и английском языке. Для этого необходимо выбрать соответствующий переключатель. Все символы будут переведены в верхний регистр. Символы, не принадлежащие латинскому или кириллическому алфавиту, будут проигнорированы.",
            ["textBefore"] = "Введите текст для шифрования или загрузите его из файла",
            ["textBefore2"] = "Введите текст для расшифрования или загрузите его из файла",
            ["textAfter"] = "Здесь будет отображаться результат",
            ["passphrasetext"] = "Введите парольную фразу",
            ["passphrase2text"] = "Введите парольную фразу ещё раз",
            ["mode_encodingtext"] = "Шифрование",
            ["mode_decodingtext"] = "Расшифрование",
            ["mode_encodingtextsign"] = "Шифрование с добавлением сигнатуры",
            ["mode_decodingtextsign"] = "Расшифрование с проверкой сигнатуры",
            ["delcheckboxtext"] = "Удалить при сохранении исходный файл",
            ["autortext"] = "Автор: Зайцева Ирина А-13а-20",
            ["startbutton"] = "Начать обработку",
            ["countsymlabel"] = "Число символов в парольной фразе",
            ["error1"] = "Введите исходный текст",
            ["error2"] = "Введите парольную фразу.",
            ["error3"] = "Парольная фраза должна содержать хотя бы ",
            ["error4"] = "Повторно введите парольную фразу",
            ["error5"] = "Парольные фразы не совпадают",
            ["error6"] = "Выбран русский язык. Смените раскладку клавиатуры.",
            ["error7"] = "Неверный пароль",
            ["showmatrix"] = "Отобразить матрицу кодирования",
            ["showmatrixtext"] = "Отображение матрицы кодирования",
            ["signature"] = "ИРИНАЗАЙЦЕВА"
        };
        private Dictionary<string, string> english_language = new Dictionary<string, string>()
        {
            ["globtitle"] = "Playfair cipher",
            ["title"] = "Implementation of the Playfair cipher",
            ["load_from_file"] = "Load from file",
            ["save_to_file"] = "Save to file",
            ["abouttext"] = "Work in Russian and English is supported. To do this, you must select the appropriate switch. All characters will be converted to uppercase. Characters that do not belong to the Latin or Cyrillic alphabet will be ignored.",
            ["textBefore"] = "Enter the text to encrypt or load it from a file",
            ["textBefore2"] = "Enter the text to decrypt or load it from a file",
            ["textAfter"] = "The result will be displayed here",
            ["passphrasetext"] = "Enter passphrase",
            ["passphrase2text"] = "Enter passphrase again",
            ["mode_encodingtext"] = "Encryption",
            ["mode_decodingtext"] = "Decryption",
            ["mode_encodingtextsign"] = "Encryption with signature",
            ["mode_decodingtextsign"] = "Decryption with signature",
            ["delcheckboxtext"] = "Delete original file when saving",
            ["autortext"] = "Author: Zaitseva Irina A-13a-20",
            ["startbutton"] = "Start processing",
            ["countsymlabel"] = "Count of characters in password",
            ["error1"] = "Enter source text",
            ["error2"] = "Enter a passphrase",
            ["error3"] = "Passphrase must contain at least ",
            ["error4"] = "Enter a passphrase again",
            ["error5"] = "Passphrases do not match",
            ["error6"] = "English language is selected.Replace the keymap.",
            ["error7"] = "Password is not correct",
            ["showmatrix"] = "Show matrix of chiper",
            ["showmatrixtext"] = "Show matrix of code",
            ["signature"] = "IRINAZAITSEVA"
        };
        private Dictionary<string, string> currentLanguage;
        private string english_alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string russian_alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        char[,] matrix;
        string inputfilename = string.Empty;

        //Functions
        private void loadFromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            inputfilename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(inputfilename).ToUpper();
            textBefore.Text = fileText;
            textBefore.ForeColor = Color.Black;
        }


        private void start_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBefore.Text, currentLanguage["textBefore"]) || string.Equals(textBefore.Text, currentLanguage["textBefore2"]))
                MessageBox.Show(currentLanguage["error1"]);
            else if (string.Equals(passphrase.Text, currentLanguage["passphrasetext"]))
                MessageBox.Show(currentLanguage["error2"]);
            else if (passphrase.Text.Length < 20 - countsym.SelectedIndex) {
                string tmp;
                if (en_language.Checked)
                    tmp = " symbols";
                else tmp = (countsym.SelectedIndex == 16) ? " символа" : " символов";
                MessageBox.Show(currentLanguage["error3"] + countsym.Text + tmp);
            }
            else if (string.Equals(passphrase2.Text, currentLanguage["passphrase2text"]) && mode_work.SelectedIndex % 2 == 0)
                MessageBox.Show(currentLanguage["error4"]);
            else if (!string.Equals(passphrase.Text, passphrase2.Text) && mode_work.SelectedIndex % 2 == 0)
                MessageBox.Show(currentLanguage["error5"]);
            else
            {
                var language = ru_language.Checked ? "rus" : "en";
                plaipher_crypt crypt = new plaipher_crypt(language);
                if (mode_work.SelectedIndex == 0 )
                    textAfter.Text = crypt.plaipher_Encode(textBefore.Text, passphrase.Text);
                if (mode_work.SelectedIndex == 1)
                    textAfter.Text = crypt.plaipher_Decode(textBefore.Text, passphrase.Text);
                if (mode_work.SelectedIndex == 2)
                    textAfter.Text = crypt.plaipher_Encode(textBefore.Text + currentLanguage["signature"], passphrase.Text);
                if (mode_work.SelectedIndex == 3)
                {
                    string result = crypt.plaipher_Decode(textBefore.Text, passphrase.Text, currentLanguage["signature"]);
                    if (string.Equals(result, "-1"))
                    {
                        MessageBox.Show(currentLanguage["error7"]);
                        return;
                    }
                    else textAfter.Text = result;
                }
                    
                matrix = crypt.matrixPlaipher;
                matrixShowCheckbox.Visible = true;
                saveToFileButton.Visible = true;
                delFileCheckbox.Visible = true;
                exportResultButton.Visible = mode_work.SelectedIndex % 2 == 0;
                if (string.IsNullOrEmpty(textAfter.Text))
                    MessageBox.Show("Результат операции пустая строка. Проверьте, что все символы принадлежат указанному алфавиту (Все остальные сиволы проигнорированы)");
            }
        }
        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, textAfter.Text);
            if (delFileCheckbox.Checked && !string.IsNullOrEmpty(inputfilename) && File.Exists(inputfilename))
            {
                File.Delete(inputfilename);
            }
        }

        //UI--------------------------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            currentLanguage = russian_language;
            mode_work.SelectedIndex = 0;
            countsym.SelectedIndex = 16;
            ActiveControl = panel1;
        }
        private void mode_work_TextChanged(object sender, EventArgs e)
        {
            passphrase2.Visible = mode_work.SelectedIndex % 2 == 0;
            countsym.Visible = mode_work.SelectedIndex % 2 == 0;
            countsymlabel.Visible = mode_work.SelectedIndex % 2 == 0;
            textBefore.Text = (mode_work.SelectedIndex % 2 == 0) ? currentLanguage["textBefore"] : currentLanguage["textBefore2"];
            textBefore.ForeColor = SystemColors.WindowFrame;
            textAfter.ForeColor = SystemColors.WindowFrame;
            textAfter.Text = currentLanguage["textAfter"];
            passphrase.Text = currentLanguage["passphrasetext"];
            passphrase2.Text = currentLanguage["passphrase2text"];
            passphrase.UseSystemPasswordChar = false;
            passphrase2.UseSystemPasswordChar = false;
            passphrase.ForeColor = SystemColors.WindowFrame;
            passphrase2.ForeColor = SystemColors.WindowFrame;
            matrixShowCheckbox.Visible = false;
            matrixShowCheckbox.Checked = false;
            saveToFileButton.Visible = false;
            delFileCheckbox.Visible = false;
            exportResultButton.Visible = false;
            
        }
        private void passphrase_Enter(object sender, EventArgs e)
        {
            passphrase.UseSystemPasswordChar = true;
            if (passphrase.Text == currentLanguage["passphrasetext"])
            {
                passphrase.Text = "";
                passphrase.ForeColor = Color.Black;
            }
        }
        private void passphrase_Leave(object sender, EventArgs e)
        {

            if (passphrase.Text == "")
            {
                passphrase.UseSystemPasswordChar = false;
                passphrase.Text = currentLanguage["passphrasetext"];
                passphrase.ForeColor = SystemColors.WindowFrame;
            }
        }
        private void passphrase2_Enter(object sender, EventArgs e)
        {
            passphrase2.UseSystemPasswordChar = true;
            if (passphrase2.Text == currentLanguage["passphrase2text"])
            {
                passphrase2.Text = "";
                passphrase2.ForeColor = Color.Black;
            }
        }
        private void passphrase2_Leave(object sender, EventArgs e)
        {

            if (passphrase2.Text == "")
            {
                passphrase2.UseSystemPasswordChar = false;
                passphrase2.Text = currentLanguage["passphrase2text"];
                passphrase2.ForeColor = SystemColors.WindowFrame;
            }
        }
        private void en_language_CheckedChanged(object sender, EventArgs e)
        {
            currentLanguage = en_language.Checked ? english_language : russian_language;
            this.Text = currentLanguage["globtitle"];
            title.Text = currentLanguage["title"];
            loadFromFileButton.Text = currentLanguage["load_from_file"];
            saveToFileButton.Text = currentLanguage["save_to_file"];
            abouttext.Text = currentLanguage["abouttext"];
            textBefore.Text = currentLanguage["textBefore"];
            textAfter.Text = currentLanguage["textAfter"];
            passphrase.Text = currentLanguage["passphrasetext"];
            passphrase2.Text = currentLanguage["passphrase2text"];
            mode_work.Items.Clear();
            mode_work.Items.Add(currentLanguage["mode_encodingtext"]);
            mode_work.Items.Add(currentLanguage["mode_decodingtext"]);
            mode_work.Items.Add(currentLanguage["mode_encodingtextsign"]);
            mode_work.Items.Add(currentLanguage["mode_decodingtextsign"]);
            mode_work.SelectedIndex = 0;
            delFileCheckbox.Text = currentLanguage["delcheckboxtext"];
            autorText.Text = currentLanguage["autortext"];
            startButton.Text = currentLanguage["startbutton"];
            countsymlabel.Text = currentLanguage["countsymlabel"];
            matrixShowCheckbox.Text = currentLanguage["showmatrix"];
            matrixShowCheckbox.Checked = false;
            matrixShowCheckbox.Visible = false;
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }
        private void textBefore_Enter(object sender, EventArgs e)
        {
            if (textBefore.Text == currentLanguage["textBefore"] || textBefore.Text == currentLanguage["textBefore2"])
            {
                textBefore.Text = "";
                textBefore.ForeColor = Color.Black;
            }
        }
        private void textBefore_Leave(object sender, EventArgs e)
        {
            if (textBefore.Text == "" || string.Equals(textBefore.Text, currentLanguage["textBefore"]) || string.Equals(textBefore.Text,currentLanguage["textBefore2"]))
            {
                textBefore.Text = mode_work.SelectedIndex % 2 == 0 ? currentLanguage["textBefore"] : currentLanguage["textBefore2"];
                textBefore.ForeColor = SystemColors.WindowFrame;
            }
        }
        private void textBefore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (en_language.Checked && russian_alphabet.IndexOf(e.KeyChar) != -1)
                MessageBox.Show(currentLanguage["error6"]);
            if (ru_language.Checked && english_alphabet.IndexOf(e.KeyChar) != -1)
                MessageBox.Show(currentLanguage["error6"]);

            if (en_language.Checked && english_alphabet.IndexOf(e.KeyChar) == -1)
                e.Handled = true;

            if (ru_language.Checked && russian_alphabet.IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }
        private void textBefore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                var selectionStart = textBefore.SelectionStart;
                if (textBefore.SelectionLength > 0)
                {
                    textBefore.Text = textBefore.Text.Substring(0, selectionStart) + textBefore.Text.Substring(selectionStart + textBefore.SelectionLength);
                    textBefore.SelectionStart = selectionStart;
                }
                else if (selectionStart > 0)
                {
                    textBefore.Text = textBefore.Text.Substring(0, selectionStart - 1) + textBefore.Text.Substring(selectionStart);
                    textBefore.SelectionStart = selectionStart - 1;
                }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Space)
            {

                textBefore.Text += ' ';
                textBefore.SelectionStart = textBefore.Text.Length;
                e.Handled = true;
            }
        }
        private void passphrase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                var selectionStart = passphrase.SelectionStart;
                if (passphrase.SelectionLength > 0)
                {
                    passphrase.Text = passphrase.Text.Substring(0, selectionStart) + passphrase.Text.Substring(selectionStart + passphrase.SelectionLength);
                    passphrase.SelectionStart = selectionStart;
                }
                else if (selectionStart > 0)
                {
                    passphrase.Text = passphrase.Text.Substring(0, selectionStart - 1) + passphrase.Text.Substring(selectionStart);
                    passphrase.SelectionStart = selectionStart - 1;
                }
                e.Handled = true;
            }
        }
        private void passphrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBefore_KeyPress(sender, e);
        }
        private void passphrase2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                var selectionStart = passphrase2.SelectionStart;
                if (passphrase2.SelectionLength > 0)
                {
                    passphrase2.Text = passphrase2.Text.Substring(0, selectionStart) + passphrase2.Text.Substring(selectionStart + passphrase2.SelectionLength);
                    passphrase2.SelectionStart = selectionStart;
                }
                else if (selectionStart > 0)
                {
                    passphrase2.Text = passphrase2.Text.Substring(0, selectionStart - 1) + passphrase2.Text.Substring(selectionStart);
                    passphrase2.SelectionStart = selectionStart - 1;
                }
                e.Handled = true;
            }
        }
        private void passphrase2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBefore_KeyPress(sender, e);
        }
        private void textAfter_TextChanged(object sender, EventArgs e)
        {
            textAfter.ForeColor = (string.Equals(textAfter.Text, currentLanguage["textAfter"])) ? SystemColors.WindowFrame : Color.Black;
            exportResultButton.Visible = !string.Equals(textAfter.Text, currentLanguage["textAfter"]);
        }

        private void exportResultButton_Click(object sender, EventArgs e)
        {
            string tmp = textAfter.Text;
            if (mode_work.SelectedIndex == 0)
                mode_work.SelectedIndex = 1;
            if (mode_work.SelectedIndex == 2)
                mode_work.SelectedIndex = 3;
            textBefore.Text = tmp;
            textBefore.SelectionStart = textBefore.TextLength;
        }

        private void matrixShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (matrixShowCheckbox.Checked)
            {
                showMatrixForm show = new showMatrixForm(matrix);
                show.Text = currentLanguage["showmatrixtext"];
                if (show.ShowDialog() == DialogResult.Cancel) 
                { 
                    matrixShowCheckbox.Checked = false; 
                }

            }
        }
    }
}
