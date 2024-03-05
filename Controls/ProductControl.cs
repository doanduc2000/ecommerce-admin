using EcommerceAdmin.Help;
using EcommerceAdmin.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceAdmin.Controls
{
    public partial class ProductControl : UserControl
    {
        private MongoDBHelper mongoDBHelper;
        public ProductControl()
        {
            InitializeComponent();
            mongoDBHelper = new MongoDBHelper();
            LoadCategories();
            LoadProduct();
        }
        public List<Category>GetCategories() {
            var collection = mongoDBHelper.GetCollection<Category>("categories");
            return collection.Find(Builders<Category>.Filter.Empty).ToList();
        }
        public List<Product> GetProducts()
        {
            var collection = mongoDBHelper.GetCollection<Product>("products");
            return collection.Find(Builders<Product>.Filter.Empty).ToList();
        }
        public void LoadCategories()
        {
            var documents = GetCategories();
            cbCategory.DataSource = documents;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
        }
        public void LoadProduct()
        {
            var productDocuments = GetProducts();
            var categoryDocuments = GetCategories();

            var query = from product in productDocuments
                        join category in categoryDocuments on product.CategoryId equals category.Id select new {
                            product,
                            category
                        };
            
            var data =  query.ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("RowNumber", "#");
            dataGridView1.Columns.Add("product._id", "Id");
            dataGridView1.Columns.Add("product.name", "Name");
            dataGridView1.Columns.Add("category.name", "Category Name");
            dataGridView1.Columns.Add("product.price", "Price");
            dataGridView1.Columns.Add("product.numberic", "Numberic");
            dataGridView1.Columns.Add("product.image", "Image Link");
            dataGridView1.Columns.Add("product.desc", "Description");
            for (int i=0;i<data.Count;i++)
            {
                dataGridView1.Rows.Add(
                    i + 1, 
                    data[i].product.Id, 
                    data[i].product.Name, 
                    data[i].category.Name,
                    data[i].product.Price, 
                    data[i].product.Numberic, 
                    data[i].product.Image, 
                    data[i].product.Description
                    );
            }
            DataGridViewColumn columnId = dataGridView1.Columns["product._id"];
            columnId.Visible = false;
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
