using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            _cancelButton.Click += new EventHandler(_cancelButton_Click);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public int getWidth()
        {
            return (int)_widthChoose.Value;
        }

        public int getHeight()
        {
            return (int)_heightChoose.Value;
        }
    }
}
