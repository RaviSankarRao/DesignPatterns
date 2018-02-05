using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    class Admin : User
    {
        public override object Clone()
        {
            return this.MemberwiseClone() as User;
        }

        public override User DeepClone()
        {
            Admin admin = this.MemberwiseClone() as Admin;

            admin.HomeAddress = new Address
            {
                Address1 = this.HomeAddress.Address1,
                City = this.HomeAddress.City,
            };

            admin.BusinessAddress = new Address
            {
                Address1 = this.BusinessAddress.Address1,
                City = this.BusinessAddress.City,
            };

            return admin;
        }
    }
}
