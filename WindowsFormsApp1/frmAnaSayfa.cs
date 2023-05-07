using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frmAnaSayfa : Form
	{
		public frmAnaSayfa()
		{
			InitializeComponent();
		}
		private void button7_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmMusteriEkle frmAddCustomer = new frmMusteriEkle();
			frmAddCustomer.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frmMusteriListele frmShowCostumer = new frmMusteriListele();
			frmShowCostumer.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			frmAracEkle frmAracEkle = new frmAracEkle();
			frmAracEkle.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			frmAracListele frmAracListele = new frmAracListele();
			frmAracListele.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			frmSozlesme frmSozlesme = new frmSozlesme();
			frmSozlesme.ShowDialog();
		}
	}
}
