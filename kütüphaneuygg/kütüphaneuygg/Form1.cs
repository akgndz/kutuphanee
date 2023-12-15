using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneuygg
{
    public partial class Form1 : Form
    {
        kitap kitap1 = new kitap();
        kitap kitap2 = new kitap();
        kitap kitap3 = new kitap();
        kitap kitap4 = new kitap();
        kitap kitap5 = new kitap();
        kitap kitap6 = new kitap();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void kitaplar()
        {
            kitap1.kitapadı = "metafor";
            kitap1.yazaradi = "bilge ekici";
            kitap1.kategori = "psikoloji";

            kitap2.kitapadı = "insanlık";
            kitap2.yazaradi = "erkan şahin";
            kitap2.kategori = "tarih";

            kitap3.kitapadı = "Suç Ve Ceza";
            kitap3.yazaradi = "Dostoyevski";
            kitap3.kategori = "Roman";

            kitap4.kitapadı = "Kürk Mantolu Madonna";
            kitap4.yazaradi = "Sabahattin Ali";
            kitap4.kategori = "Roman";

            kitap5.kitapadı = "bülbülü öldürmek";
            kitap5.yazaradi = "halper lee";
            kitap5.kategori = "tarih";

            kitap6.kitapadı = "camdaki kız";
            kitap6.yazaradi = "gülseren budayıcıoğlu";
            kitap6.kategori = "psikoloji";

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "psikoloji")
            {
                comboBox2.Items.Add(kitap1.kitapadı);
                comboBox2.Items.Add(kitap6.kitapadı);
            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "tarih")
            {
                comboBox2.Items.Add(kitap2.kitapadı);
                comboBox2.Items.Add(kitap5.kitapadı);
            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Roman")
            {
                comboBox2.Items.Add(kitap3.kitapadı);
                comboBox2.Items.Add(kitap4.kitapadı);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplar();
            string textBox1Text = textBox1.Text;
            string textBox2Text = textBox2.Text;
            string textBox3Text = textBox3.Text;
            string comboBox1SelectedValue = comboBox1.SelectedItem.ToString();
            string comboBox2SelectedValue = comboBox2.SelectedItem.ToString();
            string comboBox3SelectedValue = comboBox3.SelectedItem.ToString();
            string secilenKitapAdi = "";
            string secilenYazaradi = "";


            if (comboBox2SelectedValue == kitap1.kitapadı)
            {
                secilenKitapAdi = kitap1.kitapadı;
                secilenYazaradi = kitap1.yazaradi;
            }
            else if (comboBox2SelectedValue == kitap2.kitapadı)
            {
                secilenKitapAdi = kitap2.kitapadı;
                secilenYazaradi = kitap2.yazaradi;
            }
            else if (comboBox2SelectedValue == kitap3.kitapadı)
            {
                secilenKitapAdi = kitap3.kitapadı;
                secilenYazaradi = kitap3.yazaradi;
            }
            else if (comboBox2SelectedValue == kitap4.kitapadı)
            {
                secilenKitapAdi = kitap4.kitapadı;
                secilenYazaradi = kitap4.yazaradi;
            }
            else if (comboBox2SelectedValue == kitap5.kitapadı)
            {
                secilenKitapAdi = kitap5.kitapadı;
                secilenYazaradi = kitap5.yazaradi;
            }
            else if (comboBox2SelectedValue == kitap6.kitapadı)
            {
                secilenKitapAdi = kitap6.kitapadı;
                secilenYazaradi = kitap6.yazaradi;
            }

            string yazarVeKitap = secilenYazaradi + " - " + secilenKitapAdi;

            listBox1.Items.Add(yazarVeKitap);
            listBox1.Items.Add("Kitap Adedi :" + comboBox3SelectedValue);
            listBox1.Items.Add("Adınız :" + textBox1Text);
            listBox1.Items.Add("Soyadınız :" + textBox2Text);
            listBox1.Items.Add("Telefon Numaranız :" + textBox3Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            kitaplar();
        }

    }
    }
