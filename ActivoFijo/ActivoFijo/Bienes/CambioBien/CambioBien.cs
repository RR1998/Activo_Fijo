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
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            int IDMARCA = Convert.ToInt32(value: activo_FijoEntities.MARCAs.Where(predicate: M => M.NOMBREMARCA == Marca.Text).Select(selector: M => M.IDMARCA).First());
            int IDTIPO = Convert.ToInt32(value: activo_FijoEntities.TIPOes.Where(predicate: T => T.TIPO1 == Clasificacion.Text).Select(selector: T => T.IDTIPO).First());
            int IDEstado = Convert.ToInt32(value: activo_FijoEntities.ESTADOes.Where(predicate: E => E.ESTADO1 == Estado.Text).Select(selector: E => E.IDEstado).First());
            int ID = Convert.ToInt32(value: NumeroBien.Text.ToString());

            BIEN Bien = activo_FijoEntities.BIENs.FirstOrDefault(predicate: BienInQuery => BienInQuery.IDASIGNADO.Equals(ID));
            Bien.IDBIEN = Bien.IDBIEN;
            Bien.IDASIGNADO = Bien.IDASIGNADO;
            Bien.NOMBRE = Descripcion.Text.ToString();
            Bien.COLOR = Color.Text.ToString();
            Bien.IDMARCA = IDMARCA;
            Bien.IDTIPO = IDTIPO;
            Bien.IDESTADO = IDEstado;
            Bien.VIDAUTIL = Convert.ToInt32(value: VidaUtil.Value);
            Bien.PORCENTAGEDEPRECIACION = Porcentaje.Value;

            ADMINISTRAR Admin = activo_FijoEntities.ADMINISTRARs.FirstOrDefault(predicate: AdministrarInQuery => AdministrarInQuery.IDBien.Equals(Bien.IDBIEN));
            Admin.IDUsuario = Admin.IDUsuario;
            Admin.IDBien = Bien.IDBIEN;
            Admin.FECHAADQUISISCION = FechaAdquisicion.Value.Date;
            Admin.FECHACOMPRA = FechaCompra.Value.Date;
            Admin.Costo = Convert.ToDecimal(value: Costo.Text);
            Admin.CANTIDAD = Convert.ToInt32(value: Cantidad.Value);
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
                Cantidad.Value = Convert.ToInt32(value: i.Cantidad);
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
