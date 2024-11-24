using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPL2
{
    internal class clsEmployee
    {
        public string FileName = "HR_Employee.csv";
        public struct RegEmployee
        {
            public int BusinessEntityID;
            public int NationalIDNumber { get; set; }
            public string LoginID { get; set; }
            public string OrganizationNode { get; set; }
            public int OrganizationLevel { get; set; }
            public string JobTitle { get; set; }
            public DateTime BirthDate { get; set; }
            public string MaritalStatus { get; set; }
            public string Gender { get; set; }
            public DateTime HireDate { get; set; }
            public int SalariedFlag { get; set; }
            public int VacationHours { get; set; }
            public int SickLeaveHours { get; set; }
            public int CurrentFlag { get; set; }
            public string rowguid { get; set; }
            public DateTime ModifiedDate { get; set; }
            public string SpecialGift { get; set; }
        }


        private RegEmployee[] EmployeesT = new RegEmployee[500];
        List<RegEmployee> Employees = new List<RegEmployee>();  

        string[] meses = new string[]
        {
        "Enero", "Febrero", "Marzo", "Abril", "Mayo",
        "Junio", "Julio", "Agosto", "Septiembre",
        "Octubre", "Noviembre", "Diciembre"
        };

        public void ListarRolesCB(ComboBox CB)
        {
            string datoleido = "";
            StreamReader AD = new StreamReader(FileName);

            datoleido = AD.ReadLine();
            while(datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                CB.Items.Add(registro[5]);
                datoleido = AD.ReadLine();
            }
            AD.Close();
            CB.SelectedIndex = 0;
        }

        public void ListarMesesCB(ComboBox CB)
        {
            
            int i = 0;
            while (i < 11)
            {
                CB.Items.Add(meses[i]);
                i++;
            }
        }
        public void GenerarReporte(string Rol)
        {
            string datoleido = "";
            int TotalRol = 0;
            int MujeresRol = 0;
            int HombresRol = 0;
            StreamReader AD = new StreamReader(FileName);
            StreamWriter RD = new StreamWriter("ReporteRRHH.csv", false, Encoding.UTF8);

            RD.WriteLine("Job title:;" + Rol);
            RD.WriteLine("");
            RD.WriteLine("NationalIDNumber; BirthDate; MaritalStatus; VacationHours");

            datoleido = AD.ReadLine();
            while(datoleido != null)
            {
                string[] registro = datoleido.Split(';');
                if (registro[5] == Rol)
                {
                    RD.Write(registro[1]);
                    RD.Write(";");
                    RD.Write(registro[6]);
                    RD.Write(";");
                    RD.Write(registro[7]);
                    RD.Write(";");
                    RD.WriteLine(registro[11]);

                    TotalRol++;
                    if (registro[8] == "M")
                    {
                        HombresRol++;
                    } else if (registro[8] == "F")
                    {
                        MujeresRol++;
                    }
                }
                datoleido = AD.ReadLine(); 
            }

            RD.WriteLine("");
            RD.WriteLine("Total: ;" + TotalRol);
            RD.WriteLine("Hombres: ;" + HombresRol);
            RD.WriteLine("Mujeres: ;" + MujeresRol);

            AD.Close();
            AD.Dispose();
            RD.Close();
            RD.Dispose();

            MessageBox.Show("Reporte generado con éxito");
        }

        public void GenerarReporteCumpleaños(int Mes)
        {
            string datoleido = "";
            int i = 0;
            int BDayCounter = 0;
            StreamReader AD = new StreamReader(FileName);
            StreamWriter RD = new StreamWriter("ReporteRRHH.csv", false, Encoding.UTF8);

            RD.WriteLine("Reporte de cumpleaños");
            RD.WriteLine("Mes: ;" + meses[Mes]);
            RD.WriteLine("");
            RD.WriteLine("NationalIDNumber;BirthDate;SpecialGift");


            Mes = Mes + 1;  // pasa de índice de vector a tener mismo íncide que meses (1-12 en lugar de 0-11)

            datoleido = AD.ReadLine();
            datoleido = AD.ReadLine();  // para saltear la primera fila que son los títulos

            while (datoleido != null)
            {
                //MessageBox.Show(datoleido);
                string[] registro = datoleido.Split(';');
                DateTime BirthDate = DateTime.Parse(registro[6]);
                

                //MessageBox.Show(BirthDate.Month.ToString());
                if (BirthDate.Month == Mes)
                {   
                    // guarda los datos de los empleados que cumplen la consición
                    RegEmployee X = new RegEmployee();
                    int edad = DateTime.Today.Year - BirthDate.Year;
                    string SpecialGift = "";
                    if (  edad > 39)
                    {
                        X.SpecialGift = "X";
                    }
                    X.NationalIDNumber = Convert.ToInt32(registro[1]);
                    X.BirthDate = BirthDate;
                    X.MaritalStatus = registro[7];

                    // guarda el empleado en una lista de cumplidores
                    Employees.Add(X);
                    i++;
                    BDayCounter++;  
                    //MessageBox.Show(BirthDate.Month.ToString());
                }
                
                datoleido = AD.ReadLine();
            }

            //ordena la lista de cumplidores
            Employees = OrdenarPorCumpleaños(Employees);

            //imprime contenido reporte
            foreach (RegEmployee E in Employees)
            {
                RD.Write(E.NationalIDNumber.ToString());
                RD.Write(";");
                RD.Write(E.BirthDate.ToString("yyyy-MM-dd"));
                RD.Write(";");
                RD.WriteLine(E.SpecialGift);
            }
            RD.WriteLine("");
            RD.WriteLine("Total: ;" + BDayCounter);

            RD.Close();
            RD.Dispose();
            AD.Close(); 
            AD.Dispose();

            MessageBox.Show("Reporte generado");
        }

        public List<RegEmployee> OrdenarPorCumpleaños(List<RegEmployee> Employees)
        {
            for (int i = 0; i < Employees.Count - 1; i++)
            {
                for (int j = 0; j < Employees.Count - 1; j++)
                {
                    if (Employees[j].BirthDate.DayOfYear > Employees[j + 1].BirthDate.DayOfYear)
                    {
                        RegEmployee aux = Employees[j];
                        Employees[j] = Employees[j + 1];
                        Employees[j + 1] = aux;
                    }
                }

            }

            return Employees;
        }

    }
}
