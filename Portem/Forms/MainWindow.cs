using Portem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateItemButton_Click(object sender, EventArgs e)
        {
            CreateItemForm f2 = new CreateItemForm();
            f2.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
