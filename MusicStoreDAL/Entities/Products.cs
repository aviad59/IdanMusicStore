using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicStoreDAL.Entities
{
    class Products
    {
        static string tableName = "Products";

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="supplierID"></param>
        /// <param name="categoryID"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public static int AddNewProduct(string name, string supplierID, string categoryID, string price, string color, string description, string image)
        {
            string sql = $"INSERT INTO {tableName} ( P_ProductName, P_SupplierID, P_CategoryID, P_Price, P_Color, P_Description, P_Picture) " +
                $"VALUES ('{name}', '{supplierID}', '{categoryID}', '{price}', '{color}', '{description}', '{image}')";
            return OleDbHelper.InsertWithAutoNumKey(sql);
        }

        /// <summary>
        /// Give you all the products exists.
        /// </summary>
        /// <returns></returns>
        public static DataSet viewAllProducts()
        {
            string sql = $"SELECT * FROM {tableName}";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Remove user by its ID.
        /// </summary>
        /// <param name="productID"></param>
        public static void removeProduct(string productID)
        {
            string sql = $"DELETE FROM {tableName} WHERE P_ItemID = '{productID}'";
            OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Change the product with to corresponding ID's price.
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="NEW_Price"></param>
        public static void updatePrice(string productID, string NEW_Price)
        {
            string sql = $"UPDATE {tableName} SET P_Price = {NEW_Price} WHERE P_ItemID = '{productID}'";
            OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Update all product attribute.
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="name"></param>
        /// <param name="supplierID"></param>
        /// <param name="categoryID"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        public static void updateProduct(string productID, string name, string supplierID, string categoryID, string price, string color, string description, string image)
        {
            string sql = $"UPDATE {tableName} SET P_ProductName = '{name}', P_SupplierID = '{supplierID}', P_CategoryID = '{categoryID}', P_Price = '{price}'," +
                $" P_Color = '{color}', P_Description = '{description}', P_Picture = '{image}' WHERE P_ItemID = {productID}";
            OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Get all the products in the given category ID.
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public static DataSet productsByCategory(string categoryID)
        {
            string sql = $"SELECT * FROM {tableName} WHERE P_CategoryID = '{categoryID}'";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Return all products with a name similar to the given.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataSet productByName(string name)
        {
            string sql = $"SELECT * FROM {tableName} WHERE P_ProductName LIKE '%{name}%'";
            return OleDbHelper.Fill(sql, tableName);
        }
    }
}
