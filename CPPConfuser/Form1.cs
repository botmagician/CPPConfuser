using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPPConfuser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string rule = "int|long|string|using|namespace|cout|cin|bool|break|case|catch|char|class|const|continue|default|delete|do|double|else|false|float|for|if|new|return|short|sizeof";
            Confuser confuser = new Confuser(rule);
            textBox2.Text = confuser.DefineConfuse(textBox1.Text);
        }
    }
}
