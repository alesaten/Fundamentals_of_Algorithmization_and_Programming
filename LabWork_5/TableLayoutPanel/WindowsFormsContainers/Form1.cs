using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContainers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.RowStyles[0].Height = 40;

            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[0].Width = 50;

            Button firstButton = new Button();
            firstButton.Text = "1";
            Button secondButton = new Button();
            secondButton.Text = "2";
            Button thirdButton = new Button();
            thirdButton.Text = "3";
            Button fourthButton = new Button();
            fourthButton.Text = "4";
            Button fifthButton = new Button();
            fifthButton.Text = "5";


            tableLayoutPanel1.Controls.Add(firstButton, 0, 0);
            tableLayoutPanel1.Controls.Add(secondButton, 0, 1);
            tableLayoutPanel1.Controls.Add(thirdButton, 1, 0);
            tableLayoutPanel1.Controls.Add(fourthButton, 1, 1);
        }
    }
}
