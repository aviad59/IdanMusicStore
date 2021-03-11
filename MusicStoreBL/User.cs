using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStoreDAL;
using System.Data;

namespace MusicStoreBL
{
    public class User
    {
        DataTable dataTABLE;
        public int userID { get; set; }
        public bool isAdmin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int id { get; set; }

        /// <summary>
        /// Create new user constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="isAdmin"></param>
        public User(string firstName, string lastName, string password, string email, bool isAdmin)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = CreateFullName();
            this.password = password;
            this.email = email;
            this.isAdmin = isAdmin;

            this.id = Users.AddUser(isAdmin, firstName, lastName, password, email);

            
        }

        /// <summary>
        /// Build an existing user
        /// </summary>
        /// <param name="UserInfo"></param>
        public User(DataRow UserInfo)
        {
            FirstName = UserInfo["U_FirstName"].ToString();
            LastName = UserInfo["U_LastName"].ToString();
            CreateFullName();
            email = UserInfo["U_Email"].ToString();
            password = UserInfo["U_Password"].ToString();
            isAdmin = (bool)UserInfo["U_isAdmin"];

        }

        /// <summary>
        /// Update user information
        /// </summary>
        /// <param name="newFirstName"></param>
        /// <param name="newLastName"></param>
        /// <param name="newEmail"></param>
        /// <param name="newPassword"></param>
        public static void UpdateInfo(string email, string newFirstName, string newLastName, string newPassword)
        {
            Users.UpdateUser(email, newFirstName, newLastName, newPassword);
        }

        /// <summary>
        /// Create full name
        /// </summary>
        /// <returns></returns>
        public string CreateFullName()                                                                                                 
        {
            return FirstName + " " + LastName;
        }
        /// <summary>
        /// Set the admin privileges
        /// </summary>
        /// <param name="email"></param>
        /// <param name="status"></param>
        public void setAdmin(string email, bool status)
        {
            Users.SetAdmin(email, status);
        }

        /// <summary>
        /// Set a new password
        /// </summary>
        /// <param name="newPassword"></param>
        public void setPassword(string newPassword)
        {
            Users.SetPassword(id, newPassword);
        }

        /// <summary>
        /// Return whether an email exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool isExist(string email)
        {
            return Users.doesEmailExist(email);
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <returns></returns>
        public static User createUser(string firstName, string lastName, string password, string email)
        {
            return new User(firstName, lastName, password, email, false);
        }
    }
}
