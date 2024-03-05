namespace EcommerceAdmin.Controls
{
    partial class CategoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            dataGridView1 = new DataGridView();
            txtSearchCategory = new TextBox();
            txtCategoryName = new TextBox();
            label1 = new Label();
            btnSearchCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Cursor = Cursors.Hand;
            btnDeleteCategory.Enabled = false;
            btnDeleteCategory.ForeColor = Color.Red;
            btnDeleteCategory.Location = new Point(209, 132);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(185, 29);
            btnDeleteCategory.TabIndex = 8;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Cursor = Cursors.Hand;
            btnEditCategory.Enabled = false;
            btnEditCategory.ImageAlign = ContentAlignment.BottomLeft;
            btnEditCategory.Location = new Point(19, 132);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(185, 29);
            btnEditCategory.TabIndex = 10;
            btnEditCategory.Text = "Edit";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Cursor = Cursors.Hand;
            btnAddCategory.Location = new Point(19, 97);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(375, 29);
            btnAddCategory.TabIndex = 11;
            btnAddCategory.Text = "Add ";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(417, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 454);
            dataGridView1.TabIndex = 7;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.BackColor = Color.White;
            txtSearchCategory.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCategory.Cursor = Cursors.IBeam;
            txtSearchCategory.Location = new Point(417, 16);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.Size = new Size(402, 27);
            txtSearchCategory.TabIndex = 5;
            txtSearchCategory.KeyDown += txtSearchCategory_KeyDown;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.White;
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Cursor = Cursors.IBeam;
            txtCategoryName.Location = new Point(19, 53);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(375, 27);
            txtCategoryName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Medium", 9F);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 4;
            label1.Text = "Category Name ";
            // 
            // btnSearchCategory
            // 
            btnSearchCategory.Cursor = Cursors.Hand;
            btnSearchCategory.ImageAlign = ContentAlignment.BottomLeft;
            btnSearchCategory.Location = new Point(830, 15);
            btnSearchCategory.Name = "btnSearchCategory";
            btnSearchCategory.Size = new Size(106, 28);
            btnSearchCategory.TabIndex = 19;
            btnSearchCategory.Text = "Search";
            btnSearchCategory.UseVisualStyleBackColor = true;
            // 
            // CategoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSearchCategory);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnEditCategory);
            Controls.Add(btnAddCategory);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchCategory);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Name = "CategoryControl";
            Size = new Size(1064, 541);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private DataGridView dataGridView1;
        private TextBox txtSearchCategory;
        private TextBox txtCategoryName;
        private Label label1;
        private Button btnSearchCategory;
    }
}
