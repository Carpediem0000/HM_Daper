using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace HM_Daper
{
    internal class ProdService
    {
        private static readonly string _connectionString = @"Server=DESKTOP-3Q1VDF0\SQLEXPRESS;Database=ProductBase;Integrated Security=True;";


        public void AddProduct(Product product)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Products(Name, Price) " +
                    "VALUES(@Name, @Price)";
                conn.Open();
                conn.Execute(sql, product);
            }
        }
        public Product GetProductById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Products WHERE ProductId = @Id";
                return connection.QueryFirstOrDefault<Product>(sql, new { Id = id });
            }
        }
        public IEnumerable<Product> GetAllProducts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Products";
                return connection.Query<Product>(sql).ToList();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "UPDATE Products SET Name = @Name, Price = @Price WHERE ProductId = @ProductId";
                connection.Execute(sql, product);
            }
        }
        public void DeleteProduct(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Products WHERE ProductId = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}
