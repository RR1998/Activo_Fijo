using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ActivoFijo.DatabaseModule;

namespace ActivoFijo.Login_and_Register
{
    public partial class Login : Form
    {
        public static Boolean accessed;
        public static String name;
        public static int user_id;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("No debe dejar ningun campo vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                USUARIO Usuario = new USUARIO();
                USUARIO UsuarioAux = new USUARIO();
                activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
                Usuario.USUARIO1 = username.Text;
                Usuario.CLAVE = password.Text;
                try
                {
                    UsuarioAux.USUARIO1 = activo_FijoEntities.USUARIOs.Where(predicate: User => User.USUARIO1 == Usuario.USUARIO1).Where(User => User.CLAVE == Usuario.CLAVE).Select(User => User.USUARIO1).First().ToString();
                    UsuarioAux.CLAVE = activo_FijoEntities.USUARIOs.Where(predicate: User => User.USUARIO1 == Usuario.USUARIO1).Where(User => User.CLAVE == Usuario.CLAVE).Select(User => User.CLAVE).First().ToString();
                    if (UsuarioAux.USUARIO1 != "" && UsuarioAux.CLAVE != "" || UsuarioAux.USUARIO1 != "null" && UsuarioAux.CLAVE != "null")
                    {
                        MainMenu menu = new MainMenu();
                        menu.MainMenu_Load(username.Text);
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos, por favor ingreselos otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Usuario o contraseña no registrados, por favor revise sus datos", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Ingrese su usuario \n" +
                "2. Ingrese su contraseña \n" +
                "Si usted no posee usuario por favor presione el boton de registrar \n" +
                "Si usted desea salir presione cancelar \n", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            username.MaxLength = 25;
            password.PasswordChar = '*';
            password.MaxLength = 11;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

