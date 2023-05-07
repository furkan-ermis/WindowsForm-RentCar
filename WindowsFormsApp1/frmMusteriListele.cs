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
	public partial class frmMusteriListele : Form
	{
		Arac_Kiralama sqlConnect = new Arac_Kiralama();
		public frmMusteriListele()
		{
			InitializeComponent();
		}
		private void frmMusteriListele_Load(object sender, EventArgs e)
		{
			ShowTable();
		}
		private void ShowTable()
		{
			string sqlText = "SELECT * FROM musteri";
			SqlDataAdapter adaptor1 = new SqlDataAdapter();
			dataGridView1.DataSource = sqlConnect.listele(adaptor1, sqlText);
			dataGridView1.Columns[0].HeaderText = "TC";
			dataGridView1.Columns[1].HeaderText = "Ad Soyad";
			dataGridView1.Columns[2].HeaderText = "Telefon";
			dataGridView1.Columns[3].HeaderText = "Adres";
			dataGridView1.Columns[4].HeaderText = "Email";
		}
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string sqlText = "SELECT * FROM musteri WHERE tc LIKE '%" + txtSearch.Text + "%'";
			SqlDataAdapter adaptor1 = new SqlDataAdapter();
			dataGridView1.DataSource = sqlConnect.listele(adaptor1, sqlText);
		}
		private void btnIptal_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow satir = dataGridView1.CurrentRow;
			txtTc.Text = satir.Cells[0].Value.ToString();
			txtName.Text = satir.Cells[1].Value.ToString();
			txtPhone.Text = satir.Cells[2].Value.ToString();
			txtAdres.Text = satir.Cells[3].Value.ToString();
			txtEmail.Text = satir.Cells[4].Value.ToString();
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			string sqlText = "UPDATE musteri SET adsoyad=@ad,telefon=@telefon,adres=@adres,email=@email WHERE tc=@tc";
			SqlCommand UpdateCommand = new SqlCommand();
			UpdateCommand.Parameters.AddWithValue("@tc", txtTc.Text);
			UpdateCommand.Parameters.AddWithValue("@ad", txtName.Text);
			UpdateCommand.Parameters.AddWithValue("@telefon", txtPhone.Text);
			UpdateCommand.Parameters.AddWithValue("@adres", txtAdres.Text);
			UpdateCommand.Parameters.AddWithValue("@email", txtEmail.Text);
			sqlConnect.ekle_sil_guncelle(UpdateCommand, sqlText);
			foreach (Control item in Controls) if (item is TextBox) item.Text = "";
			ShowTable();
		}
		private void btnSil_Click(object sender, EventArgs e)
		{
			DataGridViewRow satir = dataGridView1.CurrentRow;
			string sqlText = "Delete FROM musteri WHERE tc='" + satir.Cells["tc"].Value.ToString() + "'";
			SqlCommand DeleteCommand = new SqlCommand();
			sqlConnect.ekle_sil_guncelle(DeleteCommand, sqlText);
			foreach (Control item in Controls) if (item is TextBox) item.Text = "";
			ShowTable();
		}
	}
}
