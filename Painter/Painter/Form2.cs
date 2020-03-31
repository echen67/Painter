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
            cancelButton.Click += new EventHandler(cancelButton_Click);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public int getWidth()
        {
            return Int32.Parse(widthText.Text);
        }

        public int getHeight()
        {
            return Int32.Parse(heightText.Text);
        }
    }
}
