using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityOrnek.Model;

namespace EntityOrnek
{
    public partial class frmSorgular : Form
    {
        public frmSorgular()
        {
            InitializeComponent();
        }

        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void btnDersLst_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SBTQ48V\SQLEXPRESS;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * From ders", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrdList.DataSource = dt;
        }

        private void btnOgrenciLst_Click(object sender, EventArgs e)
        {
            datagrdList.DataSource = db.ogrenci.ToList();
            datagrdList.Columns[3].Visible = false;
            datagrdList.Columns[4].Visible = false;
        }

        private void btnNotLst_Click(object sender, EventArgs e)
        {
            var query = from item in db.notlar
                        select new
                        {
                            item.id,
                            item.ogrenci,
                            item.ders,
                            item.sinav1,
                            item.sinav2,
                            item.sinav3,
                            item.ortalama,
                            item.durum
                        };
            datagrdList.DataSource = query.ToList();
                        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ogrenci ogrtbl = new ogrenci();
            ogrtbl.ad = txtOgrenciAd.Text;
            ogrtbl.soyad = txtOgrenciSoyad.Text;
            db.ogrenci.Add(ogrtbl);
            db.SaveChanges();
            MessageBox.Show("Öğrenci listeye eklenmiştir.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.ogrenci.Find(id);
            db.ogrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.ogrenci.Find(id);

            x.ad = txtOgrenciAd.Text;
            x.soyad = txtOgrenciSoyad.Text;
            x.fotograf = txtOgrenciFoto.Text; 

            db.SaveChanges();

            MessageBox.Show("Öğrenci bilgileri güncellendi.");

        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            datagrdList.DataSource = db.notListesi();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            datagrdList.DataSource = db.ogrenci.Where(x => x.ad == txtOgrenciAd.Text).ToList();
        }

        private void txtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            #region Yazılan her harfe göre arama yapılması.

            string aranan = txtOgrenciAd.Text;
            var degerler = from s in db.ogrenci
                           where s.ad.Contains(aranan)
                           select s;
            datagrdList.DataSource = degerler.ToList();

            #endregion 
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (rdbtnAdSirala.Checked==true)
            {
                //Asc - Ascending
                List<ogrenci> lst = db.ogrenci.OrderBy(p => p.ad).ToList();
                datagrdList.DataSource = lst;
            }        
            if (rdbtnTersSirala.Checked==true)
            {
                //Desc - Descending
                List<ogrenci> tersLst = db.ogrenci.OrderByDescending(p => p.ad).ToList();
                datagrdList.DataSource = tersLst;
            }
            if (rdbtnİlkUcSirala.Checked==true)
            {
                //Desc - Descending
                List<ogrenci> ilkücLst = db.ogrenci.OrderBy(p => p.ad).Take(3).ToList();
                datagrdList.DataSource = ilkücLst;
            }
            if (rdbtnID.Checked== true)
            {
                //Desc - Descending
                List<ogrenci> idLst = db.ogrenci.Where(p => p.id == 5).ToList();
                datagrdList.DataSource = idLst;
            }
            if (rdbtnAharfLst.Checked == true)
            {
                List<ogrenci> AharfLst = db.ogrenci.Where(p => p.ad.StartsWith("a")).ToList();
                datagrdList.DataSource = AharfLst;
            }
            if (rdbtnSonAharfLst.Checked == true)
            {
                List<ogrenci> ASonharfLst = db.ogrenci.Where(p => p.ad.EndsWith("i")).ToList();
                datagrdList.DataSource = ASonharfLst;
            }
            if (rdbtnDegerVarmi.Checked == true)
            {
                bool deger = db.ogrenci.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            if (rdnbtnTplmOgrc.Checked == true)
            {
                int toplamOgrc = db.ogrenci.Count();
                MessageBox.Show(toplamOgrc.ToString()+ " tane öğrenci vardır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }   
            if (rdbtnSinavToplam.Checked == true)
            {
                int toplamSinav = db.notlar.Sum(p=>p.sinav1.Value);
                MessageBox.Show(toplamSinav.ToString()+ " puan", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }        
            if (rdbtnSinavOrt.Checked == true)
            {
                var ortSinav = db.notlar.Average(p=>p.sinav1);
                MessageBox.Show(ortSinav.ToString()+ " ortalama puan", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from n in db.notlar
                        join o in db.ogrenci
                        on n.ogrenci equals o.id
                        join d in db.ders
                        on n.ders equals d.id
                        select new
                        {
                            ogrenci = o.ad +" "+ o.soyad,
                            ders = d.ad,
                            sinav1 = n.sinav1,
                            sinav2 = n.sinav2,
                            sinav3 = n.sinav3,
                            ortalama = n.ortalama,
                        };
            datagrdList.DataSource = sorgu.ToList();
        }
    }
}
