using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProducts2.Models
{
    public class Product
    {
        private int productId = -1;
        private string productName = "n/a";
        private string unitPrice = "$999,999.99";
        private int supplierId = -1;
        private int companyId = -1;

        // These are accessor methods aka Properties
        // They are also called gets and sets or
        // getters and setters

        public int ProductId
        {
            // this gets info from the object
            get
            {
                return this.productId;
            }
            set
            {
                this.productId = value;
            }
            // Typically you can not change your id
            // so there is no setter for Id
        }
        public string ProductName
        {
            // this gets info from the object
            get
            {
                return this.productName;
            }
            // this changes the object's value
            set
            {
                if (value.Length == 0)
                {
                    this.productName = "n/a";
                }
                else
                {
                    this.productName = value;
                }

            }
        }

        public string UnitPrice
        {
            // this gets info from the object
            get
            {
                return this.unitPrice;
            }
            // this changes the object's value
            set
            {
                this.unitPrice = value;
            }
        }

        public int SupplierId
        {
            // this gets info from the object
            get
            {
                return this.supplierId;
            }
            // this changes the object's value
            set
            {
                this.supplierId = value;
            }
        }

        public int CompanyId
        {
            // this gets info from the object
            get
            {
                return this.companyId;
            }
            // this changes the object's value
            set
            {
                this.companyId = value;
            }
        }

        // Start of Constructors

        //This is the empty constructor
        public Product() { }


        public Product(int anId, string aProduct, string aPrice, int aSupplier, int aCompany)
        {
            this.productId = anId;
            this.productName = aProduct;
            this.unitPrice = aPrice;
            this.supplierId = aSupplier;
            this.companyId = aCompany;

        }

        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Product Id: " + this.ProductId + "\n";
            aMessage = aMessage + "Product Name: " + this.ProductName + "\n";
            aMessage = aMessage + "Unit Price: " + this.UnitPrice + "\n";
            aMessage = aMessage + "Supplier Id: " + this.SupplierId + "\n";
            aMessage = aMessage + "Company Id: " + this.CompanyId + "\n";
            return aMessage;
        }
    }
}
