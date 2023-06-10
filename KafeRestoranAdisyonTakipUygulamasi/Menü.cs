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
    public partial class Menü : Form
    {
        private Dictionary<string, decimal> fiyatlar = new Dictionary<string, decimal>()
        {
        {"Adana Kebap", 170.0m},
        {"Yağlı Kara", 180.0m},
        {"2'Li Karışık Izgara", 250.0m},
        {"Sebzeli Kebap", 150.0m},
        {"Patlıcan Kebap", 190.0m},
        {"Kemikli Tavuk", 150.0m},
        {"Kemiksiz Tavuk", 170.0m},
        {"Kola", 40.0m},
        {"Fanta", 40.0m},
        {"Şalgam", 25.0m},
        {"Ayran", 25.0m},
        {"Çay", 17.0m},
        {"Su", 10.0m},
        {"Kadayıf", 120.0m},
        {"Havuç Dilimi", 120.0m},
        {"Midye", 130.0m},
        {"Künefe", 90.0m},
        {"Dondurma", 40.0m},
        {"Katmer", 80.0m},
        {"Çoban Salata", 60.0m},
        {"Soğan Salata", 60.0m},
        {"Sezar Salata", 85.0m},
        {"Pancar Salata", 75.0m}
        };
        
        public Menü()
        {
            InitializeComponent();
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        private void btnAnaYemekler_Click(object sender, EventArgs e)
        {
            string[] anaYemekler = { "Adana Kebap", "Yağlı Kara", "2'Li Karışık Izgara", "Sebzeli Kebap", "Patlıcan Kebap", "Kemikli Tavuk", "Kemiksiz Tavuk" };
            
            listView1.Items.Clear();
            foreach(var yemek in anaYemekler)
            {
                listView1.Items.Add(yemek);
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string secilenYemek = listView1.SelectedItems[0].Text;
                int adet = (int)numericUpDown1.Value;

               if (fiyatlar.ContainsKey(secilenYemek))
                {
                    decimal fiyat = fiyatlar[secilenYemek];
                    decimal toplamFiyat = fiyat * adet;

                    string[] row = { secilenYemek, adet .ToString() };
                    var listViewItem = new ListViewItem(row);
                    listViewItem.SubItems.Add(toplamFiyat.ToString());
                    listView2.Items.Add(listViewItem);
                }

                
            }
        }

        private void btnİçecekler_Click(object sender, EventArgs e)
        {
            string[] Icecekler = { "Kola", "Fanta", "Şalgam", "Ayran", "Çay", "Su" };
            listView1.Items.Clear();
            foreach(var icecek in Icecekler)
            {
                listView1.Items.Add(icecek);
            }
        }

        private void btnTatlılar_Click(object sender, EventArgs e)
        {
            string[] tatlilar = { "Kadayıf", "Havuç Dilimi", "Midye", "Künefe", "Dondurma", "Katmer", };
            listView1.Items.Clear();
            foreach(var tatli in tatlilar)
            {
                listView1.Items.Add(tatli);
            }
        }

        private void btnSalatalar_Click(object sender, EventArgs e)
        {
            string[] salatalar = { "Çoban Salata", "Soğan Salata", "Sezar Salata", "Pancar Salata" };
            listView1.Items.Clear();
            foreach(var salata in salatalar)
            {
                listView1.Items.Add(salata);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string secilenYemek = listView1.SelectedItems[0].Text;

                if (fiyatlar.ContainsKey(secilenYemek))
                {
                    decimal fiyat = fiyatlar[secilenYemek];
                    numericUpDown2.Minimum = 0.0m;
                    numericUpDown2.Maximum = fiyat;
                    numericUpDown2.Value = fiyat;
       
                }
            }
        }

        private void btnIslemKapat_Click(object sender, EventArgs e)
        {
            decimal toplamHesap = 0;
           
            foreach (ListViewItem item in listView2.Items)
            {
                decimal fiyat = decimal.Parse(item.SubItems[2].Text);
                toplamHesap += fiyat;   
                numericUpDown3.Minimum = 0.0m;
                numericUpDown3.Maximum = toplamHesap;
            }
            decimal tHesap = numericUpDown3.Value + toplamHesap;
            numericUpDown3.Value = toplamHesap;
            
            listView2.Items.Clear();
        }

        private void btnYanlisSil_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                
                ListViewItem selectedRow = listView2.SelectedItems[0];
                listView2.Items.Remove(selectedRow);
            }
        }
    }
}
