using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Looshand
{

    public partial class Form1 : Form
    {
        int found;
        SqlConnection connection;
        SqlCommand command;
        string sql = null;
        SqlDataReader dataReader;
        IList<Article> articleList = new List<Article>();
        
        public Form1()
        {
            InitializeComponent();
            article_no_textbox.ReadOnly = true;
            article_name_textbox.ReadOnly = true;
            article_location_textbox.ReadOnly = true;
            TL_textbox.ReadOnly = true;
            connection_status();
            this.ActiveControl = barcode;
        }

        public int connection_status()//Checks Connection Status
        {
            string connectionStatusString = "Data Source=****;Initial Catalog=***;User ID=db_username;Password=db_username_password"; //DB connection informations
            connection = new SqlConnection(connectionStatusString);
            try
            {
                connection.Open();
                connection_status_label.Text = "Connected !";
                connection_status_label.ForeColor = Color.Green;
                get_articles_and_fill_list();
                connection.Close();
                return 1;
            }
            catch (Exception ex)
            {
                connection_status_label.Text = "Disconnected !";
                connection_status_label.ForeColor = Color.Red;
                return 0;
            }
        }

        public class Article
        {
            public string ArticleNo;
            public string ArticleName;
            public string ArticleLocation;
            public string ArticleUnitCostwithVAT;
        }

        public void get_articles_and_fill_list() // Gets all product variables from DB only once. It doesn't stay connected while application is being used.So, it runs from the beginning.
        {
            string connectionString = "Data Source=****;Initial Catalog=***;User ID=db_username;Password=db_username_password"; //DB connection informations
            sql = "SQL Comments to get all product information lists from DB";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    articleList.Add(new Article() { ArticleNo = "" + dataReader.GetValue(0), ArticleName = "" + dataReader.GetValue(1), ArticleLocation = "" + dataReader.GetValue(2), ArticleUnitCostwithVAT = "" + dataReader.GetValue(3) });
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection_status() == 1)
            {
                found = 0;
                if (barcode.Text == "")
                {
                    MessageBox.Show("Please fulfill the barcode section!");
                    found = 1;
                }
                else
                {
                    if (connection_status()==1)
                    {
                        for(int i=0; i<articleList.Count; i++)
                        {

                            if (articleList[i].ArticleNo == "" + barcode.Text)//Product information was found.
                            {
                                if (File.Exists("\\\\***\\" + barcode.Text + ".jpg"))// Is barcodeNumber.jpg already exist in the path ?
                                {
                                    pictureBox5.Image = new Bitmap("\\\\*******\\" + barcode.Text + ".jpg");  // When barcode was scanned, image will be found directory with name which is barcodeNumber.jpg
                                    article_no_textbox.Text = barcode.Text;
                                    article_name_textbox.Text = articleList[i].ArticleName;
                                    article_location_textbox.Text = articleList[i].ArticleLocation;
                                    TL_textbox.Text = articleList[i].ArticleUnitCostwithVAT + "  TL";

                                    article_no_textbox.BackColor = Color.LightGray;
                                    article_name_textbox.BackColor = Color.LightGray;
                                    article_location_textbox.BackColor = Color.LightGray;
                                    TL_textbox.BackColor = Color.LightGray;

                                    barcode.Text = String.Empty;
                                    found = 1;
                                    break;
                                }
                                else // Product information was found but Image could not be found.
                                {
                                    found = 1;
                                    pictureBox5.Image = new Bitmap("\\\\**********.jpg"); // Empty Image will be shown if application cannot find product image.
                                    MessageBox.Show("Product image could not be found. Please contact your administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);// Warning message "Product image could not be found"
                                    article_no_textbox.Text = barcode.Text;
                                    article_name_textbox.Text = articleList[i].ArticleName;
                                    article_location_textbox.Text = articleList[i].ArticleLocation;
                                    TL_textbox.Text = articleList[i].ArticleUnitCostwithVAT + "  TL";
                                    article_location_textbox.BackColor = Color.LightGray;
                                    article_no_textbox.BackColor = Color.LightGray;
                                    article_name_textbox.BackColor = Color.LightGray;
                                    article_location_textbox.BackColor = Color.LightGray;
                                    TL_textbox.BackColor = Color.LightGray;
                                    barcode.Text = String.Empty;
                                    found = 1;
                                    break;
                                }
                            }
                        }

                    }
                    else//Product and its image could not be found.
                    {
                        found = 1;
                        article_location_textbox.Text = String.Empty;
                        article_name_textbox.Text = String.Empty;
                        article_no_textbox.Text = String.Empty;
                        connection_status_label.Text = "Disconnected !";
                        connection_status_label.ForeColor = Color.Red;
                        pictureBox5.Image = new Bitmap("\\\\******.jpg");
                        MessageBox.Show("Product cannot be found. Please contact your administrator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                if (found == 0)
                {
                    MessageBox.Show("Product cannot be found. Please check barcode number !");
                }
            }
            else
            {
                MessageBox.Show("Check your network connection. Contact your administrator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
