﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetDemo
{
	public class ProductDal
	{
		SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=e-trade;integrated security=true");
		public List<Product> GetAll()
		{
			
			
			if(_connection.State==ConnectionState.Closed)
			{
				_connection.Open();
			}

			SqlCommand command = new SqlCommand("Select * from Products",_connection);

			SqlDataReader reader = command.ExecuteReader();

			List<Product> products = new List<Product>();

			while(reader.Read())
			{
				Product product = new Product
				{
					Id = Convert.ToInt32(reader["Id"]),
					Name = reader["Name"].ToString(),
					UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
					StockAmount=Convert.ToInt32(reader["StockAmount"])

				};

				products.Add(product);
			}
			reader.Close();
			_connection.Close();

			return products;


		}
		public void Add(Product product)
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}

			SqlCommand command = new SqlCommand(
				"Insert into Products values(@name,@unitPrice,@stockAmount", _connection);
			SqlCommand command1 = new SqlCommand("insert into musteriler(name,unitPrice,stockAmount,) values (@name,@unitPrice,@stockAmount)", _connection);

			command1.Parameters.AddWithValue("@name", product.Name);
			command1.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			command1.Parameters.AddWithValue("@stockAmount", product.StockAmount);
			command1.Parameters.AddWithValue("@stockAmount", product.StockAmount);
			command1.ExecuteNonQuery();
			_connection.Close();

		}
	}
}
