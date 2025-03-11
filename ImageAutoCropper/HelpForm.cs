using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAutoCropper
{
    public partial class HelpForm : Form
    {
        const string refName = "Reference.txt";
        public HelpForm()
        {
            InitializeComponent();
            textBox1.Text = File.Exists(refName) ? File.ReadAllText(refName) : "Файл \"" + refName + "\" не найден.";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1.instance.Show();
            Close();
        }
    }
}
