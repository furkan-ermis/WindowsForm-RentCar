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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
	public partial class frmAracEkle : Form
	{
		Arac_Kiralama sqlConnect = new Arac_Kiralama();
		public frmAracEkle()
		{
			InitializeComponent();
		}

		private void btnResimEkle_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			pictureBox1.ImageLocation = openFileDialog1.FileName;
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				cmbSeri.Items.Clear();
				if (cmbMarka.SelectedIndex.ToString() == "0")
				{

					cmbSeri.Items.Add("Astra");
					cmbSeri.Items.Add("Vectra");
					cmbSeri.Items.Add("Corsa");
				}
				else if (cmbMarka.SelectedIndex.ToString() == "1")
				{

					cmbSeri.Items.Add("Clio");
					cmbSeri.Items.Add("Megan");
					cmbSeri.Items.Add("Vectra");
				}
				else if (cmbMarka.SelectedIndex.ToString() == "2")
				{

					cmbSeri.Items.Add("Libea");
					cmbSeri.Items.Add("Egea");
				}
				else if (cmbMarka.SelectedIndex.ToString() == "3")
				{

					cmbSeri.Items.Add("Fiesta");
					cmbSeri.Items.Add("Focus");
				}
			}
			catch (Exception)
			{

				throw;
			}

		}

		private void btnKayit_Click(object sender, EventArgs e)
		{
			string sqlText = "INSERT INTO arac(plaka,marka,seri,model,renk,km,yakit,kiraUcreti,resim,tarih,durum) VALUES(@plaka,@marka,@seri,@model,@renk,@km,@yakit,@kiraUcreti,@resim,@tarih,@durum)";
			SqlCommand insertCommand = new SqlCommand();
			insertCommand.Parameters.AddWithValue("@plaka", txtPlaka.Text);
			insertCommand.Parameters.AddWithValue("@marka", cmbMarka.Text);
			insertCommand.Parameters.AddWithValue("@seri", cmbSeri.Text);
			insertCommand.Parameters.AddWithValue("@model", txtModel.Text);
			insertCommand.Parameters.AddWithValue("@renk", txtRenk.Text);
			insertCommand.Parameters.AddWithValue("@km", txtKm.Text);
			insertCommand.Parameters.AddWithValue("@yakit", cmbYakit.Text);
			insertCommand.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation.ToString());
			insertCommand.Parameters.AddWithValue("@kiraUcreti", int.Parse(txtKira.Text));
			insertCommand.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
			insertCommand.Parameters.AddWithValue("@durum", "Bos");
			sqlConnect.ekle_sil_guncelle(insertCommand, sqlText);
			cmbSeri.Items.Clear();
			foreach (Control item in Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}
				else if (item is ComboBox)
				{

					item.Text = "";
				}
			}
		}
	}
}
