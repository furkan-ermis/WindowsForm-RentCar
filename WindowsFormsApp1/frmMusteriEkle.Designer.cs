namespace WindowsFormsApp1
{
	partial class frmMusteriEkle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriEkle));
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtTc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnIptal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(157, 182);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(158, 31);
			this.txtAdres.TabIndex = 4;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(157, 232);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(158, 31);
			this.txtEmail.TabIndex = 6;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(157, 132);
			this.txtPhone.Multiline = true;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(158, 31);
			this.txtPhone.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(157, 82);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(158, 31);
			this.txtName.TabIndex = 9;
			// 
			// txtTc
			// 
			this.txtTc.Location = new System.Drawing.Point(157, 32);
			this.txtTc.Multiline = true;
			this.txtTc.Name = "txtTc";
			this.txtTc.Size = new System.Drawing.Size(158, 31);
			this.txtTc.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(91, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "TC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Ad Soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Telefon";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(91, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Adres";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(91, 235);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Email";
			// 
			// btnEkle
			// 
			this.btnEkle.BackColor = System.Drawing.Color.White;
			this.btnEkle.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEkle.ImageIndex = 0;
			this.btnEkle.ImageList = this.ımageList1;
			this.btnEkle.Location = new System.Drawing.Point(117, 281);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(86, 39);
			this.btnEkle.TabIndex = 16;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "addCostumer.png");
			this.ımageList1.Images.SetKeyName(1, "exit.png");
			// 
			// btnIptal
			// 
			this.btnIptal.BackColor = System.Drawing.Color.White;
			this.btnIptal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIptal.ImageIndex = 1;
			this.btnIptal.ImageList = this.ımageList1;
			this.btnIptal.Location = new System.Drawing.Point(224, 281);
			this.btnIptal.Name = "btnIptal";
			this.btnIptal.Size = new System.Drawing.Size(91, 39);
			this.btnIptal.TabIndex = 17;
			this.btnIptal.Text = "Iptal";
			this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIptal.UseVisualStyleBackColor = false;
			this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
			// 
			// frmMusteriEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(416, 397);
			this.Controls.Add(this.btnIptal);
			this.Controls.Add(this.btnEkle);
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
			this.Name = "frmMusteriEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müsteri Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtTc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnIptal;
		private System.Windows.Forms.ImageList ımageList1;
	}
}