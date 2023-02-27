using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProjectMahmoud
{
    public partial class Resize : Form
    {
        public Resize(int n1,int n2)
        {
            InitializeComponent();
            WidthTextBox.Text = n1.ToString();
            HeightTextBox.Text = n2.ToString();
        }

        public Resize()
        {
            InitializeComponent();
            WidthTextBox.Text = "50";
            HeightTextBox.Text = "50";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                Panel.Number1 = int.Parse(WidthTextBox.Text);
                Panel.Number2 = int.Parse(HeightTextBox.Text);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
