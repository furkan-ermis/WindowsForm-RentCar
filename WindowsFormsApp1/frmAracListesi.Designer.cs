namespace WindowsFormsApp1
{
	partial class frmAracListele
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListele));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnResimEkle = new System.Windows.Forms.Button();
			this.btnIptal = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMarka = new System.Windows.Forms.ComboBox();
			this.cmbSeri = new System.Windows.Forms.ComboBox();
			this.cmbYakit = new System.Windows.Forms.ComboBox();
			this.txtPlaka = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtRenk = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.txtKira = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.cmbAracDurum = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(266, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(662, 447);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
			// 
			// btnResimEkle
			// 
			this.btnResimEkle.BackColor = System.Drawing.Color.FloralWhite;
			this.btnResimEkle.Location = new System.Drawing.Point(204, 111);
			this.btnResimEkle.Name = "btnResimEkle";
			this.btnResimEkle.Size = new System.Drawing.Size(42, 25);
			this.btnResimEkle.TabIndex = 38;
			this.btnResimEkle.Text = "...";
			this.btnResimEkle.UseVisualStyleBackColor = false;
			this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.BackColor = System.Drawing.Color.SeaShell;
			this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIptal.ImageIndex = 2;
			this.btnIptal.ImageList = this.ımageList1;
			this.btnIptal.Location = new System.Drawing.Point(838, 480);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(90, 39);
			this.btnIptal.TabIndex = 37;
			this.btnIptal.Text = "İptal";
			this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIptal.UseVisualStyleBackColor = false;
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "delete.png");
			this.ımageList1.Images.SetKeyName(1, "updated.png");
			this.ımageList1.Images.SetKeyName(2, "exit.png");
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.SeaShell;
			this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuncelle.ImageIndex = 1;
			this.btnGuncelle.ImageList = this.ımageList1;
			this.btnGuncelle.Location = new System.Drawing.Point(45, 480);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(83, 39);
			this.btnGuncelle.TabIndex = 36;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 446);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "Kira Ücreti";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 405);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 34;
			this.label7.Text = "Yakıt";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(57, 364);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Km";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(46, 323);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Renk";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 282);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 31;
			this.label4.Text = "Model (Yıl)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 241);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "Seri";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Marka";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Plaka";
			// 
			// cmbMarka
			// 
			this.cmbMarka.FormattingEnabled = true;
			this.cmbMarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
			this.cmbMarka.Location = new System.Drawing.Point(97, 195);
			this.cmbMarka.Name = "cmbMarka";
			this.cmbMarka.Size = new System.Drawing.Size(121, 21);
			this.cmbMarka.TabIndex = 27;
			this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
			// 
			// cmbSeri
			// 
			this.cmbSeri.FormattingEnabled = true;
			this.cmbSeri.Location = new System.Drawing.Point(97, 236);
			this.cmbSeri.Name = "cmbSeri";
			this.cmbSeri.Size = new System.Drawing.Size(121, 21);
			this.cmbSeri.TabIndex = 26;
			// 
			// cmbYakit
			// 
			this.cmbYakit.FormattingEnabled = true;
			this.cmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
			this.cmbYakit.Location = new System.Drawing.Point(97, 397);
			this.cmbYakit.Name = "cmbYakit";
			this.cmbYakit.Size = new System.Drawing.Size(121, 21);
			this.cmbYakit.TabIndex = 25;
			// 
			// txtPlaka
			// 
			this.txtPlaka.Location = new System.Drawing.Point(97, 155);
			this.txtPlaka.Name = "txtPlaka";
			this.txtPlaka.Size = new System.Drawing.Size(121, 20);
			this.txtPlaka.TabIndex = 24;
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(97, 277);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(121, 20);
			this.txtModel.TabIndex = 23;
			// 
			// txtRenk
			// 
			this.txtRenk.Location = new System.Drawing.Point(97, 317);
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Size = new System.Drawing.Size(121, 20);
			this.txtRenk.TabIndex = 22;
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(97, 357);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(121, 20);
			this.txtKm.TabIndex = 21;
			// 
			// txtKira
			// 
			this.txtKira.Location = new System.Drawing.Point(97, 438);
			this.txtKira.Multiline = true;
			this.txtKira.Name = "txtKira";
			this.txtKira.Size = new System.Drawing.Size(121, 21);
			this.txtKira.TabIndex = 20;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(26, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(172, 124);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 40;
			this.pictureBox2.TabStop = false;
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.SeaShell;
			this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSil.ImageIndex = 0;
			this.btnSil.ImageList = this.ımageList1;
			this.btnSil.Location = new System.Drawing.Point(148, 480);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(70, 38);
			this.btnSil.TabIndex = 42;
			this.btnSil.Text = "Sil";
			this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// cmbAracDurum
			// 
			this.cmbAracDurum.FormattingEnabled = true;
			this.cmbAracDurum.Items.AddRange(new object[] {
            "ARAÇLAR",
            "BOŞ ARAÇLAR",
            "DOLU ARAÇLAR"});
			this.cmbAracDurum.Location = new System.Drawing.Point(266, 465);
			this.cmbAracDurum.Name = "cmbAracDurum";
			this.cmbAracDurum.Size = new System.Drawing.Size(121, 21);
			this.cmbAracDurum.TabIndex = 43;
			this.cmbAracDurum.SelectedIndexChanged += new System.EventHandler(this.cmbAracDurum_SelectedIndexChanged);
			// 
			// frmAracListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OldLace;
			this.ClientSize = new System.Drawing.Size(940, 541);
			this.Controls.Add(this.cmbAracDurum);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnResimEkle);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMarka);
			this.Controls.Add(this.cmbSeri);
			this.Controls.Add(this.cmbYakit);
			this.Controls.Add(this.txtPlaka);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.txtRenk);
			this.Controls.Add(this.txtKm);
			this.Controls.Add(this.txtKira);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmAracListele";
			this.Text = "frmAracListele";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnResimEkle;
		private System.Windows.Forms.Button btnIptal;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMarka;
		private System.Windows.Forms.ComboBox cmbSeri;
		private System.Windows.Forms.ComboBox cmbYakit;
		private System.Windows.Forms.TextBox txtPlaka;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtRenk;
		private System.Windows.Forms.TextBox txtKm;
		private System.Windows.Forms.TextBox txtKira;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.ComboBox cmbAracDurum;
	}
}