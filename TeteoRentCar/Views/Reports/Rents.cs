using BRC.Bussiness.Entities;
using MoreLinq.Extensions;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using TeteoRentCar.Utilities;
using TRC.Bussiness.Repository;
using TRC.Bussiness.ViewModels;

namespace TeteoRentCar
{
    public partial class Rents : Form
    {
        private GenericRepository<RentDetail> _rents;
        private IList<RentDetailVM> Data { get; set; }
        public Rents()
        {
            _rents = new GenericRepository<RentDetail>();
            InitializeComponent();
        }

        private async void Rents_Load(object sender, EventArgs e)
        {
            #region SampleData

            //rents.Add(new RentDetail { 
            //    Id = 1,
            //    Comment = "Nuevo, como tu prima",
            //    Customer = new Customer { Id = 1, Name = "Jose", Identification = "001-1234567-8"},
            //    Employee = new Employee { Id = 1, Name = "Maria", Identification = "402-7456985-1", EntryDate = DateTime.MinValue},
            //    PriceByDay = 2000,
            //    Vehicle = new Vehicle { 
            //        Id = 1, Description = "Vehiculo grande para la amiga y la amante", 
            //        FuelType = new FuelType { Id = 1, Description = "Premium como tu hermana" }, 
            //        NoChassis = "6565946656",
            //        NoLicensePlate = "A3235333",
            //        NoMotor = "21656989464",
            //        VehicleModel = new VehicleModel { 
            //            Id = 1, 
            //            VehicleBrand = new VehicleBrand { Id = 1, Description = "UTESA" }, 
            //            VehicleType = new VehicleType { Id = 1, Description = "Avion de Utesa"} }
            //    },
            //    RentDate = DateTime.Now
                
            
            //});

            //rents.Add(new RentDetail
            //{
            //    Id = 1,
            //    Comment = "Luz derecha averiada",
            //    Customer = new Customer { Id = 1, Name = "Anthony", Identification = "001-6561567-8" },
            //    Employee = new Employee { Id = 1, Name = "Maria", Identification = "402-7456985-1", EntryDate = DateTime.MinValue },
            //    PriceByDay = 1000,
            //    Vehicle = new Vehicle
            //    {
            //        Id = 1,
            //        Description = "Jeepeta gris como tu futuro",
            //        FuelType = new FuelType { Id = 1, Description = "Regular" },
            //        NoChassis = "4543354354",
            //        NoLicensePlate = "B3285344",
            //        NoMotor = "12345678912",
            //        VehicleModel = new VehicleModel
            //        {
            //            Id = 1,
            //            VehicleBrand = new VehicleBrand { Id = 1, Description = "Honda" },
            //            VehicleType = new VehicleType { Id = 1, Description = "Jeepeta" }
            //        }
            //    },
            //    RentDate = DateTime.Now

            //});
            //rents.Add(new RentDetail
            //{
            //    Id = 1,
            //    Comment = "Usado",
            //    Customer = new Customer { Id = 1, Name = "Juleisy", Identification = "001-1212355-7" },
            //    Employee = new Employee { Id = 1, Name = "Jose", Identification = "402-4236587-7", EntryDate = DateTime.MinValue },
            //    PriceByDay = 500,
            //    Vehicle = new Vehicle
            //    {
            //        Id = 1,
            //        Description = "Motor de colmadero",
            //        FuelType = new FuelType { Id = 1, Description = "Regular" },
            //        NoChassis = "1234567890",
            //        NoLicensePlate = "C4565334",
            //        NoMotor = "12457485961",
            //        VehicleModel = new VehicleModel
            //        {
            //            Id = 1,
            //            VehicleBrand = new VehicleBrand { Id = 1, Description = "Hiatsu" },
            //            VehicleType = new VehicleType { Id = 1, Description = "Motor de dos ruedas" }
            //        }
            //    },
            //    RentDate = DateTime.Now

            //});
            #endregion

            Data = new List<RentDetailVM>();

            foreach (var rent in await _rents.GetAll(nameof(Employee),nameof(Vehicle),nameof(Customer), nameof(Vehicle) + "." + nameof(Vehicle.VehicleModel)))
                Data.Add(new RentDetailVM(rent));

            GridRents.DataSource = Data.ToDataTable();

        }

        private void PdfBtn_Click(object sender, EventArgs e)
        {
            CreatePDF((GridRents.DataSource as DataTable).DefaultView.ToTable());
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

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchString = SearchTextBox.Text.Trim(); 
            (GridRents.DataSource as DataTable).DefaultView.RowFilter = string.Format("CedulaCliente LIKE '%{0}%' OR Cliente LIKE '%{0}%'", searchString);


            //if (searchString != string.Empty)
            //{
            //    foreach (DataGridViewRow row in GridRents.Rows)
            //    {

            //        //BindingSource bs = new BindingSource();
            //        //bs.DataSource = GridRents.DataSource;
            //        //bs.Filter = GridRents.Columns["CedulaCliente"].HeaderText.ToString() + " LIKE '%" + searchString + "%'";
            //        //GridRents.DataSource = bs;

            //        //dataTable1.DefaultView.RowFilter = $"[CedulaCliente] LIKE '%searchString%'";

            //        if (row.Cells["CedulaCliente"].Value.ToString().Contains(searchString))
            //        {
            //            GridRents.CurrentRow.Selected = false;
            //            GridRents.Rows[row.Index].Selected = true;
            //            int index = row.Index;
            //            GridRents.FirstDisplayedScrollingRowIndex = index;

            //            break;
            //        }
            //    }
            //}
        }

    }
}
