using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivoFijo.DatabaseModule;
using ActivoFijo.Login_and_Register;
using ActivoFijo.AuxiliaryClasses;
using System.Data.SqlClient;

namespace ActivoFijo.Bienes.Bien
{
    public partial class BienRegister : Form
    {
        public string Usuario;
        public BienRegister(string User)
        {
            InitializeComponent();
            Usuario = User;
        }

        public void Bien_Load()
        {
            UserNameLabel.Text = Usuario;
            USUARIO UsuarioAux = new USUARIO();
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            UsuarioAux.IDUSUARIO = Convert.ToInt32(value: activo_FijoEntities.USUARIOs.Where(User => User.USUARIO1 == Usuario).Select(User => User.IDUSUARIO).First());
            MarcaCombo.DataSource = activo_FijoEntities.MARCAs.ToList();
            MarcaCombo.ValueMember = "IDMARCA";
            MarcaCombo.DisplayMember = "NOMBREMARCA";
            TipoCombo.DataSource = activo_FijoEntities.TIPOes.ToList();
            TipoCombo.ValueMember = "IDTIPO";
            TipoCombo.DisplayMember = "TIPO1";//Corregir para que de el texto del tipo y no el ID
            EstadoCombobox.Items.Add("Usado");
            EstadoCombobox.Items.Add("Nuevo");
            try
            {
                IDAsignado.Text = (Convert.ToInt32(value: activo_FijoEntities.BIENs.Max(selector: Bien => Bien.IDBIEN)) + 1).ToString();
            }
            catch (Exception e)
            {
                IDAsignado.Text = "1";
            }
            IDLabel.Text = UsuarioAux.IDUSUARIO.ToString();
            Color.MaxLength = 10;
            Descripcion.MaxLength = 100;
        }

        private void AgregarClasificacion_Click(object sender, EventArgs e)
        {
            Clasificacion.Clasificacion clasificacion = new Clasificacion.Clasificacion(User: Usuario);
            clasificacion.Show();
        }

        private void AgregarMarca_Click(object sender, EventArgs e)
        {
            Marca.MarcaForm marca = new Marca.MarcaForm(User: Usuario);
            marca.Show();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            BIEN bien = new BIEN();
            ADMINISTRAR administrar = new ADMINISTRAR();
            activo_fijoEntities activo_FijoEntitiesB = new activo_fijoEntities();
            string Marca = MarcaCombo.Text;
            string Tipo = TipoCombo.Text;
            try
            {
                bien.IDASIGNADO = Convert.ToInt32(value: IDAsignado.Text);
            }
            catch(Exception)
            {
                MessageBox.Show(text: "Por favor no ingrese letras o caracteres especiales en campos de numeros", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            bien.NOMBRE = Descripcion.Text.ToString();
            bien.COLOR = Color.Text.ToString();
            bien.IDMARCA = Convert.ToInt32(value: activo_FijoEntitiesB.MARCAs.Where(M => M.NOMBREMARCA == Marca).Select(M => M.IDMARCA).First().ToString());
            bien.IDTIPO = Convert.ToInt32(value: activo_FijoEntitiesB.TIPOes.Where(T => T.TIPO1 == Tipo).Select(T => T.IDTIPO).First().ToString());
            bien.PORCENTAGEDEPRECIACION = decimal.Parse(s: VidaUtil.Text, provider: CultureInfo.InvariantCulture.NumberFormat);
            bien.VIDAUTIL = Convert.ToInt32(value: VidaUtil.Text);
            //sacar vida util y estado
            bien.IDESTADO = -1;
            if (EstadoCombobox.Text == "Nuevo")
            {
                bien.IDESTADO = 1;
                bien.PORCENTAGEDEPRECIACION = Convert.ToInt32(value: Porcentaje.ShowDialog());
            }
            if (EstadoCombobox.Text == "Usado")
            {
                bien.IDESTADO = 2;
                switch (Convert.ToInt32(value: VidaUtil.Text))
                {
                    case (1):
                        bien.PORCENTAGEDEPRECIACION = 80;
                        break;
                    case (2):
                        bien.PORCENTAGEDEPRECIACION = 60;
                        break;
                    case (3):
                        bien.PORCENTAGEDEPRECIACION = 40;
                        break;
                    case (4):
                        bien.PORCENTAGEDEPRECIACION = 20;
                        break;
                    default:
                        bien.PORCENTAGEDEPRECIACION = 20;
                        break;
                }
            }
            activo_FijoEntitiesB.BIENs.Add(entity: bien);
            activo_FijoEntitiesB.SaveChanges();//FALTA PONER EL CATCH PARA CUANDO NO EXISTEN LAS MARCAS O LOS TIPOS
            administrar.IDUsuario = Convert.ToInt32(value: IDLabel.Text.ToString());
            administrar.IDBien = Convert.ToInt32(value: activo_FijoEntitiesB.BIENs.Max(b => b.IDBIEN));
            administrar.FECHAADQUISISCION = FechaAdquisision.Value.Date;
            administrar.FECHACOMPRA = FechaCompra.Value.Date;
            try
            {
                administrar.Costo = decimal.Parse(s: Costo.Text.ToString(), provider: CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show(text: "Por favor no ingrese letras o caracteres especiales, solo numeros", caption: "Advertencia", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
            }
            try
            {
                administrar.CANTIDAD = Convert.ToInt32(value: Cantidad.Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(text: "Ingrese solo numeros enteros por favor", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
            }
            activo_FijoEntitiesB.ADMINISTRARs.Add(entity: administrar);
            activo_FijoEntitiesB.SaveChanges();
            MessageBox.Show(text: "Bien ingresado con exito", caption: "Message", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            Login_and_Register.MainMenu mainMenu = new Login_and_Register.MainMenu();
            mainMenu.MainMenu_Load(Usuario: Usuario);
            mainMenu.Show();
            this.Close();
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Login_and_Register.MainMenu mainMenu = new Login_and_Register.MainMenu();
            mainMenu.MainMenu_Load(Usuario: Usuario);
            mainMenu.Show();
            this.Close();
        }

        private void IDNumeroIdentificador_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IDTipo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDMarca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PorcentageDepreciacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Costo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FechaCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MarcaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
