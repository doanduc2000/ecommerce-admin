namespace EcommerceAdmin.Controls
{
    partial class ProductControl
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
            lbProductName = new Label();
            txtProductName = new TextBox();
            tbPriceProduct = new Label();
            txtPriceProduct = new TextBox();
            lbNumbericProduct = new Label();
            txtNumbericProduct = new TextBox();
            lbImageProduct = new Label();
            txtImageProduct = new TextBox();
            lbDesc = new Label();
            txtDescProduct = new TextBox();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            lbCategory = new Label();
            cbCategory = new ComboBox();
            btnSearchProduct = new Button();
            dataGridView1 = new DataGridView();
            txtSearchCategory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(17, 23);
            lbProductName.Margin = new Padding(4, 0, 4, 0);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(48, 18);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Name";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(17, 44);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(380, 26);
            txtProductName.TabIndex = 1;
            // 
            // tbPriceProduct
            // 
            tbPriceProduct.AutoSize = true;
            tbPriceProduct.Location = new Point(17, 89);
            tbPriceProduct.Margin = new Padding(4, 0, 4, 0);
            tbPriceProduct.Name = "tbPriceProduct";
            tbPriceProduct.Size = new Size(43, 18);
            tbPriceProduct.TabIndex = 0;
            tbPriceProduct.Text = "Price";
            // 
            // txtPriceProduct
            // 
            txtPriceProduct.BorderStyle = BorderStyle.FixedSingle;
            txtPriceProduct.Location = new Point(17, 110);
            txtPriceProduct.Margin = new Padding(4, 3, 4, 3);
            txtPriceProduct.Name = "txtPriceProduct";
            txtPriceProduct.Size = new Size(180, 26);
            txtPriceProduct.TabIndex = 1;
            // 
            // lbNumbericProduct
            // 
            lbNumbericProduct.AutoSize = true;
            lbNumbericProduct.Location = new Point(217, 89);
            lbNumbericProduct.Margin = new Padding(4, 0, 4, 0);
            lbNumbericProduct.Name = "lbNumbericProduct";
            lbNumbericProduct.Size = new Size(73, 18);
            lbNumbericProduct.TabIndex = 0;
            lbNumbericProduct.Text = "Numberic";
            // 
            // txtNumbericProduct
            // 
            txtNumbericProduct.BorderStyle = BorderStyle.FixedSingle;
            txtNumbericProduct.Location = new Point(217, 110);
            txtNumbericProduct.Margin = new Padding(4, 3, 4, 3);
            txtNumbericProduct.Name = "txtNumbericProduct";
            txtNumbericProduct.Size = new Size(180, 26);
            txtNumbericProduct.TabIndex = 1;
            // 
            // lbImageProduct
            // 
            lbImageProduct.AutoSize = true;
            lbImageProduct.Location = new Point(17, 225);
            lbImageProduct.Margin = new Padding(4, 0, 4, 0);
            lbImageProduct.Name = "lbImageProduct";
            lbImageProduct.Size = new Size(82, 18);
            lbImageProduct.TabIndex = 0;
            lbImageProduct.Text = "Image Link";
            // 
            // txtImageProduct
            // 
            txtImageProduct.BorderStyle = BorderStyle.FixedSingle;
            txtImageProduct.Location = new Point(17, 246);
            txtImageProduct.Margin = new Padding(4, 3, 4, 3);
            txtImageProduct.Name = "txtImageProduct";
            txtImageProduct.Size = new Size(380, 26);
            txtImageProduct.TabIndex = 1;
            // 
            // lbDesc
            // 
            lbDesc.AutoSize = true;
            lbDesc.Location = new Point(17, 292);
            lbDesc.Margin = new Padding(4, 0, 4, 0);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(85, 18);
            lbDesc.TabIndex = 0;
            lbDesc.Text = "Description";
            // 
            // txtDescProduct
            // 
            txtDescProduct.BorderStyle = BorderStyle.FixedSingle;
            txtDescProduct.Location = new Point(17, 313);
            txtDescProduct.Margin = new Padding(4, 3, 4, 3);
            txtDescProduct.Multiline = true;
            txtDescProduct.Name = "txtDescProduct";
            txtDescProduct.Size = new Size(380, 112);
            txtDescProduct.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.Enabled = false;
            btnDeleteProduct.ForeColor = Color.Red;
            btnDeleteProduct.Location = new Point(212, 475);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(185, 29);
            btnDeleteProduct.TabIndex = 12;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Cursor = Cursors.Hand;
            btnEditProduct.Enabled = false;
            btnEditProduct.ImageAlign = ContentAlignment.BottomLeft;
            btnEditProduct.Location = new Point(17, 475);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(185, 29);
            btnEditProduct.TabIndex = 13;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.Location = new Point(17, 440);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(380, 29);
            btnAddProduct.TabIndex = 14;
            btnAddProduct.Text = "Add ";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(17, 156);
            lbCategory.Margin = new Padding(4, 0, 4, 0);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(69, 18);
            lbCategory.TabIndex = 0;
            lbCategory.Text = "Category";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(17, 177);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(380, 26);
            cbCategory.TabIndex = 15;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Cursor = Cursors.Hand;
            btnSearchProduct.ImageAlign = ContentAlignment.BottomLeft;
            btnSearchProduct.Location = new Point(833, 21);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(106, 28);
            btnSearchProduct.TabIndex = 18;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 446);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.BackColor = Color.White;
            txtSearchCategory.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCategory.Cursor = Cursors.IBeam;
            txtSearchCategory.Location = new Point(428, 21);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.Size = new Size(394, 26);
            txtSearchCategory.TabIndex = 16;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSearchProduct);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchCategory);
            Controls.Add(cbCategory);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(txtDescProduct);
            Controls.Add(lbDesc);
            Controls.Add(lbCategory);
            Controls.Add(txtImageProduct);
            Controls.Add(lbImageProduct);
            Controls.Add(txtNumbericProduct);
            Controls.Add(lbNumbericProduct);
            Controls.Add(txtPriceProduct);
            Controls.Add(tbPriceProduct);
            Controls.Add(txtProductName);
            Controls.Add(lbProductName);
            Font = new Font("Roboto Medium", 9F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductControl";
            Size = new Size(1130, 546);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lbProductName;
        private TextBox txtProductName;
        private Label tbPriceProduct;
        private TextBox txtPriceProduct;
        private Label lbNumbericProduct;
        private TextBox txtNumbericProduct;
        private Label lbImageProduct;
        private TextBox txtImageProduct;
        private Label lbDesc;
        private TextBox txtDescProduct;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private Label lbCategory;
        private ComboBox cbCategory;
        private Button btnSearchProduct;
        private DataGridView dataGridView1;
        private TextBox txtSearchCategory;
    }
}
