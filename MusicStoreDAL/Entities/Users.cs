using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace MusicStoreDAL
{
    class Users
    {
        static string tableName = "Users";

        /// <summary>
        /// Add the user to the database
        /// </summary>
        /// <param name="isAdmin"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static int AddUser(bool isAdmin, string firstName, string lastName, string password, string email)
        {
            string sql = $"INSERT INTO {tableName} ( U_isAdmin, U_FirstName, U_LastName, U_Password, U_Email) VALUES ({isAdmin}, '{firstName}', '{lastName}', '{password}', '{email}')";
            return OleDbHelper.InsertWithAutoNumKey(sql);
        }

        /// <summary>
        /// Return all the users
        /// </summary>
        /// <returns></returns>
        public static DataSet ViewAllUser()
        {
            string sql = $"SELECT * FROM {tableName}";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Update the user values in the database
        /// </summary>
        public static void UpdateUser(string UserID, bool NEW_isAdmin, string NEW_firstName, string NEW_lastName, string NEW_password, string NEW_email)
        {
            string sql = $"UPDATE {tableName} SET U_isAdmin = {NEW_isAdmin}, U_FirstName = '{NEW_firstName}', U_LastName = '{NEW_lastName}', U_Password = '{NEW_password}', U_Email = '{NEW_email}' WHERE U_userID = '{UserID}'";
            OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Set the user permissions
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="isAdmin"></param>
        public static void SetAdmin(string UserID, bool isAdmin)
        {
            string sql = $"UPDATE {tableName} SET U_isAdmin = {isAdmin} WHERE U_userID = '{UserID}'";
            OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Update the user password 
        /// </summary>
        public static void SetPassword(string UserID, string password)
        {
            string sql = $"UPDATE {tableName} SET U_Password = {password} WHERE U_userID = '{UserID}'";
            OleDbHelper.DoQuery(sql);
        }

        /// <summary>
        /// Return the a requested user Dataset by its email
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public static DataSet GetUserByEmail(string email)
        {
            string sql = $"SELECT * FROM {tableName} WHERE U_userID = '{email}'";
            return OleDbHelper.Fill(sql, tableName);
        }

        /// <summary>
        /// Check if user with the request Email Exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool doesEmailExist(string email)
        {
            DataSet info = GetUserByEmail(email);
            return info.Tables[0].Rows.Count > 0;
        }
    }
}
