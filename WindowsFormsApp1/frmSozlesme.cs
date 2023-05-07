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
	public partial class frmSozlesme : Form
	{
		public frmSozlesme()
		{
			InitializeComponent();
		}
		Arac_Kiralama arac = new Arac_Kiralama();
		private void frmSozlesme_Load(object sender, EventArgs e)
		{
			string sorgu2 = "select * from arac where durum='Bos'";
			arac.bosAraclar(sorgu2, cmbAraclar);
			showTable();
		}

		private void showTable()
		{
			string sorgu3 = "select * from sozlesme";
			SqlDataAdapter adapter = new SqlDataAdapter();
			dataGridView1.DataSource = arac.listele(adapter, sorgu3);
		}

		private void txtTc_TextChanged(object sender, EventArgs e)
		{
			if (txtTc.Text == String.Empty)
			{
				foreach (Control item in groupBox1.Controls)
				{
					if (item is TextBox)
					{
						item.Text = "";
					}
				}
			}
			else
			{
				string sorgu2 = "select * from musteri where tc like '" + txtTc.Text + "%'";
				arac.tcAra(sorgu2, txtTc, txtName, txtTelefon);
			}
		}

		private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sorgu2 = "select * from arac where plaka like '" + cmbAraclar.SelectedItem + "'";
			arac.Combos(sorgu2, cmbAraclar, txtMarka, txtSeri, txtModel, txtRenk);
		}

		private void cmbKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sorgu2 = "select * from arac where plaka like '" + cmbAraclar.SelectedItem + "'";
			arac.ucretHesapla(sorgu2, cmbKiraSekli, txtKiraUcreti);
		}

		private void btnHesapla_Click(object sender, EventArgs e)
		{
			TimeSpan gunSayisi = DateTime.Parse(dtpDonus.Text) - DateTime.Parse(dtpCikis.Text);
			int gun = gunSayisi.Days;
			txtGun.Text = gun.ToString();
			txtTutar.Text = (int.Parse(txtKiraUcreti.Text) * gun).ToString();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			CalcClear();
		}

		private void CalcClear()
		{
			dtpDonus.Text = DateTime.Now.ToShortDateString();
			dtpCikis.Text = DateTime.Now.ToShortDateString();
			cmbKiraSekli.Text = "";
			txtKiraUcreti.Text = "";
			txtGun.Text = "";
			txtTutar.Text = "";
		}
	}
}
