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
        public basepage()
        {
            InitializeComponent();
        }

        private void basepage_Load(object sender, EventArgs e)
        {

        }

        private void ExistNNButton_Click(object sender, EventArgs e)
        {
            ExistNN existnickname = new ExistNN();
            existnickname.Show();
        }

        private void NewNNButton_Click(object sender, EventArgs e)
        {
            NewNN newnickname = new NewNN();
            newnickname.Show();
        }

        private void LikedNNButton_Click(object sender, EventArgs e)
        {
            LikedNN likednickname = new LikedNN();
            likednickname.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GitHub: 11qfour", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
