using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeRestoranAdisyonTakipUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool menuAcik = false;
        private void Button_Click(object sender, EventArgs e)
        {
            if (!menuAcik) 
            {
                Menü menüFormu = new Menü();
                menüFormu.FormClosed += MenüFormu_FormClosed; 
                menüFormu.Show();
                menuAcik = true; 
            }
            else
            {
                MessageBox.Show("Zaten bir masa seçtiniz!"); 
            }
        }
        private void MenüFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuAcik = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(Button_Click);
            button2.Click += new EventHandler(Button_Click);
            button3.Click += new EventHandler(Button_Click);
            button4.Click += new EventHandler(Button_Click);
            button5.Click += new EventHandler(Button_Click);
            button6.Click += new EventHandler(Button_Click);
            button7.Click += new EventHandler(Button_Click);
            button8.Click += new EventHandler(Button_Click);
            button9.Click += new EventHandler(Button_Click);
            button10.Click += new EventHandler(Button_Click);
        }
    }
}
