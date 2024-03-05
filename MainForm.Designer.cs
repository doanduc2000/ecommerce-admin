using EcommerceAdmin.Controls;

namespace EcommerceAdmin
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabReport = new TabPage();
            tabProduct = new TabPage();
            productControl = new ProductControl();
            tabCategory = new TabPage();
            categoryControl = new CategoryControl();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStrip = new ToolStripMenuItem();
            exitToolStrip = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            tabProduct.SuspendLayout();
            tabCategory.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Left;
            tabControl.Controls.Add(tabReport);
            tabControl.Controls.Add(tabProduct);
            tabControl.Controls.Add(tabCategory);
            tabControl.Location = new Point(0, 31);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.RightToLeft = RightToLeft.No;
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(982, 531);
            tabControl.TabIndex = 0;
            // 
            // tabReport
            // 
            tabReport.BackColor = Color.White;
            tabReport.Location = new Point(30, 4);
            tabReport.Name = "tabReport";
            tabReport.Padding = new Padding(3);
            tabReport.Size = new Size(948, 523);
            tabReport.TabIndex = 0;
            tabReport.Text = "Report";
            // 
            // tabProduct
            // 
            tabProduct.BackColor = Color.White;
            tabProduct.Controls.Add(productControl);
            tabProduct.Location = new Point(30, 4);
            tabProduct.Name = "tabProduct";
            tabProduct.Size = new Size(948, 523);
            tabProduct.TabIndex = 2;
            tabProduct.Text = "Products";
            // 
            // productControl
            // 
            productControl.Anchor = AnchorStyles.None;
            productControl.BackColor = Color.White;
            productControl.Font = new Font("Roboto Medium", 9F);
            productControl.Location = new Point(0, 0);
            productControl.Margin = new Padding(4, 3, 4, 3);
            productControl.Name = "productControl";
            productControl.Size = new Size(1130, 527);
            productControl.TabIndex = 0;
            // 
            // tabCategory
            // 
            tabCategory.BackColor = Color.White;
            tabCategory.Controls.Add(categoryControl);
            tabCategory.Location = new Point(30, 4);
            tabCategory.Name = "tabCategory";
            tabCategory.Padding = new Padding(3);
            tabCategory.Size = new Size(948, 523);
            tabCategory.TabIndex = 1;
            tabCategory.Text = "Categories";
            // 
            // categoryControl
            // 
            categoryControl.Anchor = AnchorStyles.None;
            categoryControl.BackColor = Color.White;
            categoryControl.Location = new Point(0, 0);
            categoryControl.Name = "categoryControl";
            categoryControl.Size = new Size(1064, 541);
            categoryControl.TabIndex = 0;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(122, 24);
            logoutToolStripMenuItem.Text = "logout";
            // 
            // menuStrip
            // 
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(228, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStrip, exitToolStrip });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(70, 24);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // logoutToolStrip
            // 
            logoutToolStrip.Name = "logoutToolStrip";
            logoutToolStrip.Size = new Size(224, 26);
            logoutToolStrip.Text = "Logout";
            // 
            // exitToolStrip
            // 
            exitToolStrip.Name = "exitToolStrip";
            exitToolStrip.Size = new Size(224, 26);
            exitToolStrip.Text = "Exit";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 562);
            Controls.Add(menuStrip);
            Controls.Add(tabControl);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabProduct.ResumeLayout(false);
            tabCategory.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabReport;
        private TabPage tabCategory;
      
        private ToolStripMenuItem logoutToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem logoutToolStrip;
        private ToolStripMenuItem exitToolStrip;
        private Controls.CategoryControl categoryControl;
        private TabPage tabProduct;
        private Controls.ProductControl productControl;
    }
}