using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcommerceAdmin.Help;
using EcommerceAdmin.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EcommerceAdmin.Controls
{
    public partial class CategoryControl : UserControl
    {
        private MongoDBHelper mongoDBHelper;
        public CategoryControl()
        {
            InitializeComponent();
            mongoDBHelper = new MongoDBHelper();
            LoadData();
        }

        private void LoadData(string searchName = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var filter = Builders<Category>.Filter.Empty;
            if (!string.IsNullOrEmpty(searchName))
            {
                filter = Builders<Category>.Filter.Regex("name", new BsonRegularExpression(new Regex(searchName, RegexOptions.IgnoreCase)));
            }

            // Thay đổi YourDataClass thành tên lớp bạn đã định nghĩa cho đối tượng trong collection
            var collection = mongoDBHelper.GetCollection<Category>("categories");
            var data = collection.Find(filter).ToList();

            // Gán dữ liệu vào DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("RowNumber", "#");
            dataGridView1.Columns.Add("_id", "Id");

            dataGridView1.Columns.Add("name", "Category Name");

            for (int i = 0; i < data.Count; i++)
            {
                var item = data[i];
                dataGridView1.Rows.Add(i + 1, item.Id, item.Name);
            }
            DataGridViewColumn columnId = dataGridView1.Columns["_id"];
            columnId.Visible = false;
        }
        private void DeleteData()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedDataId = dataGridView1.SelectedRows[0].Cells["_id"].Value;
                if (selectedDataId != null)
                {
                    var filter = new Dictionary<string, object> { { "_id", ObjectId.Parse(selectedDataId.ToString()) } };
                    mongoDBHelper.DeleteData<Category>("categories", filter);

                    // Cập nhật DataGridView
                    LoadData();
                }
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category data = new Category();
            string name = txtCategoryName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                data.Name = name;
                data.CreatedAt = DateTime.Now;
                data.UpdatedAt = DateTime.Now;
                mongoDBHelper.InsertData("categories", data);
                LoadData();
                txtCategoryName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter valid input.");
            }

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedName = dataGridView1.SelectedRows[0].Cells["Name"].Value?.ToString();
                txtCategoryName.Text = selectedName;
                btnDeleteCategory.Enabled = true;
                btnEditCategory.Enabled = true;

            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteData();
            txtCategoryName.Text = string.Empty;
            btnDeleteCategory.Enabled = false;
            btnEditCategory.Enabled = false;
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedDataId = dataGridView1.SelectedRows[0].Cells["_id"].Value;
                string newName = txtCategoryName.Text;
                if (selectedDataId != null)
                {
                    var filter = Builders<Category>.Filter.Eq("_id", ObjectId.Parse(selectedDataId.ToString()));
                    var update = Builders<Category>.Update.Set("name", newName);
                    mongoDBHelper.UpdateData("categories", filter, update);
                    LoadData();
                    txtCategoryName.Text = string.Empty;
                    btnEditCategory.Enabled = false;
                    btnDeleteCategory.Enabled = false;
                }
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchCategory.Text;
            LoadData(searchName);
        }

        private void txtSearchCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Lấy tên cần tìm kiếm từ TextBox
                string searchName = txtSearchCategory.Text;

                // Gọi lại phương thức LoadData với điều kiện tìm kiếm
                LoadData(searchName);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
