# HomeWork1_2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_2
{
    public partial class pokemon : Form
    {
        public pokemon()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("National:" + NationalTextBox.Text + "\n" +
                "Species:" + SpeciesTextBox.Text + "\n" +
                "Height:" + HeightTextBox.Text + "\n" +
                "Weight:" + WeightTextBox.Text + "\n" +
                "Japanese:" + JapaneseTextBox.Text);
        }
    }
}