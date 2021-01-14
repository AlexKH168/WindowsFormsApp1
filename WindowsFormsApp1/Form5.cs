using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    PictureBox pictureBox = new PictureBox();

            //    //pictureBox1.Location = new Point(120, 120);
            //    pictureBox.Size = new Size(180, 225);
            //    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //    pictureBox.ImageLocation = @"C:\Users\TryDev\Pictures\Product\coca-cola.jpg";

            //    flowLayoutPanel1.Controls.Add(pictureBox);
            //}

            loopPictureBox();
        }



        private void loopPictureBox()
        {
            var formHeight = this.Size.Height;

            int setWidth = 200, setHeight = 300;
            int setX = 12, setY = formHeight - 350;

            foreach (DataRow _data in loadData().Rows)
            {
                customControl control = new customControl();

                control.lblQuantity.Text = _data["Quantity"].ToString();

                control.picImage.ImageLocation = _data["ImagePath"].ToString();
                control.picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                control.picImage.Size = new Size(setWidth, setHeight);

                control.lblName.Text = _data["Name"].ToString();

                control.lblTotalPrice.Text = Convert.ToDecimal(_data["TotalPrice"]).ToString("C2");

                flowLayoutPanel1.Controls.Add(control);

                //PictureBox pictureBox = new PictureBox();

                //pictureBox.Location = new Point(setX, setY);
                //pictureBox.Size = new Size(setWidth, setHeight);
                //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox.ImageLocation = _data["ImagePath"].ToString();

                //this.Controls.Add(pictureBox);

                //Label label = new Label();
                ////label.Location = new Point(setX, setY);
                //label.Text = _data["Name"].ToString();
                //label.Font = new Font("Times New Roman", 11F);

                //this.Controls.Add(label);

                //flowLayoutPanel1.Controls.Add(pictureBox);

                //setX += 200;
                //setY += 20;

                setWidth -= 10;
                setHeight -= 20;
            }
        }

        private DataTable loadData()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=TRYPC\SQLEXPRESS;Database=TestDB;Uid=sa;Pwd=123@456;"))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Name, Quantity, UnitPrice, TotalPrice, ImagePath FROM Product", connection);
                connection.Open();
                da.Fill(dt);
                connection.Close();

                return dt;
            }
        }
    }
}
