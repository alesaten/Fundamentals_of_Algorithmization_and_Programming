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
            positionButton.Location = new Point(150, 100);
            increase_sizeButton.Size = new Size { Width = 200, Height = 50 };
            dock_rightButton.Dock = DockStyle.Right;
            dock_leftButton.Dock = DockStyle.Left;
        }
    }
}
