using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicStoreDAL.Entities
{
    public class Category
    {
        static string tableName = "Category";

        /// <summary>
        /// return the category info base on ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DataSet getID(string category)
        {
            string sql = $"SELECT C_CategoryID FROM {tableName} WHERE C_Category = {category}";
            return OleDbHelper.Fill(sql, tableName);
        }

        public static DataSet getCategory(string ID)
        {
            string sql = $"SELECT C_Category FROM {tableName} WHERE C_CategoryID = {ID}";
            return OleDbHelper.Fill(sql, tableName);
        }
    }
}
