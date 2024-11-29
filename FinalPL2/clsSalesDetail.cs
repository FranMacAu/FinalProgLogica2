using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPL2
{
    internal class clsSalesDetail
    {
        private string FileName = "Sales_SalesOrderDetail.csv";

        private struct RegSaleDetail
        {
            public int SalesOrderID;   // PK
            public int SalesOrderDetailID;
            public string CarrierTrackingNumber;
            public int OrderQty;
            public int ProductID;  // FK
            public int SpecialOfferID;
            public decimal UnitPrice;
            public decimal UnitPriceDiscount;
            public decimal LineTotal;
            public string rowguid;
            public DateTime ModifiedDate;
        }

        private RegSaleDetail[] SalesDetails = new RegSaleDetail[15000];

        public void ReporteVentasPorFactura(int salesorderID)
        {
            try
            {
                clsProduct objProd = new clsProduct();
                StreamReader AD = new StreamReader(FileName);
                StreamWriter RD = new StreamWriter("Reporte_Ventas_Por_Factura.csv", false, Encoding.UTF8);
                string[] SalesDetails = new string[4];
                bool encontrado = false;
                int cantProductos = 0;
                decimal subtotal = 0;
                decimal total = 0;


                string datoleido = AD.ReadLine();
                datoleido = AD.ReadLine();

                RD.WriteLine("Ventas realizadas por factura");
                RD.WriteLine("SalesOrderNumber: ;" + salesorderID);
                RD.WriteLine("");
                RD.WriteLine("SalesOrderIdDetail;OrderQTY;UnitPrice;ProducNumber");

                while (datoleido != null)
                {
                    string[] registro = datoleido.Split(';');

                    if (Convert.ToInt32(registro[0]) == salesorderID)
                    {
                        SalesDetails[0] = registro[1];
                        SalesDetails[1] = registro[3];
                        SalesDetails[2] = registro[6];
                        SalesDetails[3] = objProd.ObtenerProductNumber(Convert.ToInt32(registro[4]));

                        RD.Write(SalesDetails[0]);
                        RD.Write(";");
                        RD.Write(SalesDetails[1]);
                        RD.Write(";");
                        RD.Write(SalesDetails[2]);
                        RD.Write(";");
                        RD.WriteLine(SalesDetails[3]);

                        subtotal += Convert.ToInt32(SalesDetails[1]) * Convert.ToDecimal(SalesDetails[2]);
                        total += subtotal;
                        cantProductos += Convert.ToInt32(SalesDetails[1]);
                        encontrado = true;
                    }

                    datoleido = AD.ReadLine();
                }

                RD.WriteLine("");
                RD.WriteLine("Cantidad de productos: ;" + cantProductos);
                RD.WriteLine("Total: ;" + total);

                AD.Close();
                AD.Dispose();
                RD.Close();
                RD.Dispose();

                if (encontrado == true)
                {
                    MessageBox.Show("Reporte generado");
                } else { MessageBox.Show("No se encontraron coincidencias"); }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public void ReporteCompradoresProdMasVendidos(string productnumber)
        {
            try
            {
                StreamReader AD = new StreamReader(FileName);
                StreamWriter RD = new StreamWriter("Reporte_Clientes_Por_Producto.csv", false, Encoding.UTF8);
                clsSalesHeader objSalesHeader = new clsSalesHeader();
                clsProduct objProduct = new clsProduct();
                string[] VecAImprimir = new string[3];
                string ProdID = "";
                //List<int> CustomerYaChequeado = new List<int>();

                

                string datoleido = AD.ReadLine();
                datoleido = AD.ReadLine();

                ProdID = objProduct.ObtenerProductID(productnumber);
                if (ProdID != null)
                {
                    MessageBox.Show("Se encontró el producto");
                    RD.WriteLine("Compradores por producto");
                    RD.WriteLine("ProductNumber: ;" + productnumber);
                    RD.WriteLine("ProductName: ;");
                    RD.WriteLine("Total sales: ;");
                    RD.WriteLine("Total buyers: ;");

                    ProdID = "776";
                    while (datoleido != null)
                    {
                        string[] registro = datoleido.Split(';');

                        if (registro[4] == ProdID)       
                        {
                            //MessageBox.Show("Se encontró una venta del producto");

                            VecAImprimir[0] = objSalesHeader.ObtenerCustomerID(Convert.ToInt32(registro[0])).ToString();

                            MessageBox.Show("Se encontró el CustomerID");
                            VecAImprimir[1] = CantidadDeComprasPorCustomerID(Convert.ToInt32(VecAImprimir[0])).ToString(); // cantidad de ventas a ese customer id de ese id producto
                            MessageBox.Show("Se encontró Qcompras");
                            VecAImprimir[2] = objSalesHeader.ObtenerUltimaVenta(Convert.ToInt32(VecAImprimir[0]));
                            //MessageBox.Show("Se encontró última venta");

                            RD.Write(VecAImprimir[0]);
                            RD.Write(";");
                            RD.Write(VecAImprimir[1]);
                            RD.Write(";");
                            RD.WriteLine(VecAImprimir[2]);

                        }

                        datoleido = AD.ReadLine();
                    }
                    MessageBox.Show("Reporte generado");
                }
                else { MessageBox.Show("No se encontró el producto buscado"); }



                AD.Close();
                AD.Dispose();
                RD.Close();
                RD.Dispose();

                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }

        public int CantidadDeComprasPorCustomerID(int customerid)
        {
            int cantidad = 0;
            clsSalesHeader objSalesHeader = new clsSalesHeader();
            StreamReader AD = new StreamReader(FileName);
            string datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();

            while (datoleido != null)
            {
                string[] registro = datoleido.Split(';');

                if (objSalesHeader.ObtenerCustomerID(Convert.ToInt32(registro[0])) == customerid)
                {
                    cantidad++;
                }

                datoleido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
            return cantidad;
        }



    }
}
