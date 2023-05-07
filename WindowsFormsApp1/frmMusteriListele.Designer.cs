namespace WindowsFormsApp1
{
	partial class frmMusteriListele
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListele));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnIptal = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTc = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(253, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(535, 256);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// btnIptal
			// 
			this.btnIptal.BackColor = System.Drawing.Color.White;
			this.btnIptal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIptal.ImageIndex = 0;
			this.btnIptal.ImageList = this.ımageList1;
			this.btnIptal.Location = new System.Drawing.Point(12, 381);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(96, 57);
			this.btnIptal.TabIndex = 29;
			this.btnIptal.Text = "Iptal";
			this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIptal.UseVisualStyleBackColor = false;
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "exit.png");
			this.ımageList1.Images.SetKeyName(1, "delete.png");
			this.ımageList1.Images.SetKeyName(2, "updated.png");
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.White;
			this.btnGuncelle.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuncelle.ImageIndex = 2;
			this.btnGuncelle.ImageList = this.ımageList1;
			this.btnGuncelle.Location = new System.Drawing.Point(636, 357);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(117, 59);
			this.btnGuncelle.TabIndex = 28;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 307);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "Adres";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Telefon";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Ad Soyad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "TC";
			// 
			// txtTc
			// 
			this.txtTc.Location = new System.Drawing.Point(91, 99);
			this.txtTc.Multiline = true;
			this.txtTc.Name = "txtTc";
			this.txtTc.Size = new System.Drawing.Size(156, 36);
			this.txtTc.TabIndex = 22;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(91, 149);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(156, 36);
			this.txtName.TabIndex = 21;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(91, 199);
			this.txtPhone.Multiline = true;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(156, 36);
			this.txtPhone.TabIndex = 20;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(91, 299);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(156, 36);
			this.txtEmail.TabIndex = 19;
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(91, 249);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(156, 36);
			this.txtAdres.TabIndex = 18;
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.White;
			this.btnSil.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSil.ImageIndex = 1;
			this.btnSil.ImageList = this.ımageList1;
			this.btnSil.Location = new System.Drawing.Point(527, 357);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(89, 59);
			this.btnSil.TabIndex = 30;
			this.btnSil.Text = "Sil";
			this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(658, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "TC";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(661, 40);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(127, 24);
			this.txtSearch.TabIndex = 31;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(578, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 18);
			this.label8.TabIndex = 34;
			this.label8.Text = "Arama ";
			// 
			// frmMusteriListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTc);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmMusteriListele";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müşteri Listesi";
			this.Load += new System.EventHandler(this.frmMusteriListele_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnIptal;
		private System.Windows.Forms.ImageList ımageList1;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTc;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label8;
	}
}