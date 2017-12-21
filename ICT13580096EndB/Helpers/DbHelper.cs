using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580096EndB.Model;
using SQLite;

namespace ICT13580096EndB.Helpers


{
	public class DbHelper
	{
		SQLiteConnection db;

		public DbHelper(String dbPath)

		{
			db = new SQLiteConnection(dbPath);
			db.CreateTable<Product>();
		}

		public int AddProduct(Product product)
		{
			return db.Insert(product);
		}
		public List<Product> GetProducts()
		{
			return db.Table<Product>().ToList();

		}
		public int UpdateProduct(Product product)
		{
			return db.Update(product);
		}
		public int DeleteProduct(Product product)
		{
			return db.Delete(product);
		}
	}
}