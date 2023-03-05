using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMOD3Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //udah itu
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "hallo " + this.textBox1.Text;
        }
    }
}
