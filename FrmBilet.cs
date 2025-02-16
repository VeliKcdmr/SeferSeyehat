using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferSeyehat
{
    public partial class FrmBilet : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=RAMPAGE\\SQLEXPRESS;Initial Catalog=YolcuBiletDb;Integrated Security=True");
        public FrmBilet()
        {
            InitializeComponent();
        }
        //Cinsiyetleri comboboxa çekme
        void cinsiyet()
        {
            CmbCinsiyet.Items.Add("Erkek");
            CmbCinsiyet.Items.Add("Kadın");
        }
        void SeferTemizle()
        {
            TxtKalkis.Text = "";
            TxtVaris.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            TxtFiyat.Text = "";
            CmbKaptan.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Yolcu Kaydetme
            SqlCommand komut = new SqlCommand("insert into TblYolcu (Ad,Soyad,Telefon,Tc,Cinsiyet,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskTc.Text);
            komut.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Kaydı Yapıldı.");
        }

        private void FrmBilet_Load(object sender, EventArgs e)
        {
            cinsiyet();
            //Kaptanları comboboxa çekme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select KaptanNo,AdSoyad from TblKaptan", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            CmbKaptan.DisplayMember = "AdSoyad";
            CmbKaptan.ValueMember = "KaptanNo";
            CmbKaptan.DataSource = dt2;
            baglanti.Close();

            //Seferleri listeleme
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TblSefer", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(dr3);
            dataGridView1.DataSource = dt3;
            baglanti.Close();

        }

        private void BtnKKaydet_Click(object sender, EventArgs e)
        {
            //Kaptan Kaydetme
            SqlCommand komut = new SqlCommand("insert into TblKaptan (KaptanNo,AdSoyad,Telefon) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtKAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskKTelefon.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Kaydı Yapıldı.");
        }

        private void BtnSKaydet_Click(object sender, EventArgs e)
        {
            //Sefer Kaydetme
            SqlCommand komut = new SqlCommand("insert into TblSefer (kalkis,varis,tarih,saat,kaptan,fiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", TxtVaris.Text);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.Parameters.AddWithValue("@p5", CmbKaptan.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p6", TxtFiyat.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Kaydı Yapıldı.");
            SeferTemizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {             
            TxtKoltuk.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "9";
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "10";
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "11";
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "12";
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            TxtKoltuk.Text = "13";
        }

        private void Btn14_Click(object sender, EventArgs e)
        {            
            TxtKoltuk.Text = "14";
        }

        private void Btn15_Click(object sender, EventArgs e)
        {            
            TxtKoltuk.Text = "15";
        }

        private void BtnRKaydet_Click(object sender, EventArgs e)
        {            
            SqlCommand komut = new SqlCommand("insert into TblYolculuk (SeferNo,YolcuTc,Koltuk) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSNo.Text);
            komut.Parameters.AddWithValue("@p2", MskMTc.Text);
            komut.Parameters.AddWithValue("@p3", TxtKoltuk.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();            
            MessageBox.Show("Rezervasyon Yapıldı.");
        }
    }
}
