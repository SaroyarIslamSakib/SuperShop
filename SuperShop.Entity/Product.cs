using System;
namespace SuperShop.Entity
{
    class Product : ICloneable
    {
        //Properties
        #region Properties
        public int ID { set; get; }
        public string Name { set; get; }
        public int Price { set; get; }
        public int Quantity { set; get; }
        #endregion

        //Method
        #region Clone
        public object Clone()
        {
            Product Product = new Product()
            {
                ID = this.ID,
                Name = this.Name,
                Price = this.Price,
                Quantity = this.Quantity
            };
            return Product;
        }
        #endregion
    }
}
