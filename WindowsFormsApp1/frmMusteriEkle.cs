using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frmMusteriEkle : Form
	{
		public frmMusteriEkle()
		{
			InitializeComponent();
		}
		/// <summary>
		/// sqlConnect ile SQL BAĞLANTISI İÇİN OLUŞTURDUĞUMUZ SINIF İLE DATABASE BAĞLANTISINDA KULLANICAĞIMIZ SINIFIN NESNESİNİ OLUŞTURDUK
		/// </summary>
		Arac_Kiralama sqlConnect = new Arac_Kiralama();
		private void btnIptal_Click(object sender, EventArgs e)
		{
			Close();
		}
		/// <summary>
		/// OLUŞAN	sqlConnect bağlantı nesnemizin parametrelerini oluşturduk ,
		/// sorgu metni için sqlText , 
		/// SqlCommand tipinde istenen parametre için insertCommand nesnesini oluşturduk ve içerisine TABLO KOLON VERİLERİNİ PARAMETRELERİYLE EŞLEŞTİREREK GÖNDERDİK
		/// EN SON bağlantı sınıfının nesnesinin metodunu çağırarak butona tıklandığında verimizi database tablosuna ekledik
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEkle_Click(object sender, EventArgs e)
		{
			string sqlText = "INSERT INTO musteri(tc,adsoyad,telefon,adres,email) VALUES(@tc,@adsoyad,@telefon,@adres,@email)";
			SqlCommand insertCommand = new SqlCommand();
			insertCommand.Parameters.AddWithValue("@tc", txtTc.Text);
			insertCommand.Parameters.AddWithValue("@adsoyad", txtName.Text);
			insertCommand.Parameters.AddWithValue("@telefon", txtPhone.Text);
			insertCommand.Parameters.AddWithValue("@adres", txtAdres.Text);
			insertCommand.Parameters.AddWithValue("@email", txtEmail.Text);
			sqlConnect.ekle_sil_guncelle(insertCommand, sqlText);
			foreach (Control item in Controls) if (item is TextBox) item.Text = "";
		}
	}
}
