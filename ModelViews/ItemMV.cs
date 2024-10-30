
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
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
                
                string pdfPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Receipt.pdf");

                using (PdfWriter writer = new PdfWriter(pdfPath))
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    iText.Layout.Document document = new iText.Layout.Document(pdf);
                    document.Add(new Paragraph("Receipt").SetFontSize(24).SetBold());
                    document.Add(new Paragraph($"Date: {DateTime.Now}").SetFontSize(12));
                    document.Add(new Paragraph("\nItems:\n"));

                    decimal total = 0;
                    foreach (var item in CartItems)
                    {
                        document.Add(new Paragraph($"{item.Name} - ${item.Price:F2}"));
                        total += item.Price;
                    }

                    document.Add(new Paragraph($"\nTotal: ${total:F2}").SetBold());
                    document.Add(new Paragraph("\nPay this to the cashier.").SetFontSize(12).SetBold());

                    document.Close();
                }

                MessageBox.Show($"Receipt generated at {pdfPath}");
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

    }
}
