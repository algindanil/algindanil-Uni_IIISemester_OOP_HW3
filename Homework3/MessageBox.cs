using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class MessageBox : Form
    {
        MainForm form1;
        public MessageBox(MainForm form)
        {
            InitializeComponent();
            this.form1 = form;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            outputLabel.Text = form1.getInputFieldValue();
        }
    }
}
