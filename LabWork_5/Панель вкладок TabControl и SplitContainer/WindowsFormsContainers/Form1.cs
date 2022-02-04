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
            // TabControl part

            tabControl1.TabPages[0].Text = "Первая вкладка";
            tabControl1.TabPages[1].Text = "Вторая вкладка";

            TabPage thirdTabPage = new TabPage();
            thirdTabPage.Text = "Третья вкладка";
            thirdTabPage.BackColor = Color.Black;
            thirdTabPage.ForeColor = Color.White;
            tabControl1.TabPages.Add(thirdTabPage);

            Button firstButton = new Button();
            firstButton.Text = "1";
            tabControl1.TabPages[0].Controls.Add(firstButton);

            Button secondButton = new Button();
            secondButton.Text = "2";
            tabControl1.TabPages[1].Controls.Add(secondButton);

            Button thirdButton = new Button();
            thirdButton.Text = "3";
            tabControl1.TabPages[2].Controls.Add(thirdButton);

            // SplitContainer part

            Button fourthButton = new Button();
            fourthButton.Text = "4";
            splitContainer1.Panel1.Controls.Add(fourthButton);

            Button fifthButton = new Button();
            fifthButton.Text = "5";
            splitContainer1.Panel2.Controls.Add(fifthButton);

            splitContainer1.Panel2Collapsed = true;
        }
    }
}
