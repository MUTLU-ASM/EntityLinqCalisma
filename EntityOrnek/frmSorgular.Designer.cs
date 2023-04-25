
namespace EntityOrnek
{
    partial class frmSorgular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagrdList = new System.Windows.Forms.DataGridView();
            this.btnOgrenciLst = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOgrenciFoto = new System.Windows.Forms.TextBox();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.btnDersLst = new System.Windows.Forms.Button();
            this.btnNotLst = new System.Windows.Forms.Button();
            this.rdbtnAdSirala = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.rdbtnTersSirala = new System.Windows.Forms.RadioButton();
            this.rdbtnİlkUcSirala = new System.Windows.Forms.RadioButton();
            this.rdbtnID = new System.Windows.Forms.RadioButton();
            this.rdbtnAharfLst = new System.Windows.Forms.RadioButton();
            this.rdbtnSonAharfLst = new System.Windows.Forms.RadioButton();
            this.rdbtnDegerVarmi = new System.Windows.Forms.RadioButton();
            this.rdnbtnTplmOgrc = new System.Windows.Forms.RadioButton();
            this.rdbtnSinavToplam = new System.Windows.Forms.RadioButton();
            this.rdbtnSinavOrt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrdList
            // 
            this.datagrdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdList.Location = new System.Drawing.Point(13, 13);
            this.datagrdList.Name = "datagrdList";
            this.datagrdList.RowHeadersWidth = 51;
            this.datagrdList.RowTemplate.Height = 24;
            this.datagrdList.Size = new System.Drawing.Size(1154, 277);
            this.datagrdList.TabIndex = 0;
            // 
            // btnOgrenciLst
            // 
            this.btnOgrenciLst.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciLst.Location = new System.Drawing.Point(32, 351);
            this.btnOgrenciLst.Name = "btnOgrenciLst";
            this.btnOgrenciLst.Size = new System.Drawing.Size(218, 39);
            this.btnOgrenciLst.TabIndex = 1;
            this.btnOgrenciLst.Text = "Öğrenci Listele";
            this.btnOgrenciLst.UseVisualStyleBackColor = true;
            this.btnOgrenciLst.Click += new System.EventHandler(this.btnOgrenciLst_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(32, 486);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(218, 39);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(32, 531);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(218, 39);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(32, 576);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(218, 39);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBul.Location = new System.Drawing.Point(32, 621);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(218, 39);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOgrenciFoto);
            this.groupBox1.Controls.Add(this.txtOgrenciID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Location = new System.Drawing.Point(316, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 219);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtOgrenciFoto
            // 
            this.txtOgrenciFoto.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciFoto.Location = new System.Drawing.Point(132, 181);
            this.txtOgrenciFoto.Name = "txtOgrenciFoto";
            this.txtOgrenciFoto.Size = new System.Drawing.Size(224, 32);
            this.txtOgrenciFoto.TabIndex = 22;
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciID.Location = new System.Drawing.Point(132, 34);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(224, 32);
            this.txtOgrenciID.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fotoğraf : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID : ";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(132, 127);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(224, 32);
            this.txtOgrenciSoyad.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Soyad : ";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciAd.Location = new System.Drawing.Point(132, 79);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(224, 32);
            this.txtOgrenciAd.TabIndex = 18;
            this.txtOgrenciAd.TextChanged += new System.EventHandler(this.txtOgrenciAd_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDersID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDersAd);
            this.groupBox2.Location = new System.Drawing.Point(316, 539);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 139);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // txtDersID
            // 
            this.txtDersID.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDersID.Location = new System.Drawing.Point(132, 34);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(224, 32);
            this.txtDersID.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ad : ";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDersAd.Location = new System.Drawing.Point(132, 79);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(224, 32);
            this.txtDersAd.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnJoin);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.txtDurum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtOrtalama);
            this.groupBox3.Controls.Add(this.txtSinav1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSinav3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSinav2);
            this.groupBox3.Location = new System.Drawing.Point(760, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 363);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(128, 314);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(228, 39);
            this.btnJoin.TabIndex = 27;
            this.btnJoin.Text = "join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(128, 269);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(228, 39);
            this.btnHesapla.TabIndex = 26;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDurum.Location = new System.Drawing.Point(132, 226);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(224, 32);
            this.txtDurum.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Durum : ";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrtalama.Location = new System.Drawing.Point(132, 181);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(224, 32);
            this.txtOrtalama.TabIndex = 22;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav1.Location = new System.Drawing.Point(132, 34);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(224, 32);
            this.txtSinav1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ortalama : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sınav 1 : ";
            // 
            // txtSinav3
            // 
            this.txtSinav3.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav3.Location = new System.Drawing.Point(132, 127);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(224, 32);
            this.txtSinav3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sınav 2 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Sınav 3 : ";
            // 
            // txtSinav2
            // 
            this.txtSinav2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav2.Location = new System.Drawing.Point(132, 79);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(224, 32);
            this.txtSinav2.TabIndex = 18;
            // 
            // btnDersLst
            // 
            this.btnDersLst.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDersLst.Location = new System.Drawing.Point(32, 396);
            this.btnDersLst.Name = "btnDersLst";
            this.btnDersLst.Size = new System.Drawing.Size(218, 39);
            this.btnDersLst.TabIndex = 24;
            this.btnDersLst.Text = "Ders Listele";
            this.btnDersLst.UseVisualStyleBackColor = true;
            this.btnDersLst.Click += new System.EventHandler(this.btnDersLst_Click);
            // 
            // btnNotLst
            // 
            this.btnNotLst.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotLst.Location = new System.Drawing.Point(32, 441);
            this.btnNotLst.Name = "btnNotLst";
            this.btnNotLst.Size = new System.Drawing.Size(218, 39);
            this.btnNotLst.TabIndex = 25;
            this.btnNotLst.Text = "Not Listele";
            this.btnNotLst.UseVisualStyleBackColor = true;
            this.btnNotLst.Click += new System.EventHandler(this.btnNotLst_Click);
            // 
            // rdbtnAdSirala
            // 
            this.rdbtnAdSirala.AutoSize = true;
            this.rdbtnAdSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnAdSirala.Location = new System.Drawing.Point(1173, 39);
            this.rdbtnAdSirala.Name = "rdbtnAdSirala";
            this.rdbtnAdSirala.Size = new System.Drawing.Size(270, 33);
            this.rdbtnAdSirala.TabIndex = 26;
            this.rdbtnAdSirala.TabStop = true;
            this.rdbtnAdSirala.Text = "ada göre A-Z sıralama";
            this.rdbtnAdSirala.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(1204, 628);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(212, 49);
            this.btnLinqEntity.TabIndex = 27;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // rdbtnTersSirala
            // 
            this.rdbtnTersSirala.AutoSize = true;
            this.rdbtnTersSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnTersSirala.Location = new System.Drawing.Point(1173, 101);
            this.rdbtnTersSirala.Name = "rdbtnTersSirala";
            this.rdbtnTersSirala.Size = new System.Drawing.Size(270, 33);
            this.rdbtnTersSirala.TabIndex = 28;
            this.rdbtnTersSirala.TabStop = true;
            this.rdbtnTersSirala.Text = "ada göre Z-A sıralama";
            this.rdbtnTersSirala.UseVisualStyleBackColor = true;
            // 
            // rdbtnİlkUcSirala
            // 
            this.rdbtnİlkUcSirala.AutoSize = true;
            this.rdbtnİlkUcSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnİlkUcSirala.Location = new System.Drawing.Point(1170, 158);
            this.rdbtnİlkUcSirala.Name = "rdbtnİlkUcSirala";
            this.rdbtnİlkUcSirala.Size = new System.Drawing.Size(143, 33);
            this.rdbtnİlkUcSirala.TabIndex = 29;
            this.rdbtnİlkUcSirala.TabStop = true;
            this.rdbtnİlkUcSirala.Text = "ilk üç kayıt";
            this.rdbtnİlkUcSirala.UseVisualStyleBackColor = true;
            // 
            // rdbtnID
            // 
            this.rdbtnID.AutoSize = true;
            this.rdbtnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnID.Location = new System.Drawing.Point(1173, 219);
            this.rdbtnID.Name = "rdbtnID";
            this.rdbtnID.Size = new System.Drawing.Size(243, 33);
            this.rdbtnID.TabIndex = 30;
            this.rdbtnID.TabStop = true;
            this.rdbtnID.Text = "ID ye göre veri getir";
            this.rdbtnID.UseVisualStyleBackColor = true;
            // 
            // rdbtnAharfLst
            // 
            this.rdbtnAharfLst.AutoSize = true;
            this.rdbtnAharfLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnAharfLst.Location = new System.Drawing.Point(1170, 276);
            this.rdbtnAharfLst.Name = "rdbtnAharfLst";
            this.rdbtnAharfLst.Size = new System.Drawing.Size(250, 33);
            this.rdbtnAharfLst.TabIndex = 31;
            this.rdbtnAharfLst.TabStop = true;
            this.rdbtnAharfLst.Text = "Adı A ile başlayanlar";
            this.rdbtnAharfLst.UseVisualStyleBackColor = true;
            // 
            // rdbtnSonAharfLst
            // 
            this.rdbtnSonAharfLst.AutoSize = true;
            this.rdbtnSonAharfLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnSonAharfLst.Location = new System.Drawing.Point(1170, 330);
            this.rdbtnSonAharfLst.Name = "rdbtnSonAharfLst";
            this.rdbtnSonAharfLst.Size = new System.Drawing.Size(209, 33);
            this.rdbtnSonAharfLst.TabIndex = 32;
            this.rdbtnSonAharfLst.TabStop = true;
            this.rdbtnSonAharfLst.Text = "Adı A ile bitenler";
            this.rdbtnSonAharfLst.UseVisualStyleBackColor = true;
            // 
            // rdbtnDegerVarmi
            // 
            this.rdbtnDegerVarmi.AutoSize = true;
            this.rdbtnDegerVarmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnDegerVarmi.Location = new System.Drawing.Point(1170, 392);
            this.rdbtnDegerVarmi.Name = "rdbtnDegerVarmi";
            this.rdbtnDegerVarmi.Size = new System.Drawing.Size(165, 33);
            this.rdbtnDegerVarmi.TabIndex = 33;
            this.rdbtnDegerVarmi.TabStop = true;
            this.rdbtnDegerVarmi.Text = "Değer varmı";
            this.rdbtnDegerVarmi.UseVisualStyleBackColor = true;
            // 
            // rdnbtnTplmOgrc
            // 
            this.rdnbtnTplmOgrc.AutoSize = true;
            this.rdnbtnTplmOgrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdnbtnTplmOgrc.Location = new System.Drawing.Point(1173, 447);
            this.rdnbtnTplmOgrc.Name = "rdnbtnTplmOgrc";
            this.rdnbtnTplmOgrc.Size = new System.Drawing.Size(270, 33);
            this.rdnbtnTplmOgrc.TabIndex = 34;
            this.rdnbtnTplmOgrc.TabStop = true;
            this.rdnbtnTplmOgrc.Text = "Toplam ogrenci sayisi";
            this.rdnbtnTplmOgrc.UseVisualStyleBackColor = true;
            // 
            // rdbtnSinavToplam
            // 
            this.rdbtnSinavToplam.AutoSize = true;
            this.rdbtnSinavToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnSinavToplam.Location = new System.Drawing.Point(1170, 500);
            this.rdbtnSinavToplam.Name = "rdbtnSinavToplam";
            this.rdbtnSinavToplam.Size = new System.Drawing.Size(260, 33);
            this.rdbtnSinavToplam.TabIndex = 35;
            this.rdbtnSinavToplam.TabStop = true;
            this.rdbtnSinavToplam.Text = "Sınav 1 Toplam puan";
            this.rdbtnSinavToplam.UseVisualStyleBackColor = true;
            // 
            // rdbtnSinavOrt
            // 
            this.rdbtnSinavOrt.AutoSize = true;
            this.rdbtnSinavOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnSinavOrt.Location = new System.Drawing.Point(1170, 540);
            this.rdbtnSinavOrt.Name = "rdbtnSinavOrt";
            this.rdbtnSinavOrt.Size = new System.Drawing.Size(270, 33);
            this.rdbtnSinavOrt.TabIndex = 36;
            this.rdbtnSinavOrt.TabStop = true;
            this.rdbtnSinavOrt.Text = "Sınav 1 ortalama puan";
            this.rdbtnSinavOrt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 718);
            this.Controls.Add(this.rdbtnSinavOrt);
            this.Controls.Add(this.rdbtnSinavToplam);
            this.Controls.Add(this.rdnbtnTplmOgrc);
            this.Controls.Add(this.rdbtnDegerVarmi);
            this.Controls.Add(this.rdbtnSonAharfLst);
            this.Controls.Add(this.rdbtnAharfLst);
            this.Controls.Add(this.rdbtnID);
            this.Controls.Add(this.rdbtnİlkUcSirala);
            this.Controls.Add(this.rdbtnTersSirala);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.rdbtnAdSirala);
            this.Controls.Add(this.btnNotLst);
            this.Controls.Add(this.btnDersLst);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrenciLst);
            this.Controls.Add(this.datagrdList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagrdList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrdList;
        private System.Windows.Forms.Button btnOgrenciLst;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgrenciFoto;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnDersLst;
        private System.Windows.Forms.Button btnNotLst;
        private System.Windows.Forms.RadioButton rdbtnAdSirala;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton rdbtnTersSirala;
        private System.Windows.Forms.RadioButton rdbtnİlkUcSirala;
        private System.Windows.Forms.RadioButton rdbtnID;
        private System.Windows.Forms.RadioButton rdbtnAharfLst;
        private System.Windows.Forms.RadioButton rdbtnSonAharfLst;
        private System.Windows.Forms.RadioButton rdbtnDegerVarmi;
        private System.Windows.Forms.RadioButton rdnbtnTplmOgrc;
        private System.Windows.Forms.RadioButton rdbtnSinavToplam;
        private System.Windows.Forms.RadioButton rdbtnSinavOrt;
    }
}

