using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD -> Create Read Update Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("**************************************");
            #region Katagori Ekleme İşlemi
            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();
            //Console.WriteLine("**************************************");

            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-U383BCO;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.WriteLine("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.WriteLine("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection2 = new SqlConnection(@"Data Source=DESKTOP-U383BCO;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection2.Open();
            //SqlCommand command2 = new SqlCommand("Insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection2);
            //command2.Parameters.AddWithValue("@productName", productName);
            //command2.Parameters.AddWithValue("@ProductPrice", productPrice);
            //command2.Parameters.AddWithValue("@ProductStatus", true);
            //command2.ExecuteNonQuery();
            //connection2.Close();
            //Console.WriteLine("Ürün başarıyla eklendi.");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection3 = new SqlConnection(@"Data Source=DESKTOP-U383BCO;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection3.Open();
            //SqlCommand command3 = new SqlCommand("Select * from TblProduct", connection3);
            //SqlDataReader reader = command3.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine("Ürün Adı: " + reader["ProductName"]);
            //    Console.WriteLine("Ürün Fiyatı: " + reader["ProductPrice"]);
            //    Console.WriteLine("Ürün Durumu: " + reader["ProductStatus"]);
            //    Console.WriteLine("**************************************");
            //}
            //connection3.Close();
            //Console.WriteLine("Ürünler listelendi.");
            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silmek istediğiniz ürün id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection4 = new SqlConnection(@"Data Source=DESKTOP-U383BCO;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection4.Open();
            //SqlCommand command4 = new SqlCommand("Delete from TblProduct where ProductId = @productId", connection4);
            //command4.Parameters.AddWithValue("@productId", productId);
            //command4.ExecuteNonQuery();
            //connection4.Close();
            //Console.WriteLine("Ürün başarıyla silindi.");

            #endregion

            #region Ürün Güncelleme İşlemi
            Console.WriteLine("Güncellemek istediğiniz ürün id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Güncellemek istediğiniz ürün adı: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Güncellemek istediğiniz ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection5 = new SqlConnection(@"Data Source=DESKTOP-U383BCO;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection5.Open();
            SqlCommand command5 = new SqlCommand("Update TblProduct set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", connection5);
            command5.Parameters.AddWithValue("@productName", productName);
            command5.Parameters.AddWithValue("@productPrice", productPrice);
            command5.Parameters.AddWithValue("@productId", productId);
            command5.ExecuteNonQuery();
            connection5.Close();
            Console.WriteLine("Ürün başarıyla güncellendi.");

            #endregion
        }
    }
}
