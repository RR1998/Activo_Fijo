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
            public override string ToString() =>
                // Generates the text shown in the combo box
                Name;
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
            UsuarioAux.IDUSUARIO = Convert.ToInt32(value: activo_FijoEntities.USUARIOs.Where(User => User.USUARIO1 == Usuario).Select(User => User.IDUSUARIO).First());
            tp.SetToolTip(Opciones, "Seleccione la opcion que desea utilizar y luego presione el boton aceptar");
            NombreUsuario.Text = Usuario;//puede cambiar para ser el nombre real del usuario o sol oel username
            NUsuario.Text = UsuarioAux.IDUSUARIO.ToString();
            switch (Usuario)
            {
                case ("CBRC Contabilidad"):
                    Opciones.Items.Add(new Item(name: "Ver depreciacion", value: 1));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Bienes", value: 2));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Clasificacion de bienes", value: 3));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Marca", value: 4));//Hecho
                    Opciones.Items.Add(new Item(name: "Actualizar Bien", value: 5));//Hecho
                    break;
                case ("CBRC Administrador"):
                    //Opciones.Items.Add(new Item("Ver activo fijo por producto", 1));
                    Opciones.Items.Add(new Item(name: "Ver Activo fijo por clasificacion", value: 1));
                    Opciones.Items.Add(new Item(name: "Ver depeciacion por periodos", value: 2));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Bienes", value: 3));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Clasificacion de bienes", value: 4));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Marca", value: 5));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Usuario", value: 6));
                    Opciones.Items.Add(new Item(name: "Actualizar Bien", value: 7));//Hecho
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
                    Opciones.Items.Add(new Item(name: "Ver Activo fijo por clasificacion", value: 1));
                    Opciones.Items.Add(new Item(name: "Ver depeciacion por periodos", value: 2));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Bienes", value: 3));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Clasificacion de bienes", value: 4));//Hecho
                    Opciones.Items.Add(new Item(name: "Agregar Marca", value: 5));//Hecho
                    break;
                default://falta terminar
                    Opciones.Items.Add(new Item(name: "Ver activo fijo por producto", value: 1));
                    Opciones.Items.Add(new Item(name: "Ver Activo fijo por clasificacion", value: 2));
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
            string Opc = "";
            try
            {
                Opc = Opcion.Name.ToString();
            }
            catch (Exception)
            {
                Opc = "";
            }
            string Usuario = NombreUsuario.Text.ToString();
            switch (Opc)
            {
                case "Ver depreciacion":
                    this.Hide();
                    ActivoFijoCalculator activoFijoCalc = new ActivoFijoCalculator(User: Usuario);
                    activoFijoCalc.Show();
                    break;
                case "Agregar Bienes":
                    this.Hide();
                    BienRegister bien = new BienRegister(User: Usuario);
                    bien.Bien_Load();
                    bien.Show();
                    break;
                case "Agregar Clasificacion de bienes":
                    this.Hide();
                    Clasificacion clasificacion = new Clasificacion(User: Usuario);
                    clasificacion.Show();
                    this.Show();
                    break;
                case "Agregar Marca":
                    this.Hide();
                    MarcaForm marca = new MarcaForm(User: Usuario);
                    marca.Show();
                    this.Show();
                    break;
                case "Agregar Usuario":
                    this.Hide();
                    Registro registro = new Registro(User: Usuario);
                    registro.Show();
                    break;
                case "Actualizar Bien":
                    this.Hide();
                    CambioBien cambioBien = new CambioBien(User: Usuario);
                    cambioBien.Show();
                    break;
                default:
                    MessageBox.Show(text: "Por favor seleccione una opcion", caption: "Advertencia", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    break;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e) => Close();

        private void Ayuda_Click(object sender, EventArgs e)
        {


        }

        private void MainMenu_Load()
        {

        }
    }
}


