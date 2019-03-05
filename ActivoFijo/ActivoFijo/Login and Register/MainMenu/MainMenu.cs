using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ActivoFijo.DatabaseModule;
using ActivoFijo.Bienes.Bien;
using ActivoFijo.Bienes.Marca;
using ActivoFijo.Bienes.Clasificacion;
using ActivoFijo.ActivoFijoCalc;
using ActivoFijo.Bienes.NuevoBien;

namespace ActivoFijo.Login_and_Register
{
    public partial class MainMenu : Form
    {
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        public void MainMenu_Load(string Usuario)
        {
            ToolTip tp = new ToolTip();
            USUARIO UsuarioAux = new USUARIO();
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            tp.AutoPopDelay = 2000;
            tp.InitialDelay = 1000;
            tp.ReshowDelay = 500;
            UsuarioAux.IDUSUARIO = Convert.ToInt32(activo_FijoEntities.USUARIOs.Where(User => User.USUARIO1 == Usuario).Select(User => User.IDUSUARIO).First());
            tp.SetToolTip(Opciones, "Seleccione la opcion que desea utilizar y luego presione el boton aceptar");
            NombreUsuario.Text = Usuario;//puede cambiar para ser el nombre real del usuario o sol oel username
            NUsuario.Text = UsuarioAux.IDUSUARIO.ToString();
            switch (Usuario)
            {
                case ("CBRC Contabilidad"):
                    Opciones.Items.Add(new Item("Ver depreciacion", 1));//Hecho
                    Opciones.Items.Add(new Item("Agregar Bienes", 2));//Hecho
                    Opciones.Items.Add(new Item("Agregar Clasificacion de bienes", 3));//Hecho
                    Opciones.Items.Add(new Item("Agregar Marca", 4));//Hecho
                    Opciones.Items.Add(new Item("Actualizar Bien", 5));//Hecho
                    break;
                case ("CBRC Administrador"):
                    //Opciones.Items.Add(new Item("Ver activo fijo por producto", 1));
                    Opciones.Items.Add(new Item("Ver Activo fijo por clasificacion", 1));
                    Opciones.Items.Add(new Item("Ver depeciacion por periodos", 2));//Hecho
                    Opciones.Items.Add(new Item("Agregar Bienes", 3));//Hecho
                    Opciones.Items.Add(new Item("Agregar Clasificacion de bienes", 4));//Hecho
                    Opciones.Items.Add(new Item("Agregar Marca", 5));//Hecho
                    Opciones.Items.Add(new Item("Agregar Usuario", 6));
                    Opciones.Items.Add(new Item("Actualizar Bien", 7));//Hecho
                    break;
                case ("CBRB Taller"):
                    //Opciones.Items.Add(new Item("Ver activo fijo por producto", 1));
                    Opciones.Items.Add(new Item("Ver Activo fijo por clasificacion", 1));
                    Opciones.Items.Add(new Item("Ver depeciacion por periodos", 2));//Hecho
                    Opciones.Items.Add(new Item("Agregar Bienes", 3));//Hecho
                    Opciones.Items.Add(new Item("Agregar Clasificacion de bienes", 4));//Hecho
                    Opciones.Items.Add(new Item("Agregar Marca", 5));//Hecho
                    break;
                case ("CBRC SuperUsuario"):
                    //Opciones.Items.Add(new Item("Ver activo fijo por producto", 1));
                    Opciones.Items.Add(new Item("Ver Activo fijo por clasificacion", 1));
                    Opciones.Items.Add(new Item("Ver depeciacion por periodos", 2));//Hecho
                    Opciones.Items.Add(new Item("Agregar Bienes", 3));//Hecho
                    Opciones.Items.Add(new Item("Agregar Clasificacion de bienes", 4));//Hecho
                    Opciones.Items.Add(new Item("Agregar Marca", 5));//Hecho
                    break;
                default://falta terminar
                    Opciones.Items.Add(new Item("Ver activo fijo por producto", 1));
                    Opciones.Items.Add(new Item("Ver Activo fijo por clasificacion", 2));
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Item Opcion = (Item)Opciones.SelectedItem;
            string Opc = Opcion.Name.ToString();
            string Usuario = NombreUsuario.Text.ToString();
            switch (Opc)
            {
                case "Ver depreciacion":/*Falta Funcionalidad*/
                    this.Hide();
                    ActivoFijoCalculator activoFijoCalc = new ActivoFijoCalculator(Usuario);
                    activoFijoCalc.Show();
                    break;
                case "Agregar Bienes":
                    this.Hide();
                    BienRegister bien = new BienRegister(Usuario);/*Falta Funcionalidad*/
                    bien.Bien_Load();
                    bien.Show();
                    break;
                case "Agregar Clasificacion de bienes":
                    this.Hide();
                    Clasificacion clasificacion = new Clasificacion(Usuario);
                    clasificacion.Show();
                    this.Show();
                    break;
                case "Agregar Marca":
                    this.Hide();
                    MarcaForm marca = new MarcaForm(Usuario);
                    marca.Show();
                    this.Show();
                    break;
                case "Agregar Usuario":
                    this.Hide();
                    Registro registro = new Registro(Usuario);
                    registro.Show();
                    this.Show();
                    break;
                case "Actualizar Bien":
                    this.Hide();
                    CambioBien cambioBien = new CambioBien(Usuario);
                    cambioBien.Show();
                    this.Show();
                    break;
                default:
                    MessageBox.Show("Por favor seleccione una opcion", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {


        }

        private void MainMenu_Load()
        {

        }
    }
}


