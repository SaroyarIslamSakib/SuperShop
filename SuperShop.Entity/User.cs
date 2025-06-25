using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Entity
{
    class User
    {
        //Properties
        #region Properties
        public int ID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        #endregion

        //Method
        #region Clone
        public object Clone()
        {
            User customer = new User()
            {
                ID = this.ID,
                Name = this.Name,
                Email = this.Email,
                Password = this.Password
            };
            return customer;
        }
        #endregion
    }
}
