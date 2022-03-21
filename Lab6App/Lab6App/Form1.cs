using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LinkLabel.LinkClicked += LinkLabel_LinkClicked;
            InputButton.Click += InputButton_Click;
            ClearButton.Click += ClearButton_Click;

            /* данный блок кода работает только с однострочным текстовым полем
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            {
                "qwertyuiopasdfghjklzxcvbnm",
                "1234567890"
            };
            InputBox.AutoCompleteCustomSource = source;
            InputBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            InputBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            */
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alesaten/Fundamentals_of_Algorithmization_and_Programming/tree/main/LabWork_6");
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            InputLabel.Text = InputBox.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            InputLabel.Text = "Введите текст";
        }
    }
}
