using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MusicStoreDAL.Entities
{
    public class PreferedCategories
    {
        static string tableName = "PreferedCategories";

        /// <summary>
        /// Returns all categories preferred by the given user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static DataSet getUserPreferdCategories(int userID)
        {
            string sql = $"SELECT * FROM {tableName} WHERE PC_UserID = {userID}";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Gets all the users which prefer a certain Category
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public static DataSet getUsersByCategoryID(int categoryID)
        {
            string sql = $"SELECT * FROM {tableName} WHERE PC_CategoryID = {categoryID}";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Return how many users prefer this category ID.
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public static DataSet countCategoriesPreferd(int categoryID)
        {
            string sql = $"SELECT COUNT(*) FROM {tableName} WHERE PC_CategoryID = {categoryID}";
            return OleDbHelper.Fill(sql, tableName);
        }
    }
}
