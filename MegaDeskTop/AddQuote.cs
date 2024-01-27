using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDeskTop
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            populateSurfaceMat();
            populayteRushDays();

        }

        private void populateSurfaceMat()
        {
            receivedsurfacmaterial.Items.Add("oak");
            receivedsurfacmaterial.Items.Add("laminate");
            receivedsurfacmaterial.Items.Add("pince");
            receivedsurfacmaterial.Items.Add("rosewood");
            receivedsurfacmaterial.Items.Add("veneer");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //receive width
            string width = receivedwidth.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // receive depth
            string depth = receivedepth.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // numbers of drawers
            string drawers = receiveddrawers.Text;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            // add surface material
            string surfacematerial = receivedsurfacmaterial.Text;

        }

        private void drawerCost_Click(object sender, EventArgs e)
        {
            // add rush days
            string rushdays = receivedrushdays.Text;
        }

        public Desk GatherInputs()
        {
            Desk desk = new Desk();
            // Input validation before converting to numeric types
            if (!string.IsNullOrEmpty(customerName.Text))
            {
                desk.CustomerName = customerName.Text;
            }
            else
            {
                MessageBox.Show("Please enter customer name.");
                // You might want to clear or set a default value for the RushOrder property
                desk.CustomerName = "";
            }

            if (double.TryParse(receivedwidth.Text, out double width))
            {
                if (width >= 24 && width <= 96)
                {
                    // The width is within the valid range
                    
                    desk.Width = width;
                    //MessageBox.Show(receivedwidth, "Width must be between 24 and 96.");
                }
                else
                {
                    receivedwidth.BackColor = Color.Red;
                    // The width is outside the valid range, handle accordingly
                    MessageBox.Show("Width must be between 24 and 96 inches.", "Invalid Width", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You can choose to clear the TextBox or take other actions based on your requirements
                    receivedwidth.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for width between 24 and 96 inches.");
                // You might want to clear or set a default value for the RushOrder property
                receivedwidth.Focus();
                desk.Width = 0;
            }
             

            if (double.TryParse(receivedepth.Text, out double depth))
            {

                if (depth >= 12 && depth <= 48)
                {
                    // The width is within the valid range
                    desk.Depth = depth;
                }
                else
                {
                    receivedepth.BackColor = Color.Red;
                    // The width is outside the valid range, handle accordingly
                    MessageBox.Show("depth must be between 12 and 48 inches.", "Invalid Depth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You can choose to clear the TextBox or take other actions based on your requirements
                    receivedepth.Focus();
                }

            }
            else {
                MessageBox.Show("Please enter a valid number for depth between 12 and 48 inches.");
                // You might want to clear or set a default value for the RushOrder property
                receivedepth.Focus();
                desk.Depth = 0;
            }
                

            desk.SurfaceMaterial = receivedsurfacmaterial.Text;
            desk.RushOrder = receivedrushdays.Text;

            if (int.TryParse(receiveddrawers.Text, out int drawers))
            {
                if (drawers <= 7)
                {
                    // The width is within the valid range
                    desk.DrawersNumber = drawers;
                }
                else
                {

                    // The width is outside the valid range, handle accordingly
                    receiveddrawers.BackColor = Color.Red;
                    MessageBox.Show("Drawers must be between 0 and 7.", "Invalid drawer number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // You can choose to clear the TextBox or take other actions based on your requirements
                    receiveddrawers.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number of drawers maximum allows is 7.");
                // You might want to clear or set a default value for the RushOrder property
                receiveddrawers.Focus();
                desk.DrawersNumber = 0;
            }

                return desk;
        }

        private void CalculateQuote_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd MMMM yyyy");
            Console.WriteLine(formattedDate );
            DeskQuote deskQuote = new DeskQuote(GatherInputs());
            SaveQuoteToFile(deskQuote,formattedDate);
            // Rest of your logic
            drawer.Text = deskQuote.drawertotalCost.ToString();
            total.Text = deskQuote.TotalCost.ToString();
            rushdays.Text = deskQuote.RushDaysCost.ToString();
            surface.Text = deskQuote.SurfaceMaterialCost.ToString();
            baseprice.Text = deskQuote.BasePrice.ToString();
            surfaceareacost.Text = deskQuote.SurfaceAreaCost.ToString();
            date.Text = formattedDate;    
            customer.Text = deskQuote.CustomerName.ToString();
            Console.WriteLine(deskQuote.CustomerName);
           

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void rushdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void receivedrushdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void populayteRushDays()
        {
            receivedrushdays.Items.Add("3");
            receivedrushdays.Items.Add("5");
            receivedrushdays.Items.Add("7");
        }




        private void SaveQuoteToFile(DeskQuote deskQuote,string date)
        {
            try
            {
                // Specify the path to the text file
                string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = "quotes.txt";

                // Combine the root directory and file name to get the full path
                string filePath = Path.Combine(rootDirectory, fileName);

                // Open the file for appending
                using (StreamWriter writer = new StreamWriter("./quotes.txt", true))
                {
                    // Write the quote information to the file
                    writer.WriteLine($"Customer: {deskQuote.CustomerName}");
                    writer.WriteLine($"Quote Date: {date}");
                    writer.WriteLine($"Base Price: {deskQuote.BasePrice}");
                    writer.WriteLine($"Surface Area Cost: {deskQuote.SurfaceAreaCost}");
                    writer.WriteLine($"Surface Material Cost: {deskQuote.SurfaceMaterialCost}");
                    writer.WriteLine($"Drawer Cost: {deskQuote.drawertotalCost}");
                    writer.WriteLine($"Rush Days: {deskQuote.RushDaysCost}");
                    writer.WriteLine($"Quote total: {deskQuote.TotalCost}");
                    
                    // Add more information as needed

                    // Separate quotes with a newline
                    writer.WriteLine(new string('-', 20));
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during file writing
                MessageBox.Show($"Error saving quote to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            DeskQuote deskQuote = new DeskQuote(GatherInputs());
            SaveQuoteToFile(deskQuote, formattedDate);
        }

        private void readtextFile()
        {

        }
    }
}
