using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ProductManagements
{
    internal class ProductRepository
    {
        private readonly Database _database;

        public ProductRepository()
        {
            _database = new Database();
        }

        // Create a new product
        public void AddProduct(Product product)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Products (Name, StockQuantity, Description, Price) VALUES (@Name, @StockQuantity, @Description, @Price)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        // Read all products 
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Products";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                            Description = reader["Description"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"])
                        });
                    }
                }
            }

            return products;
        }

        // Update product
        public void UpdateProduct(Product product)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Products SET Name = @Name, StockQuantity = @StockQuantity, Description = @Description, Price = @Price WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        // Delete a product
        public void DeleteProduct(int productId)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Products WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", productId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product added deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
