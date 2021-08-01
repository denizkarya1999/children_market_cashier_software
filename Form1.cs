using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_market_registry
{
    public partial class Form1 : Form
    {

        private void search_product_button_Click(object sender, EventArgs e)
        {
            // Search the product by name
            this.tableTableAdapter.SearchProduct(this._children_s_business_databaseDataSet1.Table, search_product_name_textBox.Text);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._children_s_business_databaseDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_children_s_business_databaseDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this._children_s_business_databaseDataSet1.Table);

            //Set Average to Default Number 0.00
            average_price_label.Text = "0.00";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();

        }

        private void search_description_button_Click(object sender, EventArgs e)
        {
            // Search the product by description
            this.tableTableAdapter.SearchDescription(this._children_s_business_databaseDataSet1.Table, search_by_description_textBox.Text);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void button_units_Click(object sender, EventArgs e)
        {
            // Order by Units
            this.tableTableAdapter.OrderByUnits(this._children_s_business_databaseDataSet1.Table);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void button_tax_Click(object sender, EventArgs e)
        {
            // Order by Tax
            this.tableTableAdapter.OrderByTaxes(this._children_s_business_databaseDataSet1.Table);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void button_price_Click(object sender, EventArgs e)
        {
            // Order by Price
            this.tableTableAdapter.OrderByPrice(this._children_s_business_databaseDataSet1.Table);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void button_total_price_Click(object sender, EventArgs e)
        {
            // Order By Total Price
            this.tableTableAdapter.OrderByTotalPrice(this._children_s_business_databaseDataSet1.Table);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void average_price_label_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold the average price
            double averagePrice;

            // Get the average price
            averagePrice = (double)this.tableTableAdapter.Sum();

            // Set the average price 
            average_price_label.Text = averagePrice.ToString();
        }

        private void show_all_button_Click(object sender, EventArgs e)
        {
            // Show all items
            this.tableTableAdapter.Fill(this._children_s_business_databaseDataSet1.Table);

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void delete_items_button_Click(object sender, EventArgs e)
        {
            // Delete all the items 
            this.tableTableAdapter.DeleteItems();
            this.tableTableAdapter.Fill(this._children_s_business_databaseDataSet1.Table);


            // and set the calculated price to zero
            total_price_label.Text = "0.00";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void total_price_label_Click(object sender, EventArgs e)
        {
            // Calculation values and their assignment
            int units = Convert.ToInt32(units_textBox.Text);
            double taxes = Double.Parse(taxes_textBox.Text);
            double price = Double.Parse(price_text_box.Text);
            double total_price = 0.00;

            //Calculate the cost
            double tax_cost = (taxes * price) / 100;
            total_price = units * (tax_cost + price);

            // Assign the cost
            total_price_label.Text = total_price.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;
        private void print_button_Click(object sender, EventArgs e)
        {
            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();

            // These codes are for printing
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void banana_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Banana values to database
            product_NameTextBox1.Text = "Banana";
            descriptionTextBox.Text = "Imported from Bahamas";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "1.99";
            total_Price____TextBox.Text = "2.15";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void strawberry_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Strawberry values to database
            product_NameTextBox1.Text = "Strawberry";
            descriptionTextBox.Text = "Imported from California";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "1.50";
            total_Price____TextBox.Text = "1.62";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void kiwi_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Kiwi values to database
            product_NameTextBox1.Text = "Kiwi";
            descriptionTextBox.Text = "Imported from Hawaii";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "2.50";
            total_Price____TextBox.Text = "2.70";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void apple_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Apple values to database
            product_NameTextBox1.Text = "Apple";
            descriptionTextBox.Text = "Imported from Washington";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "1.00";
            total_Price____TextBox.Text = "1.08";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void lettuce_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Lettuce values to database
            product_NameTextBox1.Text = "Lettuce";
            descriptionTextBox.Text = "Imported from New York";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "1.99";
            total_Price____TextBox.Text = "2.15";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void tomato_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Tomato values to database
            product_NameTextBox1.Text = "Tomato";
            descriptionTextBox.Text = "Imported from California";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "1.00";
            total_Price____TextBox.Text = "1.08";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void onion_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Onion values to database
            product_NameTextBox1.Text = "Onion";
            descriptionTextBox.Text = "Imported from Missipi";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "0.50";
            total_Price____TextBox.Text = "0.55";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void carrot_pictureBox_Click(object sender, EventArgs e)
        {
            // Assign Carrot values to database
            product_NameTextBox1.Text = "Carrot";
            descriptionTextBox.Text = "Imported from Texas";
            units_textBox.Text = "1";
            taxes_textBox.Text = "8";
            price_text_box.Text = "0.70";
            total_Price____TextBox.Text = "0.75";

            //Play sound everytime user clicks
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chord.wav");
            simpleSound.Play();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Open About Form when the user clicks this.
            About open_about = new About();
            open_about.Show();
        }
    }
}
