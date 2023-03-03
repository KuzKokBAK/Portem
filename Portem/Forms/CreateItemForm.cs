using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portem.Forms
{
    public partial class CreateItemForm : Form
    {
        public CreateItemForm()
        {
            InitializeComponent();
        }

        private void ReadItem()
        {
            
        }

        private void WriteItemButton_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void ContentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeadTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
