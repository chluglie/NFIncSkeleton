using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public bool ProductAvailability { get; set; }
        public string ProductSupplier { get; set; }
        public string ProductDesc { get; set; }
        public int ProductID { get; set; }
        public DateTime ProductRestockSched { get; set; }
    }
}