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
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(12, 12);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(776, 181);
            dataGridViewItems.TabIndex = 0;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(12, 234);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(776, 199);
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
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(btnCheckout);
            Controls.Add(btnAddToCart);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewItems);
            Name = "ItemForm";
            Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewItems;
        private DataGridView dataGridViewCart;
        private Button btnAddToCart;
        private Button btnCheckout;
    }
}