using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStoreDAL.Entities;
using System.Data;

namespace MusicStoreBL
{
    class Product
    {
        public string name { get; set; }
        public int supplier { get; set; }
        public int category { get; set; }
        public double price { get; set; }
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
        public Product(string name, string supplier, string category, string price, string color, string description, string image)
        {
            this.name = name;
            this.supplier = int.Parse(supplier);
            this.category = int.Parse(category);
            this.price = Convert.ToDouble(price);
            this.color = color;
            this.description = description;
            this.image = image;

            Products.AddNewProduct(name, int.Parse(supplier), int.Parse(category), Convert.ToDouble(price), color, description, image);
        }

        /// <summary>
        /// Build exciting product
        /// </summary>
        /// <param name="product"></param>
        public Product(DataRow product)
        {
            name = product["P_ProductName"].ToString();
            supplier = int.Parse(product["P_SupplierID"].ToString());
            category = int.Parse(product["P_CategoryID"].ToString());
            price = Convert.ToDouble(product["P_Price"].ToString());
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

    }
} 
