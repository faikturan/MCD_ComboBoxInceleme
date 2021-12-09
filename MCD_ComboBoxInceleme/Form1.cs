using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_ComboBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Items.Add metotu kullanılarak değerler combobox eklendi..
            //comboBoxDoldurV1();
            comboBoxDoldurV2();
        }

        private void comboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = database.UrunTablo;
        }

        private void comboBoxDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Yöntem
            object o1 = cmbUrunListe.SelectedItem;
            urun u1 = (urun)o1;

            //u1 = cmbUrunListe.SelectedItem == null ? null : cmbUrunListe.SelectedItem as urun;

            //2.Yöntem
            ComboBox secilenCombobox = sender as ComboBox;

            //1.yöntem eğer form içerisinde bulunan form elemanına özel bir metot yazıldı ise o zaman ilgili form elemanını direkt olarak çağırmak daha mantıklıdır.

            //2.yöntem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine tıklanıldığını veya işlem yapıldığını bilmediğimiz için ve metotumuz birden fazla form elemanında olay metodu olarak tanımlandığı için biz sender üzerinden gelen nesneyi kullanır kullanıcının hangi windows form elemanında işlem yapmış olduğunu anlarız.


            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = u1.urunAdi;
            txtUrunKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtUrunAciklama.Text = u1.aciklama;


        }
    }
}
