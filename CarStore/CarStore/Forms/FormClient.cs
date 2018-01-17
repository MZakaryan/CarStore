using CarStore.Controllers;
using CarStore.Helpers;
using CarStoreInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStore.Forms
{
    public partial class FormClient : Form
    {
        private string _filePath = @"searchIcon.png";
        private BrandController _brandController;
        private ModelController _modelController;
        private CarController _carController;

        public FormClient()
        {
            InitializeComponent();
            _brandController = new BrandController();
            _modelController = new ModelController();
            _carController = new CarController();
            btnBuy.Enabled = false;
            Load += FormClient_Load;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            btnSearch.Image = Image.FromFile(_filePath);
            comboBoxBrands.DataSource = new BindingSource(_brandController.Get(), null);
            comboBoxBrands.DisplayMember = "Name";
        }

        private void comboBoxBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            int brandId = (comboBoxBrands.SelectedItem as BrandInfo).ID;
            //_modelController.Get().Select(c => c).Where(u => u.BrandId == brandId)
            comboBoxModels.DataSource = new BindingSource(from model
                                                          in _modelController.Get()
                                                          where model.BrandId == brandId
                                                          select model,
                                                                        null);
            comboBoxModels.DisplayMember = "Name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            int modelId = (comboBoxModels.SelectedItem as ModelInfo).ID;
            var carList = _carController.Get(modelId);

            dgvCars.DataSource = carList;

            btnBuy.Enabled = true ? carList.Count != 0 : false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var car = (CarListViewModel)dgvCars.CurrentRow.DataBoundItem;
            car.IsDeleted = true;
            if (_carController.Update(Maper.MapingCarViewModel(car)))
            {
                MessageBox.Show("Successfully completed.");
            }
            else
            {
                MessageBox.Show("Is not completed please repeat.");
            }
            Search();
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
