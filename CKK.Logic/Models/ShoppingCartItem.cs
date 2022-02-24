





namespace CKK.Logic.Models
{
  
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;
        private decimal _price;
        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }
        public decimal GetPrice()
        {
            return _price;
        }
        public void SetPrice(decimal price)
        {
            _price = price;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public void SetQuantity(int quantity)
        {
            _quantity = quantity;
        }
        public Product GetProduct()
        {
            return _product;
        }
        public void SetProduct(Product product)
        {
            _product = product;
        }
        public decimal GetTotal(decimal _price, int _quantity)
        {

            return _quantity * _price;
        }
    }
}
