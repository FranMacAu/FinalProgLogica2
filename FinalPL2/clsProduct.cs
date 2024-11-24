using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPL2
{
    internal class clsProduct
    {
        private string FileName = "Product_Product.csv";
        private struct RegProduct
        {
            int ProductID;
            string Name;
            string ProductNumber;
            int MakeFlag;
            int FinishedGoodsFlag;
            string Color;
            int SafetyStockLevel;
            int ReorderPoint;
            int StandardCost;
            int ListPrice;
            string Size;
            string SizeUnitMeasureCode;
            string WeightUnitMeasureCode;
            decimal Weight;
            int DaysToManufacture;
            string ProductLine;
            string Class;
            string Style;
            int ProductSubcategoryID;
            int ProductModelID;
            DateTime SellStartDate;
            DateTime SellEndDate;
            bool? DiscontinuedDate;
            string rowguid;
            DateTime ModifiedDate;
        }

        private RegProduct[] Products = new RegProduct[1000];


    }
}
