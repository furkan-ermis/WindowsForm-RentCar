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
	public partial class frmAracListele : Form
	{
		public frmAracListele()
		{
			InitializeComponent();
		}

		Arac_Kiralama sqlConnect = new Arac_Kiralama();
		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow row = dataGridView1.CurrentRow;
			txtPlaka.Text = row.Cells["plaka"].Value.ToString();
			cmbMarka.Text = row.Cells["marka"].Value.ToString();
			cmbSeri.Text = row.Cells["seri"].Value.ToString();
			txtModel.Text = row.Cells["model"].Value.ToString();
			txtRenk.Text = row.Cells["renk"].Value.ToString();
			txtKm.Text = row.Cells["km"].Value.ToString();
			cmbYakit.Text = row.Cells["yakit"].Value.ToString();
			txtKira.Text = row.Cells["kiraUcreti"].Value.ToString();
			pictureBox2.ImageLocation = row.Cells["resim"].Value.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			showTable();
		}

		private void showTable()
		{
			string sqlText = "SELECT * FROM arac";
			SqlDataAdapter adapter = new SqlDataAdapter();
			dataGridView1.DataSource = sqlConnect.listele(adapter, sqlText);
		}

		private void btnResimEkle_Click(object sender, EventArgs e)
		{
			openFileDialog2.ShowDialog();
			pictureBox2.ImageLocation = openFileDialog2.FileName;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			string sqlText = "UPDATE arac SET marka=@marka,seri=@seri,model=@model,renk=@renk,km=@km,yakit=@yakit,tarih=@tarih,kiraUcreti=@kira,resim=@resim WHERE plaka=@plaka";
			SqlCommand UpdateCommand = new SqlCommand();
			UpdateCommand.Parameters.AddWithValue("@marka", cmbMarka.Text);
			UpdateCommand.Parameters.AddWithValue("@seri", cmbSeri.Text);
			UpdateCommand.Parameters.AddWithValue("@model", txtModel.Text);
			UpdateCommand.Parameters.AddWithValue("@renk", txtRenk.Text);
			UpdateCommand.Parameters.AddWithValue("@km", txtKm.Text);
			UpdateCommand.Parameters.AddWithValue("@yakit", cmbYakit.Text);
			UpdateCommand.Parameters.AddWithValue("@kira", txtKira.Text);
			UpdateCommand.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
			UpdateCommand.Parameters.AddWithValue("@plaka", txtPlaka.Text);
			UpdateCommand.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
			sqlConnect.ekle_sil_guncelle(UpdateCommand, sqlText);
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
			showTable();
		}

		private void btnIptal_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DataGridViewRow satir = dataGridView1.CurrentRow;
			string sqlText = "Delete FROM arac WHERE plaka='" + satir.Cells["plaka"].Value.ToString() + "'";
			SqlCommand DeleteCommand = new SqlCommand();
			sqlConnect.ekle_sil_guncelle(DeleteCommand, sqlText);
			foreach (Control item in Controls) if (item is TextBox || item is ComboBox) item.Text = "";
			pictureBox2.ImageLocation = "";
			showTable();
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

		private void cmbAracDurum_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cmbAracDurum.SelectedIndex.ToString() == "0")
				{
					showTable();
				}
				else if (cmbAracDurum.SelectedIndex.ToString() == "1")
				{
					string sqlText = "SELECT * FROM arac WHERE durum='Bos'";
					SqlDataAdapter adapter = new SqlDataAdapter();
					dataGridView1.DataSource = sqlConnect.listele(adapter, sqlText);
				}
				else if (cmbAracDurum.SelectedIndex.ToString() == "2")
				{
					string sqlText = "SELECT * FROM arac WHERE durum='Dolu'";
					SqlDataAdapter adapter = new SqlDataAdapter();
					dataGridView1.DataSource = sqlConnect.listele(adapter, sqlText);
				}

			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
