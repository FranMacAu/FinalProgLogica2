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

                List<int> ventas = new List<int>();     // lista de ventas del prodid
                clsSalesHeader objSalesHeader = new clsSalesHeader();
                clsProduct objProduct = new clsProduct();
                string[] VecAImprimir = new string[3];
                string ProdID = "";
                List<int> CustomerYaChequeado = new List<int>();
                List<int> CustomerIDs = new List<int>();    //lista de compradores 
                int CantidadVendidosTotal = 0;
                

                

                string datoleido = AD.ReadLine();
                datoleido = AD.ReadLine();

                ProdID = objProduct.ObtenerProductID(productnumber);
                if (ProdID != null)
                {


                    while (datoleido != null)
                    {
                        string[] registro = datoleido.Split(';');
                        if (Convert.ToString(registro[4]) == ProdID)
                        {
                            ventas.Add(Convert.ToInt32(registro[0]));  // 

                        }
                        datoleido = AD.ReadLine();
                    }       // hasta acá tenemos una lista de los salesorderid

                    CustomerIDs = objSalesHeader.ObtenerCustomerIDs(ventas);    // lista de customerids en lugar de salesorderids
                    CantidadVendidosTotal = ventas.Count;
                    List<int> ListaClientes = SacarRepetidos(CustomerIDs);    //acá le dejamos una lista de valores únicos

                    List<int> ListaVentasPorCliente = new List<int>();


                    foreach (int i in ListaClientes)
                    {
                        int c = 0;
                        int CantDeVentas = 0;
                        while (c < CustomerIDs.Count())
                        {
                            if (i == CustomerIDs[c])
                            {
                                CantDeVentas++;
                            }
                            c++;
                        }
                        ListaVentasPorCliente.Add(CantDeVentas);
                    }       // acá ya tenemos generada una lista paralela a ListaClientes con la cantidad de ventas respectivas

                    //ordenar ambas listas
                    for (int i = 0; i < ListaClientes.Count - 1; i++)
                    {
                        for (int j = 0; j < ListaClientes.Count - 1 - i; j++)
                        {
                            if (ListaVentasPorCliente[j] < ListaVentasPorCliente[j + 1])
                            {
                                int auxVentas = ListaVentasPorCliente[j];
                                ListaVentasPorCliente[j] = ListaVentasPorCliente[j + 1];
                                ListaVentasPorCliente[j + 1] = auxVentas;

                                int auxCliente = ListaClientes[j];
                                ListaClientes[j] = ListaClientes[j + 1];
                                ListaClientes[j + 1] = auxCliente;
                            }
                        }
                    }

                    List<string> ListaFechasUltimaCompra = objSalesHeader.ObtenerUltimaVenta(ListaClientes);


                    // acá ya tenemos lista de compradores del producto, otra lista con las compras totales del prod por cliente y otra lista con las fechas de la última compra de c/u. Todas con el mismo índice

                    // imprimimos el reporte
                    RD.WriteLine("Compradores por producto");
                    RD.WriteLine("ProductNumber: ;" + productnumber);
                    RD.WriteLine("ProductName: ;" + objProduct.ObtenerProductName(Convert.ToInt32(ProdID)));
                    RD.WriteLine("Total sales: ;" + ventas.Count);
                    RD.WriteLine("Total buyers: ;" + ListaClientes.Count);
                    RD.WriteLine("");
                    RD.WriteLine("CustomerID;QOrderSales;LastOrder");


                    int INDListas = 0;
                    while (INDListas < ListaClientes.Count)
                    {
                        RD.Write(ListaClientes[INDListas].ToString());
                        RD.Write(";");
                        RD.Write(ListaVentasPorCliente[INDListas].ToString());
                        RD.Write(";");
                        RD.WriteLine(ListaFechasUltimaCompra[INDListas]);

                        INDListas++;
                    }
                    MessageBox.Show("Reporte generado");
                } else { MessageBox.Show("No se encontró el producto buscado"); }



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

        public List<int> SacarRepetidos(List<int> lista)    
        {
            List<int> ListaLimpia = new List<int>();

            foreach (int i in lista)
            {
                if (!ListaLimpia.Contains(i))
                {
                    ListaLimpia.Add(i);
                }
            }

            return ListaLimpia;
        }
        



    }
}
