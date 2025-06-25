using System;
namespace SuperShop.Entity
{
    class Customer : ICloneable
    {
        //Properties
        #region Properties
        public int ID { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        #endregion

        //Method
        #region Clone
        public object Clone()
        {
            Customer customer = new Customer()
            {
                ID = this.ID,
                Name = this.Name,
                Phone = this.Phone,
                Address = this.Address
            };
            return customer;
        }
        #endregion
    }
}
