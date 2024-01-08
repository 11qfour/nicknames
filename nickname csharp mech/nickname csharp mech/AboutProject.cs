using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nickname_csharp_mech
{
    public partial class AboutProject : Form
    {
        public AboutProject()
        {
            InitializeComponent();
        }

        private void BackExistButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutProject_Load(object sender, EventArgs e)
        {
            Rules_Text_Parse();
        }

        private void Rules_Text_Parse()
        {
            try
            {
                using (StreamReader input = new StreamReader("info_about_proj.txt"))
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
    }
}
