using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ActivoFijo.AuxiliaryClasses
{
    class ExcelGenerator
    {
        public void ExportToExcel(List<ConsultaConvertida> Consulta, string ClasificacionDeConsulta)
        {
            string Clasificacion = "";
            DateTime Fecha = new DateTime();
            string Anio = "";
            System.Data.DataTable Excel = new System.Data.DataTable();
            Excel.Columns.Add(columnName: "ID", type: typeof(int));
            Excel.Columns.Add(columnName: "Descripcion", type: typeof(string));
            Excel.Columns.Add(columnName: "Color", type: typeof(string));
            Excel.Columns.Add(columnName: "Marca", type: typeof(string));
            Excel.Columns.Add(columnName: "Estado", type: typeof(string));
            Excel.Columns.Add(columnName: "Clasificacion", type: typeof(string));
            Excel.Columns.Add(columnName: "Fecha de Adquisicion", type: typeof(DateTime));
            Excel.Columns.Add(columnName: "Fecha de Compra", type: typeof(DateTime));
            Excel.Columns.Add(columnName: "Costo", type: typeof(string));
            Excel.Columns.Add(columnName: "Porcentaje de Depreciacion", type: typeof(string));
            Excel.Columns.Add(columnName: "Fecha Fin de Consulta", type: typeof(DateTime));
            Excel.Columns.Add(columnName: "Depreciacion acumulada", type: typeof(string));
            Excel.Columns.Add(columnName: "Valor Depreciado a la Fecha", type: typeof(string));
            Excel.Columns.Add(columnName: "Cantidad", type: typeof(int));
            foreach (var v in Consulta)
            {
                Clasificacion = v.Clasificacion;
                Fecha = v.FechaFinConsulta;
                Excel.Rows.Add(v.NumeroBienAsignado, v.Descripcion, v.Color, v.Marca, v.Estado, v.Clasificacion, v.FechaDeAdquisicion ?? DateTime.Now, v.FechaCompra ?? DateTime.Now, v.Costo, v.PorcentajeDepreciacion,
                                v.FechaFinConsulta, v.DepreciacionAcumulada ,v.ValorDepreciadoFecha, v.Cantidad);
                Anio = v.FechaFinConsulta.Year.ToString();
            }
            try
            {
                string Month, Day, Year;
                Month = Fecha.Month.ToString();
                Day = Fecha.Day.ToString();
                Year = Fecha.Year.ToString();
                Microsoft.Office.Interop.Excel.Application Archivo = new Microsoft.Office.Interop.Excel.Application();
                Workbook Workbook;
                Worksheet Worksheet;
                Range Cellrange;
                Archivo.Visible = false;
                Archivo.DisplayAlerts = false;
                Workbook = Archivo.Workbooks.Add(Template: Type.Missing);
                Worksheet = (Worksheet)Workbook.ActiveSheet;
                Worksheet.Name = ClasificacionDeConsulta;
                Worksheet.Range[Worksheet.Cells[1, 1], Cell2: Worksheet.Cells[1, 13]].Merge();
                Worksheet.Cells[1, 1] = $"CONSTRUCTORA BERNARD R.C. SA. DE C.V. Clasificacion: {Clasificacion} Fecha: {Month}/{Day}/{Year}";
                //Worksheet.Cells[1, 1] = "ID";
                //Worksheet.Cells[1, 2] = "Descripcion";
                //Worksheet.Cells[1, 3] = "Color";
                //Worksheet.Cells[1, 4] = "Marca";
                //Worksheet.Cells[1, 5] = "Estado";
                //Worksheet.Cells[1, 6] = "Clasificacion";
                //Worksheet.Cells[1, 7] = "Fecha de adquisicion";
                //Worksheet.Cells[1, 8] = "Fecha de compra";
                //Worksheet.Cells[1, 9] = "Costo";
                //Worksheet.Cells[1, 10] = "Porcentaje de depreciacion";
                //Worksheet.Cells[1, 11] = "Fecha Fin de consulta";
                //Worksheet.Cells[1, 12] = "Depreciacion acumulada";
                //Worksheet.Cells[1, 13] = "Valor depreciado a la fecha";
                //Worksheet.Cells[1, 14] = "Cantidad";
                Worksheet.Cells.Font.Size = 15;
                int rowcount = 2;

                foreach (System.Data.DataRow data in Excel.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= Excel.Columns.Count; i++)
                    {

                        if (rowcount == 3)
                        {
                            Worksheet.Cells[RowIndex: 2, ColumnIndex: i] = Excel.Columns[index: i - 1].ColumnName;
                            Worksheet.Cells.Font.Color = System.Drawing.Color.Black;

                        }

                        Worksheet.Cells[RowIndex: rowcount, ColumnIndex: i] = data[columnIndex: i - 1].ToString();

                        if (rowcount > 3)
                        {
                            if (i == Excel.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                Cellrange = Worksheet.Range[Cell1: Worksheet.Cells[RowIndex: rowcount, ColumnIndex: 1], Cell2: Worksheet.Cells[RowIndex: rowcount, ColumnIndex: Excel.Columns.Count]];
                                }

                            }
                        }

                    }

                }

                Cellrange = Worksheet.Range[Cell1: Worksheet.Cells[RowIndex: 1, ColumnIndex: 1], Cell2: Worksheet.Cells[RowIndex: rowcount, ColumnIndex: Excel.Columns.Count]];
                Cellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = Cellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                Cellrange = Worksheet.Range[Cell1: Worksheet.Cells[RowIndex: 1, ColumnIndex: 1], Cell2: Worksheet.Cells[RowIndex: 2, ColumnIndex: Excel.Columns.Count]];
                Workbook.SaveAs("..\\Desktop\\ActivoFijo " + Anio + " " + Clasificacion +".xlsx");
                Workbook.Close();
                Archivo.Quit();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }


}
