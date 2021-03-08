using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicStoreDAL.Entities
{
    public class OrderItems
    {
        static string tableName = "OrderItems";

        /// <summary>
        /// return all the item in the given order ID
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static DataSet getAllItemsByOrderID(string OrderID)
        {
            string sql = $"SELECT * FROM {tableName} WHERE OI_OrderID = {OrderID}";
            return OleDbHelper.Fill(sql, tableName);
        }
    }
}
