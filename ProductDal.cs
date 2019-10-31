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

		public DataTable GetAll2()
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}

			SqlCommand command = new SqlCommand("Select * from Products", _connection);

			SqlDataReader reader = command.ExecuteReader();

			DataTable dataTable = new DataTable();
			dataTable.Load(reader);
			reader.Close();
			_connection.Close();
			return dataTable;

		}

		public void Add(Product product)
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}

			SqlCommand command = new SqlCommand(
				"Insert into Products values (@name,@unitPrice,@stockAmount)", _connection);
			

			command.Parameters.AddWithValue("@name", product.Name);
			command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			command.Parameters.AddWithValue("@stockAmount",product.StockAmount);
			
			command.ExecuteNonQuery();
			_connection.Close();

			
		}

		public void Update(Product product)
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}

			SqlCommand command = new SqlCommand(
				"Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@ıd", _connection);


			command.Parameters.AddWithValue("@name", product.Name);
			command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
			command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
			command.Parameters.AddWithValue("@ıd", product.Id);

			command.ExecuteNonQuery();
			_connection.Close();


		}

		public void Delete(int id)
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}

			SqlCommand command = new SqlCommand(
				"Delete from Products where Id=@id", _connection);


			
			command.Parameters.AddWithValue("@id",id);

			command.ExecuteNonQuery();
			_connection.Close();


		}
	}
}
