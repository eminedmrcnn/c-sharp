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



namespace Ado.NetDemo
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=e-trade;integrated security=true");


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
				Name = textBox1.Text,
				UnitPrice = Convert.ToDecimal(textBox2.Text),
				StockAmount = Convert.ToInt32(textBox3.Text)
			});

			MessageBox.Show("Product Added!");











		}





		private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
