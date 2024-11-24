using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FinalPL2
{
    internal class clsSalesHeader
    {
        private struct RegSaleHeader
        {
            int SalesOrderID;
            int RevisionNumber;
            DateTime OrderDate;
            DateTime DueDate;
            DateTime ShipDate;
            int Status;
            int OnlineOrderFlag;
            string SalesOrderNumber;
            string PurchaseOrderNumber;
            string AccountNumber;
            int CustomerID;
            int SalesPersonID;
            int TerritoryID;
            int BillToAddressID;
            int ShipToAddressID;
            int ShipMethodID;
            int CreditCardID;
            string CreditCardApprovalCode;
            int CurrencyRateID;
            decimal SubTotal;
            decimal TaxAmt;
            decimal Freight;
            decimal TotalDue;
            string Comment;
            string rowguid;
            DateTime ModifiedDate;
        }

        private RegSaleHeader[] SalesHeaders = new RegSaleHeader[35000];

    }
}
