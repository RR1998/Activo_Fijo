using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ActivoFijo.DatabaseModule;

namespace ActivoFijo.Login_and_Register
{
    public partial class Registro : Form
    {
        public string Usuario;

        public Registro(string User)
        {
            InitializeComponent();
            Usuario = User;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            ToolTip Ayudatp = new ToolTip();
            Nombre.MaxLength = 100;
            DUI.MaxLength = 10;
            User.MaxLength = 25;
            Password.MaxLength = 15;
            Password.PasswordChar = '*';
            Ayudatp.AutoPopDelay = 2000;
            Ayudatp.InitialDelay = 1000;
            Ayudatp.ReshowDelay = 500;
            Ayudatp.SetToolTip(User, "Ingrese el nombre de usuario que desea usar");
            Ayudatp.SetToolTip(Nombre, "Ingrese su nombre completo");
            Ayudatp.SetToolTip(DUI, "Ingrese su DUI con guion");
            Ayudatp.SetToolTip(Password, "Ingrese la contraseña que desea utilizar en su usuario recuerde que no debe sobrepasar los 15 caracteres");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void DUI_TextChanged(object sender, EventArgs e)
        {
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            string Nombretxt, DUItxt, Usertxt, Passwordtxt;
            int cont = 9;
            int Validar = 0;
            Nombretxt = Nombre.Text;
            DUItxt = DUI.Text;
            Usertxt = User.Text;
            Passwordtxt = Password.Text;
            char[] DUIchar = DUItxt.ToCharArray(0, 10);
            while (cont > 1)
            {
                string AuxS = DUIchar[9 - cont].ToString();
                int Aux = Convert.ToInt32(AuxS);
                Validar += cont * Aux;
                cont--;
            }
            Validar = Validar % 10;
            Validar = 10 - Validar;
            if(Validar == DUIchar[9])
            {
                activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
                if (Usertxt == activo_FijoEntities.USUARIOs.Where(UsuarioQuery => UsuarioQuery.USUARIO1 == Usertxt).First().ToString())
                {
                    MessageBox.Show("Este usuario ya esta registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario registrado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Registrar(Nombretxt, DUItxt, Usertxt, Passwordtxt);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un dui valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainMenu M = new MainMenu();
            M.MainMenu_Load(Usuario);
            this.Hide();
        }

        private void Ayuda_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("1.Ingrese su nombre completo \n" +
                "2. Ingrese su DUI, con el guion \n" +
                "3. Ingrese el Usuario que utilizara, no debe contener caracteres especiales como '!, @, #, $, %, ^, &, *, (, ), [, ], {, }, /, |, comillas dobles o simples \n'" +
                ":, ;, <, >, ., ? " +
                "4. Ingrese su contrasena, no debe tener mas de 15 caracteres, Ejemplo de contrasena: Contrasena1@#$| \n" +
                "si usted desea ingresar todos los datos presione el boton de aceptar, si quiere regresar al menu inicial precione cancelar", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void Registrar(string Nombre, string DUI, string User, string Password)
        {
            try
            {
                Regex regexItem = new Regex(@"[^\w\d\s]");
                Match MR = regexItem.Match(User);
                if (!MR.Success)
                {
                    USUARIO usuario = new USUARIO();
                    activo_fijoEntities activo_FijoEntitiesB = new activo_fijoEntities();
                    usuario.Nombre = Nombre;
                    usuario.DUI = DUI;
                    usuario.USUARIO1 = User;
                    usuario.CLAVE = Password;
                    activo_FijoEntitiesB.USUARIOs.Add(usuario);
                    activo_FijoEntitiesB.SaveChanges();
                    MessageBox.Show("El usuario ha sido registrado con exito", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MainMenu M = new MainMenu();
                    M.MainMenu_Load(Usuario);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Su nombre de usuario no debe poseer ninguno de los siguientes caracteres: !@#$%^&*()_-+={}[]|\'';:?/>.<,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Ha ingresado mal sus datos por favor corrobore que esten bien escritos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(User);
            }
        }
    }
}
