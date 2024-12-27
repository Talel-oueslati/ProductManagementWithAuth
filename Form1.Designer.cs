namespace ProductManagements
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtName = new TextBox();
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            label3 = new Label();
            txtStockQuantity = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtPrice = new TextBox();
            btnDeleteProduct = new Button();
            BtnCancel = new Button();
            btnUpdateProduct = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 208);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductName :";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 205);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtProductName_TextChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(115, 469);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(104, 29);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Save";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += button1_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Location = new Point(488, 139);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 30;
            dgvProducts.Size = new Size(677, 470);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dvgProducts_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 252);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 0;
            label3.Text = "StockQuantity :";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(186, 249);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(259, 27);
            txtStockQuantity.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 299);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Description     :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(186, 296);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(259, 71);
            txtDescription.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 391);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 0;
            label5.Text = "Price                :";
            label5.Click += label5_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(186, 388);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(259, 27);
            txtPrice.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(225, 469);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(105, 29);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(336, 580);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(109, 29);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(336, 469);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(109, 29);
            btnUpdateProduct.TabIndex = 5;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(447, 22);
            label2.Name = "label2";
            label2.Size = new Size(304, 41);
            label2.TabIndex = 6;
            label2.Text = "Product Managments";
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 633);
            Controls.Add(label2);
            Controls.Add(btnUpdateProduct);
            Controls.Add(dgvProducts);
            Controls.Add(BtnCancel);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(txtStockQuantity);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnAddProduct;
        private DataGridView dgvProducts;
        private Label label3;
        private TextBox txtStockQuantity;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private TextBox txtPrice;
        private Button btnDeleteProduct;
        private Button BtnCancel;
        private Button btnUpdateProduct;
        private Label label2;
    }
}
