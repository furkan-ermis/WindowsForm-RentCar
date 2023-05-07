namespace WindowsFormsApp1
{
	partial class frmSozlesme
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSozlesme));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEYer = new System.Windows.Forms.TextBox();
			this.txtETarih = new System.Windows.Forms.TextBox();
			this.txtENo = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtTc = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbKiraSekli = new System.Windows.Forms.ComboBox();
			this.cmbAraclar = new System.Windows.Forms.ComboBox();
			this.dtpDonus = new System.Windows.Forms.DateTimePicker();
			this.dtpCikis = new System.Windows.Forms.DateTimePicker();
			this.txtTutar = new System.Windows.Forms.TextBox();
			this.txtGun = new System.Windows.Forms.TextBox();
			this.txtKiraUcreti = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtRenk = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSeri = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtMarka = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSozlesme = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnHesapla = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEYer);
			this.groupBox1.Controls.Add(this.txtETarih);
			this.groupBox1.Controls.Add(this.txtENo);
			this.groupBox1.Controls.Add(this.txtTelefon);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.txtTc);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 208);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri Bilgileri";
			// 
			// txtEYer
			// 
			this.txtEYer.Location = new System.Drawing.Point(157, 177);
			this.txtEYer.Name = "txtEYer";
			this.txtEYer.Size = new System.Drawing.Size(100, 20);
			this.txtEYer.TabIndex = 10;
			// 
			// txtETarih
			// 
			this.txtETarih.Location = new System.Drawing.Point(157, 150);
			this.txtETarih.Name = "txtETarih";
			this.txtETarih.Size = new System.Drawing.Size(100, 20);
			this.txtETarih.TabIndex = 9;
			// 
			// txtENo
			// 
			this.txtENo.Location = new System.Drawing.Point(157, 120);
			this.txtENo.Name = "txtENo";
			this.txtENo.Size = new System.Drawing.Size(100, 20);
			this.txtENo.TabIndex = 8;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Location = new System.Drawing.Point(157, 90);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(100, 20);
			this.txtTelefon.TabIndex = 7;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(157, 60);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 6;
			// 
			// txtTc
			// 
			this.txtTc.Location = new System.Drawing.Point(157, 27);
			this.txtTc.Name = "txtTc";
			this.txtTc.Size = new System.Drawing.Size(100, 20);
			this.txtTc.TabIndex = 0;
			this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ehliyetin Verildiği Yer";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ehliyet Tarihi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ehliyet No.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefon";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ad Soyad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TC";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnClear);
			this.groupBox2.Controls.Add(this.btnHesapla);
			this.groupBox2.Controls.Add(this.cmbKiraSekli);
			this.groupBox2.Controls.Add(this.cmbAraclar);
			this.groupBox2.Controls.Add(this.dtpDonus);
			this.groupBox2.Controls.Add(this.dtpCikis);
			this.groupBox2.Controls.Add(this.txtTutar);
			this.groupBox2.Controls.Add(this.txtGun);
			this.groupBox2.Controls.Add(this.txtKiraUcreti);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtRenk);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.txtModel);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtSeri);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtMarka);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(296, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(540, 208);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Araç Bilgileri";
			// 
			// cmbKiraSekli
			// 
			this.cmbKiraSekli.FormattingEnabled = true;
			this.cmbKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
			this.cmbKiraSekli.Location = new System.Drawing.Point(337, 27);
			this.cmbKiraSekli.Name = "cmbKiraSekli";
			this.cmbKiraSekli.Size = new System.Drawing.Size(121, 21);
			this.cmbKiraSekli.TabIndex = 29;
			this.cmbKiraSekli.SelectedIndexChanged += new System.EventHandler(this.cmbKiraSekli_SelectedIndexChanged);
			// 
			// cmbAraclar
			// 
			this.cmbAraclar.FormattingEnabled = true;
			this.cmbAraclar.Location = new System.Drawing.Point(84, 31);
			this.cmbAraclar.Name = "cmbAraclar";
			this.cmbAraclar.Size = new System.Drawing.Size(121, 21);
			this.cmbAraclar.TabIndex = 28;
			this.cmbAraclar.SelectedIndexChanged += new System.EventHandler(this.cmbAraclar_SelectedIndexChanged);
			// 
			// dtpDonus
			// 
			this.dtpDonus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDonus.Location = new System.Drawing.Point(340, 177);
			this.dtpDonus.Name = "dtpDonus";
			this.dtpDonus.Size = new System.Drawing.Size(97, 20);
			this.dtpDonus.TabIndex = 27;
			// 
			// dtpCikis
			// 
			this.dtpCikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCikis.Location = new System.Drawing.Point(340, 151);
			this.dtpCikis.Name = "dtpCikis";
			this.dtpCikis.Size = new System.Drawing.Size(97, 20);
			this.dtpCikis.TabIndex = 26;
			// 
			// txtTutar
			// 
			this.txtTutar.Location = new System.Drawing.Point(337, 121);
			this.txtTutar.Name = "txtTutar";
			this.txtTutar.Size = new System.Drawing.Size(100, 20);
			this.txtTutar.TabIndex = 25;
			// 
			// txtGun
			// 
			this.txtGun.Location = new System.Drawing.Point(337, 91);
			this.txtGun.Name = "txtGun";
			this.txtGun.Size = new System.Drawing.Size(100, 20);
			this.txtGun.TabIndex = 24;
			// 
			// txtKiraUcreti
			// 
			this.txtKiraUcreti.Location = new System.Drawing.Point(337, 61);
			this.txtKiraUcreti.Name = "txtKiraUcreti";
			this.txtKiraUcreti.Size = new System.Drawing.Size(100, 20);
			this.txtKiraUcreti.TabIndex = 23;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(244, 183);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(67, 13);
			this.label17.TabIndex = 21;
			this.label17.Text = "Dönüş Tarihi";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(244, 124);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 13);
			this.label16.TabIndex = 20;
			this.label16.Text = "Tutar";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(244, 154);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(58, 13);
			this.label15.TabIndex = 19;
			this.label15.Text = "Çıkış Tarihi";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(244, 94);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(27, 13);
			this.label14.TabIndex = 18;
			this.label14.Text = "Gün";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(244, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 13);
			this.label13.TabIndex = 17;
			this.label13.Text = "Kira Ücreti";
			// 
			// txtRenk
			// 
			this.txtRenk.Location = new System.Drawing.Point(84, 154);
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Size = new System.Drawing.Size(100, 20);
			this.txtRenk.TabIndex = 15;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(21, 157);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "Renk";
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(84, 124);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(100, 20);
			this.txtModel.TabIndex = 14;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(244, 31);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(51, 13);
			this.label11.TabIndex = 15;
			this.label11.Text = "Kira Şekli";
			// 
			// txtSeri
			// 
			this.txtSeri.Location = new System.Drawing.Point(84, 94);
			this.txtSeri.Name = "txtSeri";
			this.txtSeri.Size = new System.Drawing.Size(100, 20);
			this.txtSeri.TabIndex = 13;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(21, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "Model(Yıl)";
			// 
			// txtMarka
			// 
			this.txtMarka.Location = new System.Drawing.Point(84, 64);
			this.txtMarka.Name = "txtMarka";
			this.txtMarka.Size = new System.Drawing.Size(100, 20);
			this.txtMarka.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(21, 97);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Seri";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 63);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Marka";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Araçlar";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(41, 271);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(824, 254);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnSozlesme
			// 
			this.btnSozlesme.BackColor = System.Drawing.Color.White;
			this.btnSozlesme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSozlesme.ImageIndex = 0;
			this.btnSozlesme.ImageList = this.ımageList1;
			this.btnSozlesme.Location = new System.Drawing.Point(320, 224);
			this.btnSozlesme.Name = "btnSozlesme";
			this.btnSozlesme.Size = new System.Drawing.Size(119, 46);
			this.btnSozlesme.TabIndex = 3;
			this.btnSozlesme.Text = "Sözleşme Ekle";
			this.btnSozlesme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSozlesme.UseVisualStyleBackColor = false;
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "contract.png");
			this.ımageList1.Images.SetKeyName(1, "updated.png");
			this.ımageList1.Images.SetKeyName(2, "car.png");
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.ımageList1;
			this.button2.Location = new System.Drawing.Point(440, 224);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 46);
			this.button2.TabIndex = 28;
			this.button2.Text = "Sözleşme Güncelle";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.ImageIndex = 2;
			this.button1.ImageList = this.ımageList1;
			this.button1.Location = new System.Drawing.Point(732, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 46);
			this.button1.TabIndex = 29;
			this.button1.Text = "Araç Teslim";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnHesapla
			// 
			this.btnHesapla.Location = new System.Drawing.Point(459, 94);
			this.btnHesapla.Name = "btnHesapla";
			this.btnHesapla.Size = new System.Drawing.Size(75, 23);
			this.btnHesapla.TabIndex = 30;
			this.btnHesapla.Text = "button3";
			this.btnHesapla.UseVisualStyleBackColor = true;
			this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(459, 143);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 31;
			this.btnClear.Text = "button3";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmSozlesme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightPink;
			this.ClientSize = new System.Drawing.Size(916, 537);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSozlesme);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmSozlesme";
			this.Text = "Sözleşme";
			this.Load += new System.EventHandler(this.frmSozlesme_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtEYer;
		private System.Windows.Forms.TextBox txtETarih;
		private System.Windows.Forms.TextBox txtENo;
		private System.Windows.Forms.TextBox txtTelefon;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtTc;
		private System.Windows.Forms.TextBox txtRenk;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSeri;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtMarka;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtAraclar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpDonus;
		private System.Windows.Forms.DateTimePicker dtpCikis;
		private System.Windows.Forms.TextBox txtTutar;
		private System.Windows.Forms.TextBox txtGun;
		private System.Windows.Forms.TextBox txtKiraUcreti;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSozlesme;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.ComboBox cmbAraclar;
		private System.Windows.Forms.ComboBox cmbKiraSekli;
		private System.Windows.Forms.Button btnHesapla;
		private System.Windows.Forms.Button btnClear;
	}
}