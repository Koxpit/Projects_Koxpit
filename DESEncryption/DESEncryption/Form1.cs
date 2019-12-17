using System;
using System.Windows.Forms;

namespace DESEncryption
{
    public partial class DES : Form
    {
        public DES()
        {
            InitializeComponent();
        }

        private const int sizeOfBlock = 128; //в DES размер блока 64 бит, но поскольку в unicode символ в два раза длинее, то увеличим блок тоже в два раза
        private const int sizeOfChar = 16; // размер одного символа (in Unicode 16 bit)
        private const int shiftKey = 2; // сдвиг ключа
        private const int quantityOfRounds = 16; // количество раундов
        private string filePathEncrypt; // путь к файлу с зашифрованными сообщениями.
        private string filePathDecrypt; // путь к файлу с расшифрованными сообщениями.
        private string filePathText; // путь к файлу с текстом, который нужно зашифровать.

        string[] Blocks; // блоки данных в двоичном формате

        // Метод, доводящий строку до такого размера, чтобы она делилась на sizeOfBlock.
        // Размер увеличивается с помощью добавления к исходной строке символа “решетка”.
        private string StringToRightLength(string input)
        {
            while (((input.Length*sizeOfChar)%sizeOfBlock)!=0)
                input+="#";

            return input;
        }

        // Метод, разбивающий строку в обычном (символьном) формате на блоки.
        private void CutStringIntoBlocks(string input)
        {
            Blocks = new string[(input.Length*sizeOfChar)/sizeOfBlock]; // инициализация блоков данных.

            int lengthOfBlock = input.Length/Blocks.Length; // размер одного блока.

            for (int i = 0; i < Blocks.Length; i++)
            {
                Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock); // присваиваем каждому блоку свою подстроку строки.
                Blocks[i] = StringToBinaryFormat(Blocks[i]); // конвертируем блок строки в двоичный формат.
            }
        }

