using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPL2
{
    internal class clsSalesDetail
    {
        private string FileName = "Sales_SalesOrderDetail.csv";

        private struct RegSaleDetail
        {
            int SalesOrderID;
            int SalesOrderDetailID;
            string CarrierTrackingNumber;
            int OrderQty;
            int ProductID;
            int SpecialOfferID;
            decimal UnitPrice;
            decimal UnitPriceDiscount;
            decimal LineTotal;
            string rowguid;
            DateTime ModifiedDate;
        }

        private RegSaleDetail[] SalesDetails = new RegSaleDetail[15000];


    }
}
