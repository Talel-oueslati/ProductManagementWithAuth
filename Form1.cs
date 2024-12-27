namespace ProductManagements
{
    public partial class Form1 : Form
    {

        private ProductRepository _productRepository;
        private Product _currentProduct;
        public Form1()
        {
            InitializeComponent();

            _productRepository = new ProductRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productRepository.GetAllProducts();
            dgvProducts.DataSource = products; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newProduct = new Product
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                StockQuantity = int.Parse(txtStockQuantity.Text),
                Price = decimal.Parse(txtPrice.Text)
            };

            _productRepository.AddProduct(newProduct);
            LoadProducts();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dvgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    var selectedProduct = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
                    _currentProduct = selectedProduct; 

                    
                    txtName.Text = selectedProduct.Name;
                    txtDescription.Text = selectedProduct.Description;
                    txtStockQuantity.Text = selectedProduct.StockQuantity.ToString();
                    txtPrice.Text = selectedProduct.Price.ToString();
                }
            }
        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (_currentProduct != null)
            {
                _productRepository.DeleteProduct(_currentProduct.Id);
                LoadProducts(); 
            }
            else
            {
                MessageBox.Show("Select a product to delete.");
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (_currentProduct != null)
            {
                _currentProduct.Name = txtName.Text;
                _currentProduct.Description = txtDescription.Text;
                _currentProduct.StockQuantity = int.Parse(txtStockQuantity.Text);
                _currentProduct.Price = decimal.Parse(txtPrice.Text);

                _productRepository.UpdateProduct(_currentProduct);
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Select a product to update.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStockQuantity.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            dgvProducts.ClearSelection();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
