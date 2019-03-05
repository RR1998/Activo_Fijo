using ActivoFijo.AuxiliaryClasses;
using ActivoFijo.DatabaseModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivoFijo.Bienes.NuevoBien
{
    public partial class CambioBien : Form
    {
        public string Usuario;

        public CambioBien(string User)
        {
            InitializeComponent();
            Usuario = User;
        }

        private void CambioBien_Load(object sender, EventArgs e)
        {
            Estado.Items.Add("");
            Estado.Items.Add("Usado");
            Estado.Items.Add("Nuevo");
            Clasificacion.Items.Add("");
            Marca.Items.Add("");
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            var entryPoint = (from Bien in activo_FijoEntities.BIENs
                              join Administrar in activo_FijoEntities.ADMINISTRARs on Bien.IDBIEN equals Administrar.IDBien
                              join Marca in activo_FijoEntities.MARCAs on Bien.IDMARCA equals Marca.IDMARCA
                              join Tipo in activo_FijoEntities.TIPOes on Bien.IDTIPO equals Tipo.IDTIPO
                              join Estados in activo_FijoEntities.ESTADOes on Bien.IDESTADO equals Estados.IDEstado
                              orderby Bien.IDASIGNADO, Tipo.TIPO1 ascending
                              select new 
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
                                  Cantidad = Administrar.CANTIDAD,

                              }).ToList();
            DatabaseDisplay.DataSource = entryPoint.ToList();
            DatabaseDisplay.Refresh();
            foreach (var i in entryPoint)
            {
                NumeroBien.Items.Add(i.NumeroBienAsignado);
            }

            var ConsultaMarca = (from Marca in activo_FijoEntities.MARCAs select new { Marca.NOMBREMARCA} ).ToList();
            foreach (var i in ConsultaMarca)
            {
                Marca.Items.Add(i.NOMBREMARCA);
            }

            var ConsultaClasificacion = (from Tipo in activo_FijoEntities.TIPOes select new { Tipo.TIPO1 }).ToList();
            foreach (var i in ConsultaClasificacion)
            {
                Clasificacion.Items.Add(i.TIPO1);
            }
            ConsultaMarca.Clear();
            ConsultaClasificacion.Clear();
            entryPoint.Clear();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)//Boton Actualizar
        {
            //BIEN ActualizarBien = new BIEN();
            //ADMINISTRAR ActualizarAdministrar = new ADMINISTRAR();
            string Marcatxt = Marca.Text;
            string Tipotxt = Clasificacion.Text;
            string Estadotxt = Estado.Text;
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            int IDMARCA = Convert.ToInt32(value: activo_FijoEntities.MARCAs.Where(M => M.NOMBREMARCA == Marcatxt).Select(M => M.IDMARCA).First());
            int IDTIPO = Convert.ToInt32(value: activo_FijoEntities.TIPOes.Where(T => T.TIPO1 == Tipotxt).Select(T => T.IDTIPO).First());
            int IDEstado = Convert.ToInt32(value: activo_FijoEntities.ESTADOes.Where(E => E.ESTADO1 == Estadotxt).Select(E => E.IDEstado).First());
            int ID = Convert.ToInt32((NumeroBien.Text).ToString());
            BIEN Bien = activo_FijoEntities.BIENs.FirstOrDefault(BienInQuery => BienInQuery.IDASIGNADO.Equals(ID));
            Bien.IDBIEN = Bien.IDBIEN;
            Bien.IDASIGNADO = Bien.IDASIGNADO;
            Bien.NOMBRE = Descripcion.Text.ToString();
            Bien.COLOR = Color.Text.ToString();
            Bien.IDMARCA = IDMARCA;
            Bien.IDTIPO = IDTIPO;
            Bien.IDESTADO = IDEstado;
            Bien.VIDAUTIL = Convert.ToInt32(VidaUtil.Value);
            Bien.PORCENTAGEDEPRECIACION = Porcentaje.Value;
            ADMINISTRAR Admin = activo_FijoEntities.ADMINISTRARs.FirstOrDefault(AdministrarInQuery => AdministrarInQuery.IDBien.Equals(Bien.IDBIEN));
            Admin.IDUsuario = Admin.IDUsuario;
            Admin.IDBien = Bien.IDBIEN;
            Admin.FECHAADQUISISCION = FechaAdquisicion.Value.Date;
            Admin.FECHACOMPRA = FechaCompra.Value.Date;
            Admin.Costo = Convert.ToDecimal(Costo.Text);
            Admin.CANTIDAD = Convert.ToInt32(Cantidad.Value);
            activo_FijoEntities.SaveChanges();
            var entryPoint = (from BienIdQuery in activo_FijoEntities.BIENs
                              join Administrar in activo_FijoEntities.ADMINISTRARs on BienIdQuery.IDBIEN equals Administrar.IDBien
                              join Marca in activo_FijoEntities.MARCAs on BienIdQuery.IDMARCA equals Marca.IDMARCA
                              join Tipo in activo_FijoEntities.TIPOes on BienIdQuery.IDTIPO equals Tipo.IDTIPO
                              join Estados in activo_FijoEntities.ESTADOes on BienIdQuery.IDESTADO equals Estados.IDEstado
                              orderby Bien.IDASIGNADO, Tipo.TIPO1 ascending
                              select new
                              {
                                  NumeroBienAsignado = BienIdQuery.IDASIGNADO,
                                  Descripcion = BienIdQuery.NOMBRE,
                                  Color = BienIdQuery.COLOR,
                                  Marca = Marca.NOMBREMARCA,
                                  Estado = Estados.ESTADO1,
                                  Clasificacion = Tipo.TIPO1,
                                  FechaDeAdquisicion = Administrar.FECHAADQUISISCION,
                                  FechaCompra = Administrar.FECHACOMPRA,
                                  Costo = Administrar.Costo,
                                  PorcentajeDepreciacion = BienIdQuery.PORCENTAGEDEPRECIACION,
                                  Cantidad = Administrar.CANTIDAD,

                              }).ToList();
            DatabaseDisplay.DataSource = entryPoint.ToList();
            DatabaseDisplay.Refresh();
            //(from AdministrarTabla in activo_FijoEntities.ADMINISTRARs
            //         where AdministrarTabla.IDBien == Bien.IDBIEN
            //         select new ADMINISTRAR
            //         {
            //             IDUsuario = AdministrarTabla.IDUsuario,
            //             IDBien = AdministrarTabla.IDBien,
            //             FECHAADQUISISCION = FechaAdquisicion.Value.Date,
            //             FECHACOMPRA = FechaCompra.Value.Date,
            //             Costo = Convert.ToDecimal(Costo.Text),
            //             CANTIDAD = Convert.ToInt32(Cantidad.Value)
            //         }).SingleOrDefault();

            //foreach (BIEN i in entryPoint)
            //{
            //    ActualizarBien.IDBIEN = i.IDBIEN;
            //    ActualizarBien.IDASIGNADO = i.IDASIGNADO;
            //    ActualizarBien.NOMBRE = i.NOMBRE;
            //    ActualizarBien.COLOR = i.COLOR;
            //    ActualizarBien.IDMARCA = i.IDMARCA;
            //    ActualizarBien.IDESTADO = i.IDESTADO;
            //    ActualizarBien.VIDAUTIL = i.VIDAUTIL;
            //    ActualizarBien.PORCENTAGEDEPRECIACION = i.PORCENTAGEDEPRECIACION;
            //var Admin = (from Administrar in activo_FijoEntities.ADMINISTRARs
            //                     where Administrar.IDBien == i.IDBIEN
            //                     select new ADMINISTRAR
            //                     {
            //                             IDUsuario = Administrar.IDUsuario,
            //                             IDBien = Administrar.IDBien,
            //                             FECHAADQUISISCION = FechaAdquisicion.Value.Date,
            //                             FECHACOMPRA = FechaCompra.Value.Date,
            //                             Costo = Convert.ToDecimal(Costo.Text),
            //                             CANTIDAD = Convert.ToInt32(Cantidad.Value)
            //                     }).ToList();
            //foreach (ADMINISTRAR j in Admin)
            //{
            //    ActualizarAdministrar.IDUsuario = j.IDUsuario;
            //    ActualizarAdministrar.IDBien = j.IDBien;
            //    ActualizarAdministrar.FECHAADQUISISCION = j.FECHAADQUISISCION;
            //    ActualizarAdministrar.FECHACOMPRA = j.FECHACOMPRA;
            //    ActualizarAdministrar.Costo = j.Costo;
            //    ActualizarAdministrar.CANTIDAD = j.CANTIDAD;
            //}
            //}
        }

        private void NumeroBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clasificacion.SelectedIndex = 0;
            Marca.SelectedIndex = 0;
            Estado.SelectedIndex = 0;
            int ID = Convert.ToInt32((NumeroBien.Text).ToString());
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            var entryPoint = (from Bien in activo_FijoEntities.BIENs
                              join Administrar in activo_FijoEntities.ADMINISTRARs on Bien.IDBIEN equals Administrar.IDBien
                              join Marca in activo_FijoEntities.MARCAs on Bien.IDMARCA equals Marca.IDMARCA
                              join Tipo in activo_FijoEntities.TIPOes on Bien.IDTIPO equals Tipo.IDTIPO
                              join Estados in activo_FijoEntities.ESTADOes on Bien.IDESTADO equals Estados.IDEstado
                              where Bien.IDASIGNADO == ID
                              orderby Bien.IDASIGNADO, Tipo.TIPO1 ascending
                              select new ConsultaActualizar
                              {
                                  NumeroBienAsignado = Bien.IDASIGNADO,
                                  Descripcion = Bien.NOMBRE,
                                  Color = Bien.COLOR,
                                  VidaUtil = Bien.VIDAUTIL,
                                  Marca = Marca.NOMBREMARCA,
                                  Estado = Estados.ESTADO1,
                                  Clasificacion = Tipo.TIPO1,
                                  FechaDeAdquisicion = Administrar.FECHAADQUISISCION,
                                  FechaCompra = Administrar.FECHACOMPRA,
                                  Costo = Administrar.Costo,
                                  PorcentajeDepreciacion = Bien.PORCENTAGEDEPRECIACION,
                                  Cantidad = Administrar.CANTIDAD,

                              }).ToList();

            foreach (var i in entryPoint)
            {
                Descripcion.Text = i.Descripcion;
                Color.Text = i.Color;
                Marca.SelectedText = i.Marca;
                Clasificacion.SelectedText = i.Clasificacion;
                VidaUtil.Value = i.VidaUtil;
                Estado.SelectedText = i.Estado;
                Costo.Text = i.Costo.ToString();
                FechaCompra.Value = i.FechaCompra.Value;
                FechaAdquisicion.Value = i.FechaDeAdquisicion.Value;
                Costo.Text = i.Costo.ToString();
                Porcentaje.Value = i.PorcentajeDepreciacion;
                Cantidad.Value = Convert.ToInt32(i.Cantidad);
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            Login_and_Register.MainMenu mainMenu = new Login_and_Register.MainMenu();
            mainMenu.MainMenu_Load(Usuario: Usuario);
            mainMenu.Show();
            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Login_and_Register.MainMenu mainMenu = new Login_and_Register.MainMenu();
            mainMenu.MainMenu_Load(Usuario: Usuario);
            mainMenu.Show();
            this.Close();
        }
    }
}
