using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalPL2.clsEmployee;

namespace FinalPL2
{
    internal class clsProduct
    {
        private string FileName = "Product_Product.csv";
        public struct RegProduct
        {
            public int ProductID;
            public string Name;
            public string ProductNumber;
            public int MakeFlag;
            public int FinishedGoodsFlag;
            public string Color;
            public int SafetyStockLevel;
            public int ReorderPoint;
            public int StandardCost;
            public int ListPrice;
            public string Size;
            public string SizeUnitMeasureCode;
            public string WeightUnitMeasureCode;
            public decimal Weight;
            public int DaysToManufacture {  get; set; }
            public string ProductLine;
            public string Class;
            public string Style;
            public int ProductSubcategoryID;
            public int ProductModelID;
            public DateTime SellStartDate;
            public DateTime SellEndDate;
            public bool? DiscontinuedDate;
            public string rowguid;
            public DateTime ModifiedDate;
        }

        private RegProduct[] ProductsT = new RegProduct[1000];
        List<RegProduct> Products = new List<RegProduct>();

        public void ReporteResultadosBusqueda(string busqueda)
        {
            StreamReader AD = new StreamReader(FileName);
            StreamWriter RD = new StreamWriter("Reporte_busqueda.csv", false, Encoding.UTF8);
            try
            {
                string datoleido = "";
                List<RegProduct> Products = new List<RegProduct>();
                

                datoleido = AD.ReadLine();  // para saltear primera fila que son títulos
                datoleido = AD.ReadLine();

                while (datoleido != null)
                {
                    string[] registro = datoleido.Split(';');
                    if (registro[1] != null && registro[2] != null)
                    {
                        if (registro[1].ToLower().Contains(busqueda.ToLower()) || registro[2].ToLower().Contains(busqueda.ToLower()))
                        {
                            RegProduct X = new RegProduct();
                            X.Name = registro[1];
                            X.ProductNumber = registro[2];
                            X.DaysToManufacture = Convert.ToInt32(registro[14]);
                            X.SafetyStockLevel = Convert.ToInt32(registro[6]);

                            Products.Add(X);
                        }
                    } 
                    
                    datoleido = AD.ReadLine();
                }
                

                if (Products.Count > 0)
                {
                    RD.WriteLine("Reporte de productos coincidentes con la búsqueda");
                    RD.WriteLine("Búsqueda: ;" + busqueda);
                    RD.WriteLine("Name;ProductNumber;DaysToManufacture;SafetyStockLevel");
                    Products = OrdenarPorName(Products);

                    foreach (RegProduct X in Products)
                    {
                        RD.Write(X.Name);
                        RD.Write(";");
                        RD.Write(X.ProductNumber);
                        RD.Write(";");
                        RD.Write(X.DaysToManufacture);
                        RD.Write(";");
                        RD.WriteLine(X.SafetyStockLevel);

                    }
                    

                    MessageBox.Show("Reporte generado");

                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias para su búsqueda");
                }


                }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            AD.Close();
            AD.Dispose();
            RD.Close();
            RD.Dispose();
        }

        public void ReporteProductosOrdenados()
        {
            try
            {
                string datoleido = "";
                List<RegProduct> Products = new List<RegProduct>();
                StreamReader AD = new StreamReader(FileName);
                StreamWriter RD = new StreamWriter("Reporte_Productos_Ordenados.csv", false, Encoding.UTF8);

                datoleido = AD.ReadLine();  // para saltear primera fila que son títulos
                datoleido = AD.ReadLine();

                while (datoleido != null)
                {
                    string[] registro = datoleido.Split(';');
                    RegProduct X = new RegProduct();
                    X.Name = registro[1];
                    X.ProductNumber = registro[2];
                    X.DaysToManufacture = Convert.ToInt32(registro[14]);
                    X.SellStartDate = Convert.ToDateTime(registro[20]);

                    Products.Add(X);

                    datoleido = AD.ReadLine();
                }

                AD.Close();
                AD.Dispose();

                RD.WriteLine("Listado de todos los productos ordenados por días para manufacturar");
                RD.WriteLine("Name;ProductNumber;DaysToManufacture;SellStartDate");
                Products = OrdenarPorDaysToManufacture(Products);

                foreach (RegProduct X in Products)
                {
                    RD.Write(X.Name);
                    RD.Write(";");
                    RD.Write(X.ProductNumber);
                    RD.Write(";");
                    RD.Write(X.DaysToManufacture);
                    RD.Write(";");
                    RD.WriteLine(X.SellStartDate);

                }

                RD.Close();
                RD.Dispose();

                MessageBox.Show("Reporte generado");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }

        public List<RegProduct> OrdenarPorDaysToManufacture(List<RegProduct> Productos)
        {
            try
            {
                for (int i = 0; i < Productos.Count - 1; i++)
                {
                    for (int j = 0; j < Productos.Count - 1; j++)
                    {
                        if (Convert.ToInt32(Productos[j].DaysToManufacture) < Convert.ToInt32(Productos[j + 1].DaysToManufacture))
                        {
                            RegProduct aux = Productos[j];
                            Productos[j] = Productos[j + 1];
                            Productos[j + 1] = aux;
                        }
                    }

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Ocurrió un error al ordenar la lista de productos. Detalle: " + e.Message);
            }
            

            return Productos;
        }

        public List<RegProduct> OrdenarPorName(List<RegProduct> Productos)
        {
            try
            {
                for (int i = 0; i < Productos.Count - 1; i++)
                {
                    for (int j = 0; j < Productos.Count - 1; j++)
                    {
                        if (Productos[j].Name.CompareTo(Productos[j+1].Name) > 0)
                        {
                            RegProduct aux = Productos[j];
                            Productos[j] = Productos[j + 1];
                            Productos[j + 1] = aux;
                        }
                    }

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Ocurrió un error al ordenar la lista de productos. Detalle: " + e.Message);
            }


            return Productos;
        }

        public string ObtenerProductNumber(int productid)
        {
            StreamReader AD = new StreamReader(FileName);
            string productnumber = "";

            string datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();

            while(datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                if (Convert.ToInt32(registro[0]) == productid) 
                {
                    productnumber = registro[2];
                }
                datoleido = AD.ReadLine();
            }

            return productnumber;
        }

        public string ObtenerProductID(string productnumber)
        {
            StreamReader AD = new StreamReader(FileName);
            string productid = "";

            string datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();

            while (datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                if (registro[2] == productnumber)
                {
                    productid = registro[0];
                }
                datoleido = AD.ReadLine();
            }

            return productid;

        }

        public string ObtenerProductName(int productid)
        {
            StreamReader AD = new StreamReader(FileName);
            string productname = "";

            string datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();

            while (datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                if (Convert.ToInt32(registro[0]) == productid)
                {
                    productname = registro[1];
                }
                datoleido = AD.ReadLine();
            }

            return productname;
        }


    }
}
