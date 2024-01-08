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
    public partial class basepage : Form
    {
        Size SIze;
        public basepage()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Resize += basepage_Resize;
            SizeChanged += basepage_SizeChanged;
        }

        private void OpenNewFormInSameResolution(Form newForm)
        {
            newForm.Size = this.Size;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;
            newForm.Show();
        }

        private void basepage_Load(object sender, EventArgs e)
        {

        }

        private void ExistNNButton_Click(object sender, EventArgs e)
        {
            ExistNN existnickname = new ExistNN();
            OpenNewFormInSameResolution(existnickname);
        }

        private void NewNNButton_Click(object sender, EventArgs e)
        {
            NewNN newnickname = new NewNN();
            OpenNewFormInSameResolution(newnickname);
        }

        private void LikedNNButton_Click(object sender, EventArgs e)
        {
            LikedNN likednickname = new LikedNN();
            OpenNewFormInSameResolution(likednickname);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            AboutProject infoproj = new AboutProject();
            OpenNewFormInSameResolution(infoproj);
        }

        private void ExitMainButton_Click(object sender, EventArgs e)
        {
            DialogResult resultdialog = MessageBox.Show("Вы уверены что хотите закрыть программу?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultdialog==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void basepage_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                float scaleWidth = (float)Width / (float)ClientSize.Width; //коэфициент сохранения ширины
                float scaleHeight = (float)Height / (float)ClientSize.Height;//коэфициент сохранения высоты
                ExistNNButton.Size = new Size((int)(ExistNNButton.Width * scaleWidth), (int)(ExistNNButton.Height * scaleHeight));
                NewNNButton.Size = new Size((int)(NewNNButton.Width * scaleWidth), (int)(NewNNButton.Height * scaleHeight));
                LikedNNButton.Size = new Size((int)(LikedNNButton.Width * scaleWidth), (int)(LikedNNButton.Height * scaleHeight));
                InfoButton.Size = new Size((int)(InfoButton.Width * scaleWidth), (int)(InfoButton.Height * scaleHeight));
                ExitMainButton.Size = new Size((int)(ExitMainButton.Width * scaleWidth), (int)(ExitMainButton.Height * scaleHeight));
            }
        }

        private void basepage_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
            {
                // Оставляем форму в единственно возможном состоянии - свернутой или развернутой
                MinimumSize = SIze;
                MaximumSize = SIze;
            }
        }

        private void MenuMainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
