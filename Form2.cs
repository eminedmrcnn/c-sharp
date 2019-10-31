using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ado.NetDemo
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		//SqlConnection baglanti = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=e-trade;integrated security=true");


		//SqlConnection baglanti = new SqlConnection();


		ProductDal _productDal = new ProductDal();

		private void Form2_Load(object sender, EventArgs e)
		{
			dgwProducts.DataSource = _productDal.GetAll();
		}
	
		private void button1_Click(object sender, EventArgs e)
		{

			_productDal.Add(new Product
			{
				Name = textBox1.Text.ToString(),
				UnitPrice = Convert.ToDecimal(textBox2.Text),
				StockAmount = Convert.ToInt32(textBox3.Text)
			});

			dgwProducts.DataSource = _productDal.GetAll();
			MessageBox.Show("Product Added!");
		}

		private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)  //verilerin update in içine yazılmasını sağlıyorum..
		{
			txbNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
			txbUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
			txbStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)     //değerlerin güncellenmesini sağlıyorum..
		{
			Product product = new Product()
			{
				Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),  
				Name = txbNameUpdate.Text,
				UnitPrice = Convert.ToDecimal(txbUnitPriceUpdate.Text),
				StockAmount= Convert.ToInt32(txbStockAmountUpdate.Text)
			};
			_productDal.Update(product);
			dgwProducts.DataSource = _productDal.GetAll();
			MessageBox.Show("Updated!");
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
			_productDal.Delete(id);
			dgwProducts.DataSource = _productDal.GetAll();
			MessageBox.Show("Deleted!");
		}
	}
}
