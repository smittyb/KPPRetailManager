﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPPDesktopUI
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;

        public BindingList<string>  Products
        {
            get { return _products; }
            set 
            { 
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private string _itemQuantity;

        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set
            { 
                _itemQuantity = value;
                NotifyOfPropertyChange(() => Products);
            }
        }


        public string SubTotal
        {
            get
            { 
                // TODO - Replace with Calculation
                return "$0.00"; 
            }
        }

        public string Tax
        {
            get
            {
                // TODO - Replace with Calculation
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO - Replace with Calculation
                return "$0.00";
            }
        }




        public bool CanAddToCart
        {
            get
            {
                bool output = false;

               // Make sure something is selected
               // Make sure there is an item quantity

                return output;
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


        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                // Make sure something in cart

                return output;
            }
        }

        public void CheckOut()
        {

        }

    }
}
