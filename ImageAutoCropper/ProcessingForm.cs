using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAutoCropper
{
    public partial class ProcessingForm : Form
    {
        public delegate void CancelOperation(ProcessingForm sender);
        public event CancelOperation OnCancelOperation;
        public ProgressBar bar;
        public TextBox log;
        public ProcessingForm()
        {
            InitializeComponent();
            bar = ProgressBar;
            log = LogTextBox;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            OnCancelOperation.Invoke(this);
        }
    }
}
