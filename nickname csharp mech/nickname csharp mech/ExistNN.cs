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
        public ExistNN()
        {
            InitializeComponent();
        }

        private void ExistNN_Load(object sender, EventArgs e)
        {

        }

        private void ExistStartTB_Click(object sender, EventArgs e)
        {
            ExistStartTB.Text = "";
            ExistStartTB.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
