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
    public partial class EnterNameForm : Form
    {
        public delegate void AcceptName(EnterNameForm sender, string name);
        public delegate void CancelName(EnterNameForm sender);
        public event AcceptName OnAcceptName;
        public event CancelName OnCancelName;
        public EnterNameForm()
        {
            InitializeComponent();
        }
        private void CancelButton_Click(object sender, EventArgs e) => OnCancelName.Invoke(this);
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Trim().Length <= 0) return;
            if(NameTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("Имя содержит недопустимые символы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var path = Form1.presetsPath + NameTextBox.Text.Trim() + Form1.presetExt;
            if(File.Exists(path))
            {
                MessageBox.Show("Пресет с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OnAcceptName.Invoke(this, NameTextBox.Text.Trim());
        }
        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SaveButton_Click(null, null);
            if (e.KeyCode == Keys.Escape) CancelButton_Click(null, null);
        }
    }
}
