﻿





namespace CKK.Logic.Models
{
  
    public class ShoppingCartItem:Product
    {
        private Product Product;
        private int Quantity;
        public ShoppingCartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public Product GetProduct()
        {
            return Product;
        }
        public void SetProduct(Product product)
        {
            Product = product;
        }
        public decimal GetTotal()
        {

            decimal v = GetPrice();
            return Quantity * v;
        }
    }
}
