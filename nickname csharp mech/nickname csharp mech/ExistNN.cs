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
        bool click_TB_start = false; // флаг первого клика по форме
        public ExistNN()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    if ((s[i] == '_') || (s[i] == '.') || char.IsDigit(s[i]) || (char.IsLetter(s[i]) && s[i] <= 'z' && s[i] >= 'A'))
                    {

                        if (s[i] == '.')
                        {
                            if ((i == 0) || (i == s.Length - 1))
                            {
                                errorProvider1.SetError(ExistStartTB, "НикНейм не должен заканчиваться или начинаться точкой");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
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
            string s = ExistStartTB.Text;
            errorProvider1.Clear();
            check_string(s);

            //проверка на кнопку без ограничений
            if (ExistRadioButton.Checked){

            }
            else
            {
                
            }
        }

        private void CopyExistButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ExistResultTB.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
