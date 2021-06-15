using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Label lb;
        private Button bt;
        public Form1()
        {
            InitializeComponent();
            
            this.Text = "サンプル";
            this.Width = 250;
            this.Height = 100;

            lb = new Label();
            lb.Text = "いらっしゃいませ";
            lb.Width = 150;
            bt = new Button();
            bt.Text = "購入";
            bt.Top = this.Top + lb.Height;
            bt.Width = lb.Width;

            bt.Parent = this;
            lb.Parent = this;

            bt.Click += new EventHandler(bt_Click);
        }

        public void bt_Click(Object sender, EventArgs e)
        {
            lb.Text = "ありがとうございます";
        }
    }
}