using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  [ProductID], 
                  [ProductName], 
                  [SupplierID], 
                  [CategoryID], 
                  [QuantityPerUnit], 
                  [UnitPrice], 
                  [UnitsInStock], 
                  [UnitsOnOrder], 
                  [ReorderLevel], 
                  [Discontinued]
 * */
namespace Vektorel.DbHelpers.Models
{
  class Product
  {
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int SupplierID { get; set; }
    public int CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public int UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
    public int UnitsOnOrder { get; set; }
    public int ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public Product(int productID,string productName,int supplierID,int categoryID,string quantityPerUnit,int unitPrice,int unitsInStock,int unitsOnOrder,int reorderLevel,bool discontinued)
  
    {
      ProductID = productID;
      ProductName = productName;
      SupplierID = supplierID;
      CategoryID = categoryID;
      QuantityPerUnit = quantityPerUnit;
      UnitPrice = unitPrice;
      UnitsInStock = unitsInStock;
      UnitsOnOrder = unitsOnOrder;
      ReorderLevel = reorderLevel;
      Discontinued = discontinued;
    }
    public Product()
    {

    }
  }
}
