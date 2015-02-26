using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SimpleMVVMExample
{
    public class ProductModel : ObservableObject
    {
        #region Fields

        private int _productId;
        private string _productName;
        private decimal _unitPrice;
        private bool _buttonEnable;

        #endregion // Fields

        #region Properties
        
        public int ProductId
        {
            get { return _productId; }
            set
            {
                if (value != _productId)
                {
                    _productId = value;
                    OnPropertyChanged("ProductId");
                }
            }
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
                }
            }
        }
        

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (value != _productName)
                {
                    _productName = value;
                    OnPropertyChanged("ProductName");
                }
            }
        }

        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value != _unitPrice)
                {
                    _unitPrice = value;
                    OnPropertyChanged("UnitPrice");
                }
            }
        }

        #endregion // Properties
    }
}
