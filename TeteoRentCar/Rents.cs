using BRC.Bussiness.Entities;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TRC.Bussiness.ViewModels;

namespace TeteoRentCar
{
    public partial class Rents : Form
    {
        public Rents()
        {
            InitializeComponent();

            IList<RentDetail> rents = new List<RentDetail>();

            #region SampleData

            rents.Add(new RentDetail { 
                Id = 1,
                Comment = "Nuevo, como tu prima",
                Customer = new Customer { Id = 1, Name = "Jose", Identification = "001-1234567-8"},
                Employee = new Employee { Id = 1, Name = "Maria", Identification = "402-7456985-1", EntryDate = DateTime.MinValue},
                PriceByDay = 2000,
                Vehicle = new Vehicle { 
                    Id = 1, Description = "Vehiculo grande para la amiga y la amante", 
                    FuelType = new FuelType { Id = 1, Description = "Premium como tu hermana" }, 
                    NoChassis = "6565946656",
                    NoLicensePlate = "A3235333",
                    NoMotor = "21656989464",
                    VehicleModel = new VehicleModel { 
                        Id = 1, 
                        VehicleBrand = new VehicleBrand { Id = 1, Description = "UTESA" }, 
                        VehicleType = new VehicleType { Id = 1, Description = "Avion de Utesa"} }
                },
                RentDate = DateTime.Now
                
            
            });

            rents.Add(new RentDetail
            {
                Id = 1,
                Comment = "Luz derecha averiada",
                Customer = new Customer { Id = 1, Name = "Anthony", Identification = "001-6561567-8" },
                Employee = new Employee { Id = 1, Name = "Maria", Identification = "402-7456985-1", EntryDate = DateTime.MinValue },
                PriceByDay = 1000,
                Vehicle = new Vehicle
                {
                    Id = 1,
                    Description = "Jeepeta gris como tu futuro",
                    FuelType = new FuelType { Id = 1, Description = "Regular" },
                    NoChassis = "4543354354",
                    NoLicensePlate = "B3285344",
                    NoMotor = "12345678912",
                    VehicleModel = new VehicleModel
                    {
                        Id = 1,
                        VehicleBrand = new VehicleBrand { Id = 1, Description = "Honda" },
                        VehicleType = new VehicleType { Id = 1, Description = "Jeepeta" }
                    }
                },
                RentDate = DateTime.Now

            });
            rents.Add(new RentDetail
            {
                Id = 1,
                Comment = "Usado",
                Customer = new Customer { Id = 1, Name = "Juleisy", Identification = "001-1212355-7" },
                Employee = new Employee { Id = 1, Name = "Jose", Identification = "402-4236587-7", EntryDate = DateTime.MinValue },
                PriceByDay = 500,
                Vehicle = new Vehicle
                {
                    Id = 1,
                    Description = "Motor de colmadero",
                    FuelType = new FuelType { Id = 1, Description = "Regular" },
                    NoChassis = "1234567890",
                    NoLicensePlate = "C4565334",
                    NoMotor = "12457485961",
                    VehicleModel = new VehicleModel
                    {
                        Id = 1,
                        VehicleBrand = new VehicleBrand { Id = 1, Description = "Hiatsu" },
                        VehicleType = new VehicleType { Id = 1, Description = "Motor de dos ruedas" }
                    }
                },
                RentDate = DateTime.Now

            });
            #endregion

            IList<RentsVM> data = new List<RentsVM>();

            foreach (var rent in rents)
                data.Add(new RentsVM(rent));

            GridRents.DataSource = data;
        }

        private void PdfBtn_Click(object sender, EventArgs e)
        {
            CreatePDF(GridRents.DataSource);
        }

        private void CreatePDF(object data)
        {
            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.Pages.Add();

            PdfGrid pdfGrid = new PdfGrid
            {
                DataSource = data
            };

            pdfGrid.Draw(page, new PointF(10, 10));

            string folderPath = "C:\\PdfTest\\";
            if (!System.IO.Directory.Exists(folderPath))
                System.IO.Directory.CreateDirectory(folderPath);

            string fullPath = folderPath + "Reporte_de_rentas_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".pdf";

            doc.Save(fullPath);

            doc.Close(true);

            var wb = new WebBrowser();
            wb.Navigate(fullPath);

        }
    }
}