        // Метод, разбивающий строку в двоичном формате на блоки.
        private void CutBinaryStringIntoBlocks(string input)
        {
            Blocks = new string[input.Length / sizeOfBlock]; // инициализируем (создаем) блоки строк двоичного формата.
            if(Blocks.Length == 0) { MessageBox.Show("Зашифрованная строка имела пустой вид."); return; }
            int lengthOfBlock = input.Length/Blocks.Length; // находим длину одного блока в битах.

            for (int i = 0; i < Blocks.Length; i++)
                Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock); // вставляем в каждый блок подстроку в двоичном формате.
        }

        // Метод, переводящий строку в двоичный формат.
        private string StringToBinaryFormat(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                string char_binary = Convert.ToString(input[i], 2); // преобразует символ строки блока в двоичный код.

                while (char_binary.Length < sizeOfChar) // обычный размер символа равен 7 битов (например, 1111111). Увеличиваем до 16 бит добавлением к размеру нули.
                    char_binary = "0" + char_binary;

                output += char_binary; // добавляем к результату символ в двоичном формате размером в 16 бит.
            }

            return output; // возвращаем блок строки в двоичном формате.
        }

        // Метод, доводящий длину ключа шифровки до нужной длины.
        private string CorrectKeyWord(string input, int lengthKey) // input - текущий ключ, lenghKey - должная длина ключа.
        {
            if (input.Length > lengthKey)
                input = input.Substring(0, lengthKey); // если введена длина ключа шифровки (текущий) больше нужной, то урезаем до нужной.
            else
                while (input.Length < lengthKey)
                    input = "0" + input; // добавляем нули в начало к текущему ключу, если длина меньше нужной.

            return input;
        }

        // Один раунд шифрования алгоритмом DES.
        private string EncodeDES_OneRound(string input, string key) // input - длина одного блока, key - ключ шифрования в двоичном формате.
        {
            string L = input.Substring(0, input.Length / 2); // левая часть строки.
            string R = input.Substring(input.Length / 2, input.Length / 2); // правая часть строки.

            return (R + XOR(L, f(R, key))); // возвращаем зашифрованную строку в двоичном формате.
        }

        // Один раунд расшифровки алгоритмом DES.
        private string DecodeDES_OneRound(string input, string key)
        {
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);

            return (XOR(f(L, key), R) + L); // возвращаем расшифрованную строку в двоичном формате. Для расшифровки просто сделали функцию наоборот.
        }

        // XOR двух строк с двоичными данными.
        private string XOR(string s1, string s2)
        {
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(s1[i].ToString())); // преобразуем символ строки в численный вид (0 или 1), а после в булевый тип.
                bool b = Convert.ToBoolean(Convert.ToInt32(s2[i].ToString())); // тоже самое.

                if (a ^ b) // ^ - логическое исключающее "ИЛИ".
                    result += "1"; // Если разряды разные (т.е. a - true и b - false, или наоборот), то прибавляем к результату 1.
                else
                    result += "0"; // Если a = false и b = false, то 0.
            }
            
            return result;
        }

        // Шифрующая функция f. Испольуется логическая операция XOR, но можно выбрать и любую другую.
        private string f(string s1, string s2)
        {
            return XOR(s1, s2);
        }

        // Вычисление ключа для следующего раунда шифрования DES. Циклический сдвиг >> shiftKey.
        private string KeyToNextRound(string key) // key в двоичном виде.
        {
            for (int i = 0; i < shiftKey; i++) // сдвигаем ключ два раза (shiftKey = 2).
            {
                key = key[key.Length-1] + key; // последний бит ключа прибавляем к полному ключу(всем битам).
                key = key.Remove(key.Length-1); // Удаляем последний бит ключа.
                // данными операциями мы копируем самый последний бит ключа в начало последовательности битов ключа и удаляем оригинальный бит ключа (последний).
                // было, например, 1110, стало 01110, и в результате 0111.
            }

            return key;
        }

        // Вычисление ключа для следующего раунда расшифровки DES. циклический сдвиг << shiftKey.
        private string KeyToPrevRound(string key) // тоже самое что и с KeyToNextRound, только перемещаем бит наоборот (от начала в конец).
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key + key[0];
                key = key.Remove(0, 1);
            }

            return key;
        }

        // Метод, переводящий строку с двоичными данными в символьный формат.
        private string StringFromBinaryToNormalFormat(string input)
        {
            string output = "";

            while (input.Length > 0)
            {
                string char_binary = input.Substring(0, sizeOfChar); // присваиваем char_binary двоичную строку длиной 16 бит.
                input = input.Remove(0, sizeOfChar); // удаляем из двоичной строки полученную выше подстроку.

                int a = 0;
                int degree = char_binary.Length - 1; // так как отсчет идет с 0, а не с 1, то вычитаем от длины единицу.

                foreach (char c in char_binary) // перебираем каждый бит в подстроке битов.
                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--); // если бит равен 1, то умножаем его положение на степень 2 и прибавляем к результату. Если 0, то прибавляется 0. Простое преобразование двоичных значений в десятичные.

                output += ((char)a).ToString(); // преобразовываем полученный код в символ, а после в строку и прибавляем к output
            }

            return output;
        }

        private void DES_Load(object sender, EventArgs e)
        {

        }

        // Теперь реализуем функционал кнопки “Расшифровать”.
        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length > 0)
            {
                string s = "";

                string key = StringToBinaryFormat(textBoxCode.Text); // преобразовываем ключ расшифровки в двоичный формат.

                openFileDialog1.Title="Открытие зашифрованного сообщения.";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    filePathEncrypt = openFileDialog1.FileName; // получаем путь к файлу.

                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePathEncrypt))
                {
                    while (!sr.EndOfStream)
                    {
                        s += sr.ReadLine(); // считываем каждую строку из файла.
                    }
                }

                s = StringToBinaryFormat(s); // конвертируем зашифрованную строку в двоичный формат.

                CutBinaryStringIntoBlocks(s); // разбиваем строку в двоичном формате на подстроки.

                for (int j = 0; j < quantityOfRounds; j++)
                {
                    for (int i = 0; i < Blocks.Length; i++)
                        Blocks[i] = DecodeDES_OneRound(Blocks[i], key); // производим расшифровку.

                    key = KeyToPrevRound(key);
                } // в результате цикла ключ сместился 16 раз.

                key = KeyToNextRound(key); // смещаем и получаем наш ключ, который мы вводили для шифровки.

                textBoxWord.Text = StringFromBinaryToNormalFormat(key); // выводим ключ шифровки в текстовое поле.

                string result = ""; // строка, в которую будем записывать блоки данных в двоичном формате.

                for (int i = 0; i < Blocks.Length; i++)
                    result += Blocks[i]; // прибавляем к строке блок данных в двоичном виде.

                openFileDialog1.Title="Сохранение расшифрованного сообщения.";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    filePathDecrypt = openFileDialog1.FileName; // получаем путь к файлу.

                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePathDecrypt))
                        sw.WriteLine(StringFromBinaryToNormalFormat(result)); // записываем расшифровку в файл в нормальном виде.

                System.Diagnostics.Process.Start(filePathDecrypt); // открытие файла.
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }

        // И кнопки “Зашифровать”.
        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            if (textBoxWord.Text.Length > 0)
            {
                string s = "";

                string key = textBoxWord.Text; // получение из текстового поля "Ключ шифровки" значение ключа.

                openFileDialog1.Title="Открытие текста для шифровки.";
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                    filePathText = openFileDialog1.FileName; // получаем путь к файлу.

                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(filePathText))
                        while (!sr.EndOfStream)
                            s += sr.ReadLine();
                } catch(Exception ex) { MessageBox.Show(ex.Message); }

                s = StringToRightLength(s); // Доведение строки до такого размера, чтобы она делилась на размер блока данных. (Length % sizeOfBlock == 0).

                CutStringIntoBlocks(s); // Деление новой строки на блоки данных с преобразованием ее в двоичный формат.

                key = CorrectKeyWord(key, s.Length / (2 * Blocks.Length)); // доводим длюну ключа шифровки до нужной длины и возвращаем его.
                textBoxWord.Text = key; // выводим в текстовое поле "Ключ шифровки" значение ключа.
                key = StringToBinaryFormat(key); // преобразовываем ключ в двоичный формат.

                for (int j = 0; j < quantityOfRounds; j++) // шифрование всех блоков по 16 раз (16 раундов).
                {
                    for (int i = 0; i < Blocks.Length; i++) // производим шифрование каждого блока.
                        Blocks[i] = EncodeDES_OneRound(Blocks[i], key); // производим шифрование каждого блока.

                    key = KeyToNextRound(key);
                } // в результате цикла ключ сместился 16 раз.

                key = KeyToPrevRound(key); // смещаем и получаем зашифрованный ключ.

                textBoxCode.Text = StringFromBinaryToNormalFormat(key); // выводим зашифрованный ключ в текстовое поле.

                string result = "";

                for (int i = 0; i < Blocks.Length; i++)
                    result += Blocks[i];

                openFileDialog1.Title="Сохранение зашифрованного текста.";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    filePathEncrypt = openFileDialog1.FileName; // получаем путь к файлу.

                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePathEncrypt))
                        sw.WriteLine(StringFromBinaryToNormalFormat(result));

                System.Diagnostics.Process.Start(filePathEncrypt); // Открываем файл.
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
                MessageBox.Show("Введите ключевое слово!");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDESEncryption about = new AboutDESEncryption();
            about.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
