using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicStoreDAL.Entities
{
    public class Orders
    {
        static string tableName = "Orders";

        /// <summary>
        /// Return all orders.
        /// </summary>
        /// <returns></returns>
        public static DataSet getAllOrders()
        {
            string sql = $"SELECT * FROM {tableName}";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Return all orders by this user email.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataSet searchByID(string email)
        {
            string sql = $"SELECT {tableName}.O_OrderID, Users.U_FirstName, Users.U_LastName, {tableName}.O_OrderDate, {tableName}.O_ShippingAddress " +
                $"FROM {tableName} INNER JOIN Users ON {tableName}.O_CustomerID={email}";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Add new order.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="orderID"></param>
        /// <param name="time"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static int addOrder(string userID, string orderID, DateTime time, string address)
        {
            string sql = $"INSERT INTO {tableName} (O_OrderID, O_CustomerID, O_OrderDate, O_ShippingAddress) VALUES ('{userID}', '{orderID}', '{time.ToString()}', '{address}')";
            return OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Remove order by ID.
        /// </summary>
        /// <param name="orderID"></param>
        public static void removeOrder(string orderID)
        {
            string sql = $"DELETE FROM {tableName} WHERE O_OrderID = '{orderID}'";
            OleDbHelper.DoQuery(sql);
            sql = $"DELETE FROM OrderItems WHERE OI_OrderID = '{orderID}'";
            OleDbHelper.DoQuery(sql);
        }
    }
}
