using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleMVVMExample
{
    public class ProductsViewModel : ObservableObject, IPageViewModel
    {
        #region Fields

        private int _productId;
        private bool _buttonEnable;
        private ProductModel _currentProduct;
        private ICommand _getProductCommand;
        private ICommand _saveProductCommand;
        private ICommand _testCommand;
        

        //private PropertyChangedEventHandler prop

        #endregion

        #region Properties/Commands


        public void OptionsChanged(object sender, PropertyChangedEventArgs e)
        {
            _buttonEnable = !_buttonEnable;
        }

        public string Name
        {
            get { return "Products"; }
        }



        public bool ButtonEnable
        {
            get { return _buttonEnable; }
            set
            {
                if (value != _buttonEnable)
                {
                    _buttonEnable = value;
                    OnPropertyChanged("ButtonEnable");                    
                    //OnPropertyChanged(new PropertyChangedEventHandler(OptionsChanged));
                }
            }
        }

        public int ProductId
        {
            get { return _productId; }
            set
            {
                if (value != _productId)
                {
                    _productId = value;                    
                    OnPropertyChanged("ProductId");                    
                    //OnPropertyChanged(new PropertyChangedEventHandler(OptionsChanged));
                }
            }
        }

        public ProductModel CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                if (value != _currentProduct)
                {
                    _currentProduct = value;
                    OnPropertyChanged("CurrentProduct");
                }
            }
        }

        public ICommand GetProductCommand
        {
            get
            {
                if (_getProductCommand == null)
                {
                    _getProductCommand = new RelayCommand(
                        param => GetProduct(),
                        param => ProductId > 0
                    );
                }
                return _getProductCommand;
            }
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if (_saveProductCommand == null)
                {
                    _saveProductCommand = new RelayCommand(
                        param => SaveProduct(),
                        param => (CurrentProduct != null)
                    );
                }
                return _saveProductCommand;
            }
        }



        public ICommand TestCommand {
            get {
                if (_testCommand == null)
                {
                    _testCommand = new RelayCommand(
                            param => SaveProduct(),
                            param => (ProductId != 4)
                        );
                }
                return _testCommand;
            }
        }

        #endregion

        #region Methods

        //Button
        
        private void GetProduct()
        {
            // Usually you'd get your Product from your datastore,
            // but for now we'll just return a new object
            ProductModel p = new ProductModel();    
            p.ProductId = ProductId;
            p.ButtonEnable = _buttonEnable;
            p.ProductName = "Test Product";
            p.UnitPrice = 10;
            CurrentProduct = p;
        }

        private void SaveProduct()
        {
            ProductModel p1 = new ProductModel();
            p1.ProductName = "DL test";
            CurrentProduct = p1;
            // You would implement your Product save here
        }

        #endregion
    }
}
