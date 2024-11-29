using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPL2
{
    internal class clsSalesHeader
    {
        string NombreArchivo = "Sales_SalesOrderHeader.csv";

        public struct RegSaleHeader
        {
            public int SalesOrderID;   // PK
            public int RevisionNumber;
            public DateTime OrderDate;
            public DateTime DueDate;
            public DateTime ShipDate;
            public int Status;
            public int OnlineOrderFlag;
            public string SalesOrderNumber;
            public string PurchaseOrderNumber;
            public string AccountNumber;
            public int CustomerID;
            public int SalesPersonID;
            public int TerritoryID;
            public int BillToAddressID;
            public int ShipToAddressID;
            public int ShipMethodID;
            public int CreditCardID;
            public string CreditCardApprovalCode;
            public int CurrencyRateID;
            public decimal SubTotal;
            public decimal TaxAmt;
            public decimal Freight;
            public decimal TotalDue;
            public string Comment;
            public string rowguid;
            public DateTime ModifiedDate;

        }

        private RegSaleHeader[] SalesHeaders = new RegSaleHeader[35000];

        public void ReporteVentasEntreFechas(DateTime mindate, DateTime maxdate)
        {
            string datoleido = "";
            List<RegSaleHeader> headers = new List<RegSaleHeader>();
            StreamReader AD = new StreamReader(NombreArchivo);
            StreamWriter RD = new StreamWriter("Reporte_Ventas_Entre_Fechas.csv", false, Encoding.UTF8);

            datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();

            RD.WriteLine("Reporte de ventas por periodo");
            RD.WriteLine("Ventas entre " + mindate.ToString("d") + " y " + maxdate.ToString("d"));      //.toString("d") fecha corta
            RD.WriteLine("");
            RD.WriteLine("SalesOrderNumber;AccountNumber;CustomerId;OrderDate ");
            while (datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                DateTime fecha = Convert.ToDateTime(registro[2]);

                if ( fecha >= mindate && fecha <= maxdate)
                {
                    RegSaleHeader X = new RegSaleHeader();
                    X.SalesOrderNumber = registro[7];
                    X.AccountNumber = registro[9];
                    X.OrderDate = Convert.ToDateTime(registro[2]);
                    X.CustomerID = Convert.ToInt32(registro[10]);


                    headers.Add(X);
                }
                datoleido = AD.ReadLine();
            }

            foreach (RegSaleHeader X in headers)
            {
                RD.Write(X.SalesOrderNumber);
                RD.Write(";");
                RD.Write(X.AccountNumber);
                RD.Write(";");
                RD.Write(X.CustomerID);
                RD.Write(";");
                RD.WriteLine(X.OrderDate);
            }

            AD.Close(); 
            AD.Dispose();
            RD.Close();
            RD.Dispose();

            MessageBox.Show("Reporte generado");
        }

        public int ObtenerCustomerID(int salesorderid)
        {
            int resultado = 0;
            try
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                string datoleido = AD.ReadLine();
                datoleido = AD.ReadLine();

                while (datoleido != null)
                {
                    string[] registro = datoleido.Split(';');
                    if (Convert.ToInt32(registro[0]) == salesorderid)
                    {
                        resultado = Convert.ToInt32(registro[10]);
                    }

                    datoleido = AD.ReadLine();
                }


                AD.Close();
                AD.Dispose();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return resultado;


        }

        public string ObtenerUltimaVenta(int customerid)
        {

            DateTime LastOrder = DateTime.Parse("01/01/1900");
            try
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                string datoleido = AD.ReadLine();
                datoleido = AD.ReadLine();

                while (datoleido != null)
                {
                    string[] registro = datoleido.Split(';');
                    if (Convert.ToInt32(registro[10]) == customerid)
                    {
                        if (Convert.ToDateTime(registro[3]) > LastOrder)
                        {
                            LastOrder = Convert.ToDateTime(registro[3]);
                        }
                        
                    }

                    datoleido = AD.ReadLine();
                }


                AD.Close();
                AD.Dispose();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return LastOrder.ToString();

        }

        public int ObtenerQComprasPorCliente(int customerid)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();
            int QOrderSales = 0;

            while (datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                if (Convert.ToInt32(registro[10]) == customerid)
                {

                    QOrderSales++;
                }

                datoleido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return QOrderSales;
        }

    }
}
