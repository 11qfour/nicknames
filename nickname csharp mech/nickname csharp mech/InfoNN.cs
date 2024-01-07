using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace nickname_csharp_mech
{
    public partial class InfoNN : Form
    {
        public InfoNN()
        {
            InitializeComponent();
        }

        private void Rules_Text_Parse()
        {
            try
            {
                using (StreamReader input = new StreamReader("info_for_nickname.txt"))
                {
                    string text;
                    text = input.ReadToEnd();
                    InfoRichTB.Text = text;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InfoNN_Load(object sender, EventArgs e)
        {
            Rules_Text_Parse();
        }

        private void BackExistButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
