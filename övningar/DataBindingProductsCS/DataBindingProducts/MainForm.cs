using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataBindingProducts.ProductFiles;

namespace DataBindingProducts
{
    partial class MainForm : Form
    {
        ProductManager productMngr = new ProductManager();

        public MainForm()
        {
            //Windows initialization
            InitializeComponent();

            //Nisse's code
            InitializeDataGridViews();
            BindControls();
            AdjustColumnOrderInDatGridViews();
            
            
            //Run the application some test values

            productMngr.SetTestValues();

        }

        private void InitializeDataGridViews()
        {
            dataGridViewProducts.AutoGenerateColumns = true;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProducers.AutoGenerateColumns = true;
            dataGridViewProducers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BindControls()
        {
            //bind datagridviews to bindingsources
            dataGridViewProducts.DataSource = bindingSourceProducts;
            dataGridViewProducers.DataSource = bindingSourceProducers;

            //bind bindingsources to objects
            bindingSourceProducts.DataSource = productMngr.Products;

            bindingSourceProducers.DataSource = bindingSourceProducts;
            bindingSourceProducers.DataMember = "Producers";

            //bind Textboxes to bindingsources
            Binding bind = new Binding("Text", bindingSourceProducers, "Address.Street");
            txtStreet.DataBindings.Add(bind);

            bind = new Binding("Text", bindingSourceProducers, "Address.City");
            txtCity.DataBindings.Add(bind);

            bind = new Binding("Text", bindingSourceProducers, "Address.ZipCode");
            txtPostNr.DataBindings.Add(bind);
        }

        void AdjustColumnOrderInDatGridViews()
        {
            try
            {
                //dataGridView1.Columns["Name"].Visible = false;
                dataGridViewProducts.Columns["Name"].DisplayIndex = 0;
                dataGridViewProducts.Columns["Count"].DisplayIndex = 1;
                dataGridViewProducts.Columns["Price"].DisplayIndex = 2;
                dataGridViewProducts.Columns["Tax"].DisplayIndex = 3;
                dataGridViewProducts.Columns["Sum"].DisplayIndex = 4;
                dataGridViewProducts.Columns["Sum"].ReadOnly = true;

                dataGridViewProducts.Columns["Tax"].ReadOnly = true;  //calculated by the program
                dataGridViewProducts.Columns["Tax"].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridViewProducts.Columns["Tax"].DefaultCellStyle.BackColor = Color.LightGray;

                dataGridViewProducers.Columns["Name"].DisplayIndex = 0;
                dataGridViewProducers.Columns["Address.Info"].DisplayIndex = 1;
                dataGridViewProducers.Columns["Address.Info"].ReadOnly = true;
                dataGridViewProducers.Columns["Address.Info"].DefaultCellStyle.BackColor = Color.LightGray;
                dataGridViewProducers.Columns["Address.Info"].DefaultCellStyle.ForeColor = Color.Blue;
            }
            catch
            {
                return;
            }
        }

        private void UpdateValues()
        {
            lblSum.Text = String.Format("{0:C}", productMngr.TotalSum);
            txtStreet.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPostNr.DataBindings.Clear();
        }
        private void UpdateGridViewProducers()
        {
            int index = dataGridViewProducers.CurrentRow.Index;
            dataGridViewProducers.UpdateCellValue(index, 1);
        }

        private void dataGridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateValues();
        }

    }
}
