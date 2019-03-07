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

namespace ActivoFijo.Login_and_Register.AlterarUsuario
{
    public partial class AlterarUsuario : Form
    {
        public string UsuarioMain;
        public AlterarUsuario(string User)
        {
            InitializeComponent();
            UsuarioMain = User;
        }

        private void AlterarUsuario_Load(object sender, EventArgs e)
        {
            Nombre.MaxLength = 100;
            DUI.MaxLength = 10;
            User.MaxLength = 25;
            Password.MaxLength = 15;
            Password.PasswordChar = '*';
            Acciones.Items.Add("Actualizar Usuario");
            Acciones.Items.Add("Eliminar Usuario");
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            var entryPoint = (from Usuarios in activo_FijoEntities.USUARIOs
                             orderby Usuarios.IDUSUARIO ascending
                             select new
                             {
                                 IDUsuarios = Usuarios.IDUSUARIO,
                                 NombreUsuario = Usuarios.USUARIO1,
                                 Contraseña = Usuarios.CLAVE,
                                 NombrePropietario = Usuarios.Nombre,
                                 DUIPropietario = Usuarios.DUI
                             }).ToList();
            DatabaseDisplay.DataSource = entryPoint.ToList();
            DatabaseDisplay.Refresh();
            foreach (var i in entryPoint)
            {
                IDUsuario.Items.Add(i.IDUsuarios);
            }
            entryPoint.Clear();
        }

        private void IDUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(value: IDUsuario.Text);
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            var entryPoint = (from Usuarios in activo_FijoEntities.USUARIOs
                              where Usuarios.IDUSUARIO == ID
                              orderby Usuarios.IDUSUARIO ascending
                              select new
                              {
                                  IDUsuarios = Usuarios.IDUSUARIO,
                                  NombreUsuario = Usuarios.USUARIO1,
                                  Contraseña = Usuarios.CLAVE,
                                  NombrePropietario = Usuarios.Nombre,
                                  DUIPropietario = Usuarios.DUI
                              }).ToList();
            foreach (var i in entryPoint)
            {
                User.Text = i.NombreUsuario;
                Password.Text = i.Contraseña;
                DUI.Text = i.DUIPropietario;
                Nombre.Text = i.NombrePropietario;
            }
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainMenu_Load(Usuario: UsuarioMain);
            mainMenu.Show();
            this.Close();
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.MainMenu_Load(Usuario: UsuarioMain);
            mainMenu.Show();
            this.Close();
        }

        private void RealizarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(IDUsuario.Text);
                switch (Acciones.Text)
                {
                    case ("Actualizar Usuario"):
                        UpdateUser(ID);
                        break;
                    case ("Eliminar Usuario"):
                        DeleteUser(ID);
                        break;
                    default:
                        MessageBox.Show("Por favor escoja una opcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor escoja un numero de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteUser(int ID)
        {
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
        }
        private void UpdateUser(int ID)
        {
            activo_fijoEntities activo_FijoEntities = new activo_fijoEntities();
            USUARIO Usuario = activo_FijoEntities.USUARIOs.FirstOrDefault(U => U.IDUSUARIO.Equals(ID));
            Usuario.IDUSUARIO = ID;
            Usuario.USUARIO1 = User.Text;
            Usuario.CLAVE = Password.Text;
            Usuario.Nombre = Nombre.Text;
            Usuario.DUI = DUI.Text;
            activo_FijoEntities.SaveChanges();
            UsersQuery(ID, activo_FijoEntities);
        }

        private void UsersQuery(int ID, activo_fijoEntities activo_FijoEntities)
        {
            var entryPoint = (from Usuarios in activo_FijoEntities.USUARIOs
                              where Usuarios.IDUSUARIO == ID
                              orderby Usuarios.IDUSUARIO ascending
                              select new
                              {
                                  IDUsuarios = Usuarios.IDUSUARIO,
                                  NombreUsuario = Usuarios.USUARIO1,
                                  Contraseña = Usuarios.CLAVE,
                                  NombrePropietario = Usuarios.Nombre,
                                  DUIPropietario = Usuarios.DUI
                              }).ToList();
            DatabaseDisplay.DataSource = entryPoint.ToList();
            DatabaseDisplay.Refresh();
        }
    }
}
