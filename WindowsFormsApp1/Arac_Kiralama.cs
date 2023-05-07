using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	internal class Arac_Kiralama
	{
		/// <summary>
		/// SQL SERVER BAĞLANTI SINIFI 
		/// baglanti nesnesi sayesinde ilgili database e bağlandık 
		/// ekle_sil_güncelle metodu sayesinde aldığı komut parametresiyle girilecek veriyi tablo kolonlarına uygun biçimde belirtip sorgu metninde (t-sql dilinde) ekledik
		/// </summary>
		SqlConnection baglanti = new SqlConnection("Data Source=FURKANERMIS;Initial Catalog=Arac_Kiralama;Integrated Security=True");
		DataTable tablo;
		public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
		{
			baglanti.Open();
			komut.Connection = baglanti;
			komut.CommandText = sorgu;
			komut.ExecuteNonQuery();
			baglanti.Close();
		}
		public DataTable listele(SqlDataAdapter adaptor, string sorgu)
		{
			tablo = new DataTable();
			adaptor = new SqlDataAdapter(sorgu, baglanti);
			adaptor.Fill(tablo);
			baglanti.Close();
			return tablo;
		}
		public void bosAraclar(string sorgu, ComboBox combo)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				combo.Items.Add(reader["plaka"].ToString());
			}
			baglanti.Close();

		}
		public void tcAra(string sorgu, TextBox tc, TextBox adsoyad, TextBox telefon)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				adsoyad.Text = reader["adsoyad"].ToString();
				telefon.Text = reader["telefon"].ToString();
			}
			baglanti.Close();
		}
		public void Combos(string sorgu, ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				marka.Text = reader["marka"].ToString();
				seri.Text = reader["seri"].ToString();
				renk.Text = reader["renk"].ToString();
				yil.Text = reader["model"].ToString();
			}
			baglanti.Close();
		}
		public void ucretHesapla(string sorgu, ComboBox cmbKira, TextBox ucret)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				if (cmbKira.SelectedIndex == 0) ucret.Text = (int.Parse(reader["kiraUcreti"].ToString()) * 1).ToString();
				else if (cmbKira.SelectedIndex == 1) ucret.Text = (int.Parse(reader["kiraUcreti"].ToString()) * 0.80).ToString();
				else if (cmbKira.SelectedIndex == 2) ucret.Text = (int.Parse(reader["kiraUcreti"].ToString()) * 0.70).ToString();
			}
			baglanti.Close();
		}
	}
}
