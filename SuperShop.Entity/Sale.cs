using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Entity
{
    class Sale
    {
        //Properties
        #region Properties
        public int ID { set; get; }
        public int ProductID { set; get; }
        public string ProductName { set; get; }
        public int Quantity { set; get; }
        public int TotalPrice { set; get; }
        public DateTime SaleDate { set; get; }
        #endregion

        //Method
        #region Clone
        public object Clone()
        {
            Sale customer = new Sale()
            {
                ID = this.ID,
                ProductID = this.ProductID,
                ProductName = this.ProductName,
                Quantity = this.Quantity,
                TotalPrice = this.TotalPrice,
                SaleDate = this.SaleDate
            };
            return customer;
        }
        #endregion
    }
}
