using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coalgasOS
{
    public partial class FormAbout : FormClass
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lnsaaa");  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAbout2 f = new FormAbout2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/lnsaaa/");  
        }
    }
}
