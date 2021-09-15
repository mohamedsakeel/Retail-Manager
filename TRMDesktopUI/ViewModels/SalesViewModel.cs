using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;

        public BindingList<string> Products
        {
            get { return _products; }
            set 
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        //cart list


        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            get
            {
                //TODO - Replace with calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                //TODO - Replace with calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                //TODO - Replace with calculation
                return "$0.00";
            }
        }


        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                // make sure something is sellected
                //make sure there is an item quantity


                return output;
            }
        }

        public void AddToCart()
        {

        }

        //Remove from cart

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // make sure something is sellected

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        //checkout
        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // make sure something in the cart

                return output;
            }
        }

        public void CheckOut()
        {

        }

    }
}
