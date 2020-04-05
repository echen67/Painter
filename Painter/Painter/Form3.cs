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
    public partial class Form3 : Form
    {
        private string newLayerName = "default";

        public Form3()
        {
            InitializeComponent();
        }

        public void setCurrentName(string input)
        {
            textBox.Text = input;
        }

        public string getNewName()
        {
            return newLayerName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newLayerName = textBox.Text;
        }
    }
}
