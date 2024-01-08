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
        string result;
        bool click_TB_start = false; // флаг первого клика по форме
        Size SIze;
        public ExistNN()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Resize += ExistNN_Resize;
            SizeChanged += ExistNN_SizeChanged;
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
                    if ((s[i] == '_') || (s[i] == '.') || char.IsDigit(s[i]) || (char.IsLetter(s[i]) && s[i] <= 'z' && s[i] >= 'A')||(s[i]==' '))
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

        private void ExistButton_Click(object sender, EventArgs e)
        {
            result = "";
            string s = ExistStartTB.Text;
            errorProvider1.Clear();
            check_string(s);

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
            infonn.Show();
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
