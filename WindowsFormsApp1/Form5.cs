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
            var flowHeight = flowLayoutPanel1.Height;

            int controlWidth = 210, controlHeight = 350;

            foreach (DataRow _data in loadData().Rows)
            {
                customControl control = new customControl();

                int controlMarginTop = flowHeight - controlHeight - 10;

                control.lblQuantity.Text = _data["Quantity"].ToString().Replace(", ", "\n");

                control.picImage.ImageLocation = _data["ImagePath"].ToString();
                control.picImage.SizeMode = PictureBoxSizeMode.Zoom;
                control.picImage.Size = new Size(200, 300);

                control.lblName.Text = _data["Name"].ToString();

                control.lblTotalPrice.Text = _data["TotalPrice"].ToString().Replace(", ", "\n");

                control.Size = new Size(controlWidth, controlHeight);
                control.Margin = new Padding(0, controlMarginTop, 0, 0);


                flowLayoutPanel1.Controls.Add(control);

                controlWidth -= 10;
                controlHeight -= 20;
            }
        }

        private DataTable loadData()
        {
            using (SqlConnection connection = new SqlConnection(@"Server=TRYPC\SQLEXPRESS;Database=TestDB;Uid=sa;Pwd=123@456;"))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("GetProduct", connection);
                da.SelectCommand.Parameters.AddWithValue("@startDate", DateTime.Now.Date);
                da.SelectCommand.Parameters.AddWithValue("@endDate", DateTime.Now.Date);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                da.Fill(dt);
                connection.Close();

                return dt;
            }
        }
    }
}
