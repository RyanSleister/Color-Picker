using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }
    }
}
