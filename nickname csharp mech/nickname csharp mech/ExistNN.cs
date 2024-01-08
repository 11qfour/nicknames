using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nickname_csharp_mech
{
    public partial class ExistNN : Form
    {
        public string result;
        bool click_TB_start = false; // флаг первого клика по форме
        Size SIze;
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public ExistNN()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Resize += ExistNN_Resize;
            SizeChanged += ExistNN_SizeChanged;
        }

        private void OpenNewFormInSameResolution(Form newForm)
        {
            newForm.Size = this.Size;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
        }

        private void ExistNN_Load(object sender, EventArgs e)
        {

        }

        private void ExistStartTB_Click(object sender, EventArgs e)
        {
            if (!click_TB_start)
            {
                ExistStartTB.Text = "";
                click_TB_start = true;
            }
            ExistStartTB.ForeColor = Color.Black;
        }

        private void check_string(string s) //проверка на правильно введённый ник
        {
            if (s.Length >= 31 || s.Length <= 0)//проверка на длину слова
            {
                errorProvider1.SetError(ExistStartTB, "Длина НикНейма должна быть от 1 до 30");
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if ((s[i] == '_') || (s[i] == '.') || char.IsDigit(s[i]) || (char.IsLetter(s[i]) && s[i] <= 'z' && s[i] >= 'A') || (s[i] == ' '))
                    {

                        if (s[i] == '.')
                        {
                            if ((i == 0) || (i == s.Length - 1))
                            {
                                errorProvider1.SetError(ExistStartTB, "НикНейм не должен заканчиваться или начинаться точкой");
                            }
                            else
                            {
                                result += s[i];
                                continue;
                            }
                        }
                        else if (s[i] == ' ')//добавление черты вместо пробела
                        {
                            result += '_';
                            continue;
                        }
                        else
                        {
                            result += s[i];
                            continue;
                        }
                    }
                    else
                    {//ошибка
                        errorProvider1.SetError(ExistStartTB, "НикНейм содержит недопустимые символы, для исправления обратитесь к справке");
                    }
                }
            }

        }
        //1
        private void change_with_i_and_1(ref char s) //замена букв похожие на 1 или цифры 1
        {
            Random Rand;
            Rand = new Random();
            int res = Rand.Next(1, 3);
            if (res == 1)
            {
                s = '1';
            }
            else if (res == 2)
            {
                s = 'l';
            }
            else
            {
                s = 'i';
            }
        }
        //2
        private string do_bigger(string input) //сделать больше на 1 сзади и спереди строки
        {
            char[] resultArray = input.ToCharArray();
            char replace;
            replace = resultArray[0];
            resultArray[0] = 'r';
            for (int i = 1; i < resultArray.Length; i++)
            {
                char temp = resultArray[i];
                resultArray[i] = replace;
                replace = temp;
            }
            resultArray.Append(replace);
            resultArray.Append('r');
            return new string(resultArray);
        }
        private char[] change_with_firstlast(char [] resultArray) //вставка в конец и начало рандомной буквы или цифры
        {
            Random Rand = new Random();
            int res = Rand.Next(1, 36);
            char replacee = alphabet[res];

            // Создаем временный массив для сохранения исходных значений
            char[] tempArray = new char[resultArray.Length];
            resultArray.CopyTo(tempArray, 0);

            // Увеличиваем длину массива на 2
            Array.Resize(ref resultArray, resultArray.Length + 2);

            // Вставляем элемент replacee в начало
            resultArray[0] = replacee;

            // Вставляем элементы из временного массива
            for (int i = 1; i <= tempArray.Length; i++)
            {
                resultArray[i] = tempArray[i - 1];
            }

            // Вставляем элемент replacee в конец
            resultArray[resultArray.Length - 1] = replacee;

            return resultArray;
        }
        //3
        private void change_with_9qdb(ref char s)
        {
            Random Rand;
            Rand = new Random();
            int res = Rand.Next(1, 4);
            if (res == 1)
            {
                s = 'q';
            }
            else if (res == 2)
            {
                s = '9';
            }
            else if (res == 3)
            {
                s = 'd';
            }
            else
            {
                s = 'b';
            }
        }
        //4

        //relize
        private string change_string(ref string input)
        {
            Random Rand;
            //в result у нас уже сделана сама структура никнейма, если был пробел, то стал чертой, необходимо сделать изменения
            char[] resultArray = input.ToCharArray();
            Rand = new Random();
            int menu = Rand.Next(1, 3);
            if (menu == 1)
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    if ((resultArray[i]=='1')|| (resultArray[i] == 'l')|| (resultArray[i] == 'i'))
                    {
                        change_with_i_and_1(ref resultArray[i]);
                    }
                }
            }
            else if (menu == 2)
            {
                resultArray=change_with_firstlast(resultArray);
            }
            else if (menu == 3)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if ((resultArray[i] == 'q') || (resultArray[i] == 'd') || (resultArray[i] == 'b')|| (resultArray[i] == '9'))
                    {
                        change_with_9qdb(ref resultArray[i]);
                    }
                }
            }
            return new string(resultArray);
        }

        private void ExistButton_Click(object sender, EventArgs e)
        {
            result = "";
            string s = ExistStartTB.Text;
            errorProvider1.Clear();
            check_string(s);
            result = change_string(ref result);
            //проверка на кнопку без ограничений
            if (ExistRadioButton.Checked){
                ExistResultTB.Text = result;
            }
            else//если не включена проверка на нецензурность
            {
                ExistResultTB.Text = result;
            }
        }

        private void CopyExistButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ExistResultTB.Text);
        }

        private void InfoExistButton_Click(object sender, EventArgs e)
        {
            InfoNN infonn = new InfoNN();
            OpenNewFormInSameResolution(infonn);
        }

        private void BackExistButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExistNN_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
            {
                // Оставляем форму в единственно возможном состоянии - свернутой или развернутой
                MinimumSize = SIze;
                MaximumSize = SIze;
            }
        }

        private void ExistNN_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                float scaleWidth = (float)Width / (float)ClientSize.Width; //коэфициент сохранения ширины
                float scaleHeight = (float)Height / (float)ClientSize.Height;//коэфициент сохранения высоты
                ExistStartTB.Size = new Size((int)(ExistStartTB.Width * scaleWidth), (int)(ExistStartTB.Height * scaleHeight));
                InfoExistButton.Size = new Size((int)(InfoExistButton.Width * scaleWidth), (int)(InfoExistButton.Height * scaleHeight));
                ExistRadioButton.Size = new Size((int)(ExistRadioButton.Width * scaleWidth), (int)(ExistRadioButton.Height * scaleHeight));
                ExistButton.Size = new Size((int)(ExistButton.Width * scaleWidth), (int)(ExistButton.Height * scaleHeight));
                ExistResultTB.Size = new Size((int)(ExistResultTB.Width * scaleWidth), (int)(ExistResultTB.Height * scaleHeight));
                CopyExistButton.Size = new Size((int)(CopyExistButton.Width * scaleWidth), (int)(CopyExistButton.Height * scaleHeight));
                BackExistButton.Size = new Size((int)(BackExistButton.Width * scaleWidth), (int)(BackExistButton.Height * scaleHeight));
            }
        }
    }
}
