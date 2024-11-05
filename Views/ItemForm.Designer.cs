namespace WFItemDisplay.Views
{
    partial class ItemForm
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
            dataGridViewItems = new DataGridView();
            dataGridViewCart = new DataGridView();
            btnAddToCart = new Button();
            btnCheckout = new Button();
            label1 = new Label();
            lblTotal = new Label();
            pictureBoxItem = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblItemID = new Label();
            lblItemName = new Label();
            lblItemPrice = new Label();
            lblItemCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(12, 12);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(620, 181);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.SelectionChanged += dataGridViewItems_SelectionChanged;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(12, 234);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(620, 199);
            dataGridViewCart.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(12, 199);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 29);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(112, 199);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 443);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Total: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(563, 436);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 28);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0.00";
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Location = new Point(649, 12);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(144, 132);
            pictureBoxItem.TabIndex = 6;
            pictureBoxItem.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(812, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Item ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 45);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 8;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(812, 80);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Item Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(812, 112);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 10;
            label5.Text = "Item Category";
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Location = new Point(937, 12);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(50, 20);
            lblItemID.TabIndex = 11;
            lblItemID.Text = "label6";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(937, 45);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(50, 20);
            lblItemName.TabIndex = 12;
            lblItemName.Text = "label6";
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(937, 80);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(50, 20);
            lblItemPrice.TabIndex = 13;
            lblItemPrice.Text = "label6";
            // 
            // lblItemCategory
            // 
            lblItemCategory.AutoSize = true;
            lblItemCategory.Location = new Point(937, 112);
            lblItemCategory.Name = "lblItemCategory";
            lblItemCategory.Size = new Size(50, 20);
            lblItemCategory.TabIndex = 14;
            lblItemCategory.Text = "label6";
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 471);
            Controls.Add(lblItemCategory);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemName);
            Controls.Add(lblItemID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBoxItem);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(btnCheckout);
            Controls.Add(btnAddToCart);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewItems);
            Name = "ItemForm";
            Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewItems;
        private DataGridView dataGridViewCart;
        private Button btnAddToCart;
        private Button btnCheckout;
        private Label label1;
        private Label lblTotal;
        private PictureBox pictureBoxItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblItemID;
        private Label lblItemName;
        private Label lblItemPrice;
        private Label lblItemCategory;
    }
}