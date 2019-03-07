using System;
using System.Windows.Forms;
using ActivoFijo.Bienes.Bien;
using ActivoFijo.DatabaseModule;

namespace ActivoFijo.Bienes.Marca
{
    public partial class MarcaForm : Form
    {
        public string Usuario;
        public MarcaForm(string User)
        {
            InitializeComponent();
            Usuario = User;
        }
        private void Marcatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marca_Load(object sender, EventArgs e)
        {
            Marcatxt.MaxLength = 50;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            MARCA marca = new MARCA();
            marca.NOMBREMARCA = Marcatxt.Text.ToString();
            activo_fijoEntities activo_FijoEntitiesB = new activo_fijoEntities();
            activo_FijoEntitiesB.MARCAs.Add(marca);
            activo_FijoEntitiesB.SaveChanges();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
