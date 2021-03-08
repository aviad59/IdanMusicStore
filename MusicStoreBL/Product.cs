using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStoreDAL.Entities;
using System.Data;

namespace MusicStoreBL
{
    public class Product
    {
        public string name { get; set; }
        public int supplier { get; set; }
        public int category { get; set; }
        public decimal price { get; set; }
        public string color { get; set; }
        public string description { get; set; }
        public string image { get; set; }

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="supplier"></param>
        /// <param name="category"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        public Product(string name, int supplier, int category, decimal price, string color, string description, string image)
        {
            this.name = name;
            this.supplier = supplier;
            this.category = category;
            this.price = price;
            this.color = color;
            this.description = description;
            this.image = image;

            Products.AddNewProduct(name, supplier, category, price, color, description, image);
        }

        /// <summary>
        /// Build exciting product
        /// </summary>
        /// <param name="product"></param>
        public Product(DataRow product)
        {
            name = product["P_ProductName"].ToString();
            supplier = (int)product["P_SupplierID"];
            category = (int)product["P_CategoryID"];
            price = (decimal)product["P_Price"];
            color = product["P_Color"].ToString();
            description = product["P_Description"].ToString();
            image = product["P_Picture"].ToString();
        }

        /// <summary>
        /// Update product properties
        /// </summary>
        /// <param name="name"></param>
        /// <param name="supplierID"></param>
        /// <param name="categoryID"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="image"></param>
        public void updateProduct(string name, string supplierID, string categoryID, string price, string color, string description, string image)
        {
            Products.updateProduct(name, supplierID, categoryID, price, color, description, image);
        }

        /// <summary>
        /// set new price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public void updatePrice(string name, double price)
        {
            Products.updatePrice(name, price.ToString());
        }

        /// <summary>
        /// Return all products
        /// </summary>
        /// <returns></returns>
        public static DataSet getAll()
        {
            return Products.viewAllProducts();
        }

        /// <summary>
        /// Return all products in a list
        /// </summary>
        /// <returns></returns>
        public static List<Product> getListAll()
        {
            DataSet ds = getAll();
            List<Product> li = new List<Product>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                li.Add(new Product(item));
            }
            return li;
        }
    }
} 
