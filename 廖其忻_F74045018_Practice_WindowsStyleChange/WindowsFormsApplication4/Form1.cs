using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStyle1_Click(object sender, EventArgs e)
        {
            Font f1;
            f1 = new Font("微軟正黑體", 18, FontStyle.Bold);
            label1.Font = f1;
            label1.BackColor = System.Drawing.Color.Yellow;

            Font f2;
            f2 = new Font("微軟正黑體", 14, FontStyle.Bold);
            label2.Font = f2;

            //content: background color: White
            //this.BackColor = Color.White;

            textBox1.TextAlign = HorizontalAlignment.Right;
            
            button3.TextAlign = ContentAlignment.TopLeft;
            pictureBox1.BackColor = System.Drawing.Color.White;
            btnStyle1.BackColor = System.Drawing.Color.Transparent;

        }

        private void btnStyle2_Click(object sender, EventArgs e)
        {
            Font f3;
            f3 = new Font("新細明體", 18, FontStyle.Underline);
            label1.Font = f3;
            label1.BackColor = System.Drawing.Color.Transparent;

            Font f4;
            f4 = new Font("新細明體", 14, FontStyle.Italic);
            label2.Font = f4;

            //content: background color: Brown 
            //this.BackColor = Color.Brown;
            textBox1.TextAlign = HorizontalAlignment.Right;
            
            button3.TextAlign = ContentAlignment.BottomRight;
            pictureBox1.BackColor = System.Drawing.Color.Blue;
            btnStyle1.BackColor = System.Drawing.Color.Green;

        }

    }
}
