using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet : kod kısayolu
    
    class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        //Urunun stok adedi
        public int UnitsInStock { get; set; }
        
        
    }
}
