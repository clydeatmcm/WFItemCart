
using iText.Commons.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFItemDisplay.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WFItemDisplay.ModelViews
{
    internal class ItemMV
    {
        private string connectionString;
        private List<ItemModel> cartItems = new List<ItemModel>();
        public List<ItemModel> Items { get; set; }
        public List<ItemModel> CartItems { get; set; }

        public ItemMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Items = new List<ItemModel>();
            CartItems = new List<ItemModel>();
            LoadItems();
        }

        public void LoadItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemId, Name, ImagePath, Price, Category FROM Items";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ItemModel item = new ItemModel
                    {
                        Id = (int)reader["ItemId"],
                        Name = (string)reader["Name"],
                        ImagePath = (string)reader["ImagePath"],
                        Price = (decimal)reader["Price"],
                        Category = (string)reader["Category"]
                    };
                    Items.Add(item);
                }
            }
        }

        public void AddToCart(ItemModel item)
        {
            // Check if the item is already in the cart
            if (!CartItems.Any(i => i.Id == item.Id))
            {
                CartItems.Add(item);
            }
            else
            {
                MessageBox.Show("Item already in cart.");
            }
        }

        public void Checkout()
        {
            try
            {
                // Implement checkout logic
                if (CartItems.Count == 0)
                {
                    MessageBox.Show("Your cart is empty.");
                    return;
                }

                MessageBox.Show($"Receipt generated!");
                CartItems.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearCart()
        {
            cartItems.Clear();
            MessageBox.Show("Cart has been cleared.");
        }

        public decimal CalculateColumnTotal(DataGridView dataGridView, string columnName)
        {
            decimal total = 0;

            // Iterate through all rows of the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Skip the new row if it exists (in case the DataGridView is in edit mode)
                if (row.IsNewRow)
                    continue;

                // Get the value of the specified column from the current row
                var cellValue = row.Cells[columnName].Value;

                // Check if the cell value is not null and can be parsed to a decimal
                if (cellValue != null)
                {
                    decimal value;
                    if (Decimal.TryParse(cellValue.ToString(), out value))
                    {
                        total += value; // Add the value to the total if it's a valid number
                    }
                }
            }

            return total; // Return the total sum
        }

        public void LoadImageIntoPictureBox(PictureBox pictureBox, string imagePath)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            // Check if the image path exists and is valid
            if (File.Exists(imagePath))
            {
                try
                {
                    // Load the image from the specified path and set it to the PictureBox
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur during the loading process
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            else
            {
                // If the image does not exist, show a message or use a default image
                MessageBox.Show("Image not found at: " + imagePath);

                // Optionally, load a default image
                //pictureBox.Image = Properties.Resources.DefaultImage; // Use a default image if available
            }
        }

    }
}
