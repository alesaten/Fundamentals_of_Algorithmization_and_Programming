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
            Button helloButton = new Button();
            helloButton.BackColor = Color.LightGray;
            helloButton.ForeColor = Color.Red;
            helloButton.Location = new Point(30, 30);
            helloButton.Text = "Привет";
            groupBox1.Controls.Add(helloButton);

            Button Button1 = new Button();
            Button1.BackColor = Color.Green;
            Button1.ForeColor = Color.Blue;
            Button1.Location = new Point(30, 30);
            Button1.Text = "1";
            flowLayoutPanel1.Controls.Add(Button1);

            Button Button2 = new Button();
            Button2.BackColor = Color.Green;
            Button2.ForeColor = Color.Red;
            Button2.Location = new Point(30, 30);
            Button2.Text = "2";
            flowLayoutPanel1.Controls.Add(Button2);

            Button Button3 = new Button();
            Button3.BackColor = Color.Blue;
            Button3.ForeColor = Color.Green;
            Button3.Location = new Point(30, 30);
            Button3.Text = "3";
            flowLayoutPanel2.Controls.Add(Button3);

            Button Button4 = new Button();
            Button4.BackColor = Color.Red;
            Button4.ForeColor = Color.White;
            Button4.Location = new Point(30, 30);
            Button4.Text = "4";
            flowLayoutPanel2.Controls.Add(Button4);

            Button Button5 = new Button();
            Button5.BackColor = Color.Black;
            Button5.ForeColor = Color.White;
            Button5.Location = new Point(30, 30);
            Button5.Text = "5";
            flowLayoutPanel3.Controls.Add(Button5);

            Button Button6 = new Button();
            Button6.BackColor = Color.White;
            Button6.ForeColor = Color.Black;
            Button6.Location = new Point(30, 30);
            Button6.Text = "6";
            flowLayoutPanel3.Controls.Add(Button6);

            Button Button7 = new Button();
            Button7.Location = new Point(30, 30);
            Button7.Text = "7";
            flowLayoutPanel4.Controls.Add(Button7);

            Button Button8 = new Button();
            Button8.Location = new Point(30, 30);
            Button8.Text = "8";
            flowLayoutPanel4.Controls.Add(Button8);
        }
    }
}
