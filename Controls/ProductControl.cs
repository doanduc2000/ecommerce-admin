using EcommerceAdmin.Help;
using EcommerceAdmin.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MongoDB.Driver.WriteConcern;

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
        public void ResetInput()
        {
            txtProductName.Text = string.Empty;
            txtPriceProduct.Text = string.Empty;
            txtNumbericProduct.Text = string.Empty;
            txtImageProduct.Text = string.Empty;
            txtDescProduct.Text = string.Empty;
        }
        public List<Category> GetCategories()
        {
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
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            var productDocuments = GetProducts();
            var categoryDocuments = GetCategories();

            var query = from product in productDocuments
                        join category in categoryDocuments on product.CategoryId equals category.Id
                        select new
                        {
                            product,
                            category
                        };

            var data = query.ToList();
            data.Reverse();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("RowNumber", "#");
            dataGridView1.Columns.Add("product._id", "Id");
            dataGridView1.Columns.Add("product.name", "Name");
            dataGridView1.Columns.Add("category.name", "Category Name");
            dataGridView1.Columns.Add("category._id", "CategoryId");
            dataGridView1.Columns.Add("product.price", "Price");
            dataGridView1.Columns.Add("product.numberic", "Numberic");
            dataGridView1.Columns.Add("product.image", "Image Link");
            dataGridView1.Columns.Add("product.desc", "Description");
            for (int i = 0; i < data.Count; i++)
            {
                dataGridView1.Rows.Add(
                    i + 1,
                    data[i].product.Id,
                    data[i].product.Name,
                    data[i].category.Name,
                    data[i].category.Id,
                    data[i].product.Price,
                    data[i].product.Numberic,
                    data[i].product.Image,
                    data[i].product.Description
                    );
            }
            DataGridViewColumn columnId = dataGridView1.Columns["product._id"];
            DataGridViewColumn columnCategoryId = dataGridView1.Columns["category._id"];
            columnId.Visible = false;
            columnCategoryId.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            string productName = txtProductName.Text;

            double price;
            int numberic;
            ObjectId categoryId;

            string image = txtImageProduct.Text;
            string desc = txtDescProduct.Text;

            if (
                !string.IsNullOrEmpty(productName) &&
                !string.IsNullOrEmpty(txtPriceProduct.Text) &&
                !string.IsNullOrEmpty(txtNumbericProduct.Text)
                )
            {
                price = Convert.ToDouble(txtPriceProduct.Text);
                numberic = Convert.ToInt32(txtNumbericProduct.Text);

                ObjectId.TryParse(cbCategory.SelectedValue.ToString(), out categoryId);

                newProduct.Name = productName;
                newProduct.CategoryId = categoryId;
                newProduct.Price = price;
                newProduct.Numberic = numberic;
                newProduct.Image = image;
                newProduct.Description = desc;
                newProduct.CreatedAt = DateTime.Now;
                newProduct.UpdatedAt = DateTime.Now;
                mongoDBHelper.InsertData<Product>("products", newProduct);
                LoadProduct();
                ResetInput();
            }
            else
            {
                MessageBox.Show("Please enter valid input.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedProductName = dataGridView1.SelectedRows[0].Cells["product.name"].Value?.ToString();
                var selectedProductPrice = dataGridView1.SelectedRows[0].Cells["product.price"].Value?.ToString();
                var selectedProductNumberic = dataGridView1.SelectedRows[0].Cells["product.numberic"].Value?.ToString();
                var selectedProductImage = dataGridView1.SelectedRows[0].Cells["product.image"].Value?.ToString();
                var selectedProductDescription = dataGridView1.SelectedRows[0].Cells["product.desc"].Value?.ToString();
                var selectedProductCategoryName = dataGridView1.SelectedRows[0].Cells["category.name"].Value?.ToString();
                var selectedProductCategoryId = dataGridView1.SelectedRows[0].Cells["category._id"].Value?.ToString();

                txtProductName.Text = selectedProductName;
                txtPriceProduct.Text = selectedProductPrice;
                txtNumbericProduct.Text = selectedProductNumberic;
                txtImageProduct.Text = selectedProductImage;
                txtDescProduct.Text = selectedProductDescription;
                cbCategory.Text = selectedProductCategoryName;
                cbCategory.SelectedItem = selectedProductCategoryId;

                btnEditProduct.Enabled = true;
                btnDeleteProduct.Enabled = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "product.price" && e.Value != null)
            {
                decimal price = Convert.ToDecimal(e.Value);
                e.Value = price.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedProductId = dataGridView1.SelectedRows[0].Cells["product._id"].Value;
                string? selectedProductName = dataGridView1.SelectedRows[0].Cells["product.name"].Value.ToString();
                if (selectedProductId != null)
                {
                    var filter = new Dictionary<string, object> { { "_id", ObjectId.Parse(selectedProductId.ToString()) } };

                    mongoDBHelper.DeleteData<Product>("products", filter);
                    LoadProduct();
                    ResetInput();
                    btnEditProduct.Enabled = false;
                    btnDeleteProduct.Enabled = false;
                    MessageBox.Show(selectedProductName + " has been deleted!");
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            ObjectId categoryId;
            Product updateProduct = new();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedProductId = dataGridView1.SelectedRows[0].Cells["product._id"].Value;
                if(selectedProductId != null)
                {
                    ObjectId.TryParse(cbCategory.SelectedValue?.ToString(), out categoryId);
                    updateProduct.Name = txtProductName.Text;
                    updateProduct.Price = Convert.ToDouble(txtPriceProduct.Text);
                    updateProduct.CategoryId = categoryId;
                  
                    updateProduct.Numberic =Convert.ToInt32(txtNumbericProduct.Text);
                    updateProduct.Image = txtImageProduct.Text;
                    updateProduct.Description = txtDescProduct.Text;                  
                    updateProduct.UpdatedAt = DateTime.Now;
                    var filter = Builders<Product>.Filter.Eq("_id", ObjectId.Parse(selectedProductId.ToString()));
                    var update = Builders<Product>.Update
                        .Set("name", updateProduct.Name)
                        .Set("price", updateProduct.Price)
                        .Set("numberic", updateProduct.Numberic)
                        .Set("images", updateProduct.Image)
                        .Set("description", updateProduct.Description)
                        .Set("updatedAt", updateProduct.UpdatedAt)
                        .Set("categories", updateProduct.CategoryId);
                    mongoDBHelper.UpdateData("products", filter, update) ;
                    LoadProduct();
                    ResetInput();
                    btnEditProduct.Enabled = false;
                    btnDeleteProduct.Enabled = false;
                }
            }
        }
    }
}
