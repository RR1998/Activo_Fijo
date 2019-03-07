using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ActivoFijo.DatabaseModule;
using ActivoFijo.AuxiliaryClasses;
using System.Collections.Generic;
using System.Globalization;

namespace ActivoFijo.ActivoFijoCalc
{
    public partial class ActivoFijoCalculator : Form
    {
        public string Usuario;

        internal List<ConsultaConvertida> Consulta { get; set; } = new List<ConsultaConvertida>();
        internal List<ConsultaConvertida> AuxConsulta { get; set; } = new List<ConsultaConvertida>();

        public ActivoFijoCalculator(string User)
        {
            InitializeComponent();
            Usuario = User;
        }

        private void ActivoFijo_Load(object sender, EventArgs e)
        {
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            ClasificacionBox.DataSource = activo_FijoEntities.TIPOes.ToList();
            ClasificacionBox.ValueMember = "IDTIPO";
            ClasificacionBox.DisplayMember = "TIPO1";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            GenerarTabla();
        }
        private void GenerarTabla()
        {
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            int FechaFin = 0;
            FechaFin = Convert.ToInt32(value: FechaFinal.Value.Year.ToString());
            if (ClasificacionBox.Text == "Todos")
            {
                var entryPoint = (from Bien in activo_FijoEntities.BIENs
                                  join Administrar in activo_FijoEntities.ADMINISTRARs on Bien.IDBIEN equals Administrar.IDBien
                                  join Marca in activo_FijoEntities.MARCAs on Bien.IDMARCA equals Marca.IDMARCA
                                  join Tipo in activo_FijoEntities.TIPOes on Bien.IDTIPO equals Tipo.IDTIPO
                                  join Estados in activo_FijoEntities.ESTADOes on Bien.IDESTADO equals Estados.IDEstado
                                  where Administrar.FECHAADQUISISCION.Value.Year <= FechaFin
                                  orderby Administrar.FECHACOMPRA ascending
                                  select new ConsultaDepreciacion
                                  {
                                      NumeroBienAsignado = Bien.IDASIGNADO,
                                      Descripcion = Bien.NOMBRE,
                                      Color = Bien.COLOR,
                                      Marca = Marca.NOMBREMARCA,
                                      Estado = Estados.ESTADO1,
                                      Clasificacion = Tipo.TIPO1,
                                      FechaDeAdquisicion = Administrar.FECHAADQUISISCION,
                                      FechaCompra = Administrar.FECHACOMPRA,
                                      Costo = Administrar.Costo,
                                      PorcentajeDepreciacion = Bien.PORCENTAGEDEPRECIACION,
                                      FechaFinConsulta = FechaFinal.Value,
                                      DepreciacionAcumulada = Administrar.Costo * (Bien.PORCENTAGEDEPRECIACION / 100) * (FechaFin - Administrar.FECHAADQUISISCION.Value.Year),
                                      ValorDepreciadoFecha = Administrar.Costo - (Administrar.Costo * (Bien.PORCENTAGEDEPRECIACION / 100) * (FechaFin - Administrar.FECHAADQUISISCION.Value.Year)),
                                      Cantidad = Administrar.CANTIDAD,
                                  }).ToList();
                foreach (var v in entryPoint)
                {
                    ConsultaConvertida Aux = new ConsultaConvertida();
                    if (v.ValorDepreciadoFecha <= 0)
                    {
                        Aux.NumeroBienAsignado = v.NumeroBienAsignado;
                        Aux.Descripcion = v.Descripcion;
                        Aux.Color = v.Color;
                        Aux.Marca = v.Marca;
                        Aux.Estado = v.Estado;
                        Aux.Clasificacion = v.Clasificacion;
                        Aux.FechaDeAdquisicion = v.FechaDeAdquisicion;
                        Aux.FechaCompra = v.FechaCompra;
                        //Aux.Costo = $"{v.Costo: C}";
                        Aux.Costo = v.Costo.ToString(format: "C2");
                        //Aux.PorcentajeDepreciacion = $"{(float)v.PorcentajeDepreciacion: P}";
                        Aux.PorcentajeDepreciacion = string.Format(provider: CultureInfo.InvariantCulture, format: "{0: #0.##%}", arg0: (double)v.PorcentajeDepreciacion * 0.01);
                        Aux.FechaFinConsulta = v.FechaFinConsulta;
                        Aux.DepreciacionAcumulada = Aux.Costo;
                        //Aux.ValorDepreciadoFecha = $"{0.00: C}";
                        Aux.ValorDepreciadoFecha = 0.00.ToString(format: "C2");
                        Aux.Cantidad = v.Cantidad;
                    }
                    else
                    {
                        Aux.NumeroBienAsignado = v.NumeroBienAsignado;
                        Aux.Descripcion = v.Descripcion;
                        Aux.Color = v.Color;
                        Aux.Marca = v.Marca;
                        Aux.Estado = v.Estado;
                        Aux.Clasificacion = v.Clasificacion;
                        Aux.FechaDeAdquisicion = v.FechaDeAdquisicion;
                        Aux.FechaCompra = v.FechaCompra;
                        //Aux.Costo = $"{(float)v.Costo: C}";
                        Aux.Costo = v.Costo.ToString(format: "C2");
                        //Aux.PorcentajeDepreciacion = $"{(float)v.PorcentajeDepreciacion: P}";
                        Aux.PorcentajeDepreciacion = string.Format(provider: CultureInfo.InvariantCulture, format: "{0: #0.##%}", arg0: (double)v.PorcentajeDepreciacion * 0.01);
                        Aux.FechaFinConsulta = v.FechaFinConsulta;
                        Aux.DepreciacionAcumulada = v.DepreciacionAcumulada.ToString(format: "C2");
                        //Aux.ValorDepreciadoFecha = $"{(float)v.ValorDepreciadoFecha: C}";
                        Aux.ValorDepreciadoFecha = v.ValorDepreciadoFecha.ToString(format: "C2");
                        Aux.Cantidad = v.Cantidad;
                    }
                    Consulta.Add(item: Aux);
                }
                AuxConsulta.Clear();
                foreach (var v in Consulta)
                {
                    AuxConsulta.Add(v);
                }

                DatabaseDisplay.DataSource = Consulta.ToList();
                DatabaseDisplay.Refresh();
                Consulta.Clear();
            }
            else
            {
                var entryPoint = (from Bien in activo_FijoEntities.BIENs
                                  join Administrar in activo_FijoEntities.ADMINISTRARs on Bien.IDBIEN equals Administrar.IDBien
                                  join Marca in activo_FijoEntities.MARCAs on Bien.IDMARCA equals Marca.IDMARCA
                                  join Tipo in activo_FijoEntities.TIPOes on Bien.IDTIPO equals Tipo.IDTIPO
                                  join Estados in activo_FijoEntities.ESTADOes on Bien.IDESTADO equals Estados.IDEstado
                                  where Administrar.FECHAADQUISISCION.Value.Year <= FechaFin where Tipo.TIPO1 == ClasificacionBox.Text
                                  orderby Administrar.FECHACOMPRA ascending
                                  select new ConsultaDepreciacion
                                  {
                                      NumeroBienAsignado = Bien.IDASIGNADO,
                                      Descripcion = Bien.NOMBRE,
                                      Color = Bien.COLOR,
                                      Marca = Marca.NOMBREMARCA,
                                      Estado = Estados.ESTADO1,
                                      Clasificacion = Tipo.TIPO1,
                                      FechaDeAdquisicion = Administrar.FECHAADQUISISCION,
                                      FechaCompra = Administrar.FECHACOMPRA,
                                      Costo = Administrar.Costo,
                                      PorcentajeDepreciacion = Bien.PORCENTAGEDEPRECIACION,
                                      FechaFinConsulta = FechaFinal.Value,
                                      DepreciacionAcumulada = Administrar.Costo * (Bien.PORCENTAGEDEPRECIACION / 100) * (FechaFin - Administrar.FECHAADQUISISCION.Value.Year),
                                      ValorDepreciadoFecha = Administrar.Costo - (Administrar.Costo * (Bien.PORCENTAGEDEPRECIACION / 100) * (FechaFin - Administrar.FECHAADQUISISCION.Value.Year)),
                                      Cantidad = Administrar.CANTIDAD,
                                  }).ToList();
                foreach (var v in entryPoint)
                {
                    ConsultaConvertida Aux = new ConsultaConvertida();
                    if (v.ValorDepreciadoFecha <= 0)
                    {
                        Aux.NumeroBienAsignado = v.NumeroBienAsignado;
                        Aux.Descripcion = v.Descripcion;
                        Aux.Color = v.Color;
                        Aux.Marca = v.Marca;
                        Aux.Estado = v.Estado;
                        Aux.Clasificacion = v.Clasificacion;
                        Aux.FechaDeAdquisicion = v.FechaDeAdquisicion;
                        Aux.FechaCompra = v.FechaCompra;
                        //Aux.Costo = $"{v.Costo: C}";
                        Aux.Costo = v.Costo.ToString(format: "C2");
                        //Aux.PorcentajeDepreciacion = $"{(float)v.PorcentajeDepreciacion: P}";
                        Aux.PorcentajeDepreciacion = string.Format(provider: CultureInfo.InvariantCulture, format: "{0: #0.##%}", arg0: (double)v.PorcentajeDepreciacion * 0.01);
                        Aux.FechaFinConsulta = v.FechaFinConsulta;
                        Aux.DepreciacionAcumulada = Aux.Costo;
                        //Aux.ValorDepreciadoFecha = $"{0.00: C}";
                        Aux.ValorDepreciadoFecha = 0.00.ToString(format: "C2");
                        Aux.Cantidad = v.Cantidad;
                    }
                    else
                    {
                        Aux.NumeroBienAsignado = v.NumeroBienAsignado;
                        Aux.Descripcion = v.Descripcion;
                        Aux.Color = v.Color;
                        Aux.Marca = v.Marca;
                        Aux.Estado = v.Estado;
                        Aux.Clasificacion = v.Clasificacion;
                        Aux.FechaDeAdquisicion = v.FechaDeAdquisicion;
                        Aux.FechaCompra = v.FechaCompra;
                        //Aux.Costo = $"{(float)v.Costo: C}";
                        Aux.Costo = v.Costo.ToString(format: "C2");
                        //Aux.PorcentajeDepreciacion = $"{(float)v.PorcentajeDepreciacion: P}";
                        Aux.PorcentajeDepreciacion = string.Format(provider: CultureInfo.InvariantCulture, format: "{0: #0.##%}", arg0: (double)v.PorcentajeDepreciacion * 0.01);
                        Aux.FechaFinConsulta = v.FechaFinConsulta;
                        Aux.DepreciacionAcumulada = v.DepreciacionAcumulada.ToString(format: "C2");
                        //Aux.ValorDepreciadoFecha = $"{(float)v.ValorDepreciadoFecha: C}";
                        Aux.ValorDepreciadoFecha = v.ValorDepreciadoFecha.ToString(format: "C2");
                        Aux.Cantidad = v.Cantidad;
                    }
                    Consulta.Add(item: Aux);
                }
                AuxConsulta.Clear();
                foreach (var v in Consulta)
                {
                    AuxConsulta.Add(v);
                }

                DatabaseDisplay.DataSource = Consulta.ToList();
                DatabaseDisplay.Refresh();
                Consulta.Clear();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Login_and_Register.MainMenu mainMenu = new Login_and_Register.MainMenu();
            mainMenu.MainMenu_Load(Usuario: Usuario);
            mainMenu.Show();
            this.Hide();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ExcelGenerator Excel = new ExcelGenerator();
            Excel.ExportToExcel(AuxConsulta, ClasificacionBox.Text);
        }
    }
}