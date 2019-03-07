using ActivoFijo.Bienes.Bien;
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

namespace ActivoFijo.Bienes.Clasificacion
{
    public partial class Clasificacion : Form
    {
        public string Usuario;
        public Clasificacion(string User)
        {
            InitializeComponent();
            Usuario = User;
        }

        private void Clasificacion_Load(object sender, EventArgs e)
        {
            Tipo.MaxLength = 50;
        }

        private void Tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            TIPO Type = new TIPO();
            activo_fijoEntities activo_FijoEntitiesB = new activo_fijoEntities();
            Type.TIPO1 = Tipo.Text.ToString();
            activo_FijoEntitiesB.TIPOes.Add(Type);
            activo_FijoEntitiesB.SaveChanges();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
