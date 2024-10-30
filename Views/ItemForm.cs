using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFItemDisplay.Models;
using WFItemDisplay.ModelViews;

namespace WFItemDisplay.Views
{
    public partial class ItemForm : Form
    {
        private ItemMV viewModel;
        private string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images/no_image.png");
        private bool isDataGridViewSetup = false;
        public ItemForm()
        {
            InitializeComponent();
            viewModel = new ItemMV();
            LoadData();
        }
        private void LoadData()
        {
            // If the DataGridView is already set up, just reload the data
            if (!isDataGridViewSetup)
            {
                // Set the data source for the DataGridViews
                dataGridViewItems.DataSource = viewModel.Items.ToList();
                dataGridViewCart.DataSource = viewModel.CartItems.ToList();

                // Set up the image column
                if (dataGridViewItems.Columns["ImagePath"] != null)
                {
                    dataGridViewItems.Columns["ImagePath"].Visible = false; // Hide the original ImagePath column
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                    {
                        HeaderText = "Image",
                        Name = "Image",
                        Width = 100, // Set a width for the image column
                        ImageLayout = DataGridViewImageCellLayout.Zoom // Scale the image to fit the cell
                    };
                    dataGridViewItems.Columns.Insert(0, imageColumn);

                    isDataGridViewSetup = true; // Mark the DataGridView as set up
                }
            }

            // Update the items in the DataGridView
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                var item = (ItemModel)row.DataBoundItem;
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, item.ImagePath);

                // Check if the image exists, if not load the default image
                if (File.Exists(fullPath))
                {
                    row.Cells["Image"].Value = Image.FromFile(fullPath);
                }
                else
                {
                    row.Cells["Image"].Value = Image.FromFile(defaultImagePath); // Use the default image if not found
                }
            }

            // Update the cart DataGridView as well
            dataGridViewCart.DataSource = viewModel.CartItems.ToList();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                var selectedItem = (ItemModel)dataGridViewItems.SelectedRows[0].DataBoundItem;
                viewModel.AddToCart(selectedItem);
                LoadData(); // Refresh both grids
            }
            else
            {
                MessageBox.Show("Please select an item to add to the cart.");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            viewModel.Checkout();
            LoadData();
        }
    }
}
