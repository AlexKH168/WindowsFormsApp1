
namespace WindowsFormsApp1
{
    partial class customControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPrice, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.picImage, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 350);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantity.Location = new System.Drawing.Point(4, 0);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(192, 18);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "label1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(0, 312);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label2";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Location = new System.Drawing.Point(0, 332);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(200, 18);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "label3";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 18);
            this.picImage.Margin = new System.Windows.Forms.Padding(0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(200, 294);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // customControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "customControl";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Size = new System.Drawing.Size(210, 350);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblQuantity;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblTotalPrice;
        public System.Windows.Forms.PictureBox picImage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
