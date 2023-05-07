namespace WindowsFormsApp1
{
	partial class frmAracEkle
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
			this.txtKira = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.txtRenk = new System.Windows.Forms.TextBox();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtPlaka = new System.Windows.Forms.TextBox();
			this.cmbYakit = new System.Windows.Forms.ComboBox();
			this.cmbSeri = new System.Windows.Forms.ComboBox();
			this.cmbMarka = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnKayit = new System.Windows.Forms.Button();
			this.btnIptal = new System.Windows.Forms.Button();
			this.btnResimEkle = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKira
			// 
			this.txtKira.Location = new System.Drawing.Point(114, 320);
			this.txtKira.Multiline = true;
			this.txtKira.Name = "txtKira";
			this.txtKira.Size = new System.Drawing.Size(121, 21);
			this.txtKira.TabIndex = 0;
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(114, 239);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(121, 20);
			this.txtKm.TabIndex = 1;
			// 
			// txtRenk
			// 
			this.txtRenk.Location = new System.Drawing.Point(114, 199);
			this.txtRenk.Name = "txtRenk";
			this.txtRenk.Size = new System.Drawing.Size(121, 20);
			this.txtRenk.TabIndex = 2;
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(114, 159);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(121, 20);
			this.txtModel.TabIndex = 3;
			// 
			// txtPlaka
			// 
			this.txtPlaka.Location = new System.Drawing.Point(114, 37);
			this.txtPlaka.Name = "txtPlaka";
			this.txtPlaka.Size = new System.Drawing.Size(121, 20);
			this.txtPlaka.TabIndex = 4;
			// 
			// cmbYakit
			// 
			this.cmbYakit.FormattingEnabled = true;
			this.cmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
			this.cmbYakit.Location = new System.Drawing.Point(114, 279);
			this.cmbYakit.Name = "cmbYakit";
			this.cmbYakit.Size = new System.Drawing.Size(121, 21);
			this.cmbYakit.TabIndex = 5;
			// 
			// cmbSeri
			// 
			this.cmbSeri.FormattingEnabled = true;
			this.cmbSeri.Location = new System.Drawing.Point(114, 118);
			this.cmbSeri.Name = "cmbSeri";
			this.cmbSeri.Size = new System.Drawing.Size(121, 21);
			this.cmbSeri.TabIndex = 6;
			// 
			// cmbMarka
			// 
			this.cmbMarka.FormattingEnabled = true;
			this.cmbMarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
			this.cmbMarka.Location = new System.Drawing.Point(114, 77);
			this.cmbMarka.Name = "cmbMarka";
			this.cmbMarka.Size = new System.Drawing.Size(121, 21);
			this.cmbMarka.TabIndex = 7;
			this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Plaka";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Marka";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Seri";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Model (Yıl)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(63, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Renk";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(74, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Km";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(65, 287);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Yakıt";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 328);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Kira Ücreti";
			// 
			// btnKayit
			// 
			this.btnKayit.Location = new System.Drawing.Point(62, 385);
			this.btnKayit.Name = "btnKayit";
			this.btnKayit.Size = new System.Drawing.Size(75, 23);
			this.btnKayit.TabIndex = 16;
			this.btnKayit.Text = "Kayıt";
			this.btnKayit.UseVisualStyleBackColor = true;
			this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
			// 
			// btnIptal
			// 
			this.btnIptal.Location = new System.Drawing.Point(143, 385);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(75, 23);
			this.btnIptal.TabIndex = 17;
			this.btnIptal.Text = "İptal";
			this.btnIptal.UseVisualStyleBackColor = true;
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// btnResimEkle
			// 
			this.btnResimEkle.Location = new System.Drawing.Point(309, 197);
			this.btnResimEkle.Name = "btnResimEkle";
			this.btnResimEkle.Size = new System.Drawing.Size(75, 23);
			this.btnResimEkle.TabIndex = 18;
			this.btnResimEkle.Text = "ResimEkle";
			this.btnResimEkle.UseVisualStyleBackColor = true;
			this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(262, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(169, 140);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// ımageList1
			// 
			this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ımageList1.ImageSize = new System.Drawing.Size(30, 30);
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialog2";
			// 
			// frmAracEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(443, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnResimEkle);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnKayit);
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
			this.Name = "frmAracEkle";
			this.Text = "frmAracEkle";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtKira;
		private System.Windows.Forms.TextBox txtKm;
		private System.Windows.Forms.TextBox txtRenk;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtPlaka;
		private System.Windows.Forms.ComboBox cmbYakit;
		private System.Windows.Forms.ComboBox cmbSeri;
		private System.Windows.Forms.ComboBox cmbMarka;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnKayit;
		private System.Windows.Forms.Button btnIptal;
		private System.Windows.Forms.Button btnResimEkle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
	}
}