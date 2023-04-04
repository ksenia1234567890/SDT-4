using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (x < 340)
            {
                Button b = new Button();
                b.Location = new Point(x, y);
                b.Size = new Size(128, 63);
                b.Text = "Кнопка";
                b.Parent = this;
            }
            if (x >= 340)
            {
                TextBox tb = new TextBox();
                tb.Location = new Point(x, y);
                tb.Size = new Size(128, 63);
                tb.Text = "Текст";
                tb.Parent = this;
            }
        }

        
    }
}
