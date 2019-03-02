using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivoFijo.AuxiliaryClasses
{
    class ConsultaConvertida
    {
        public int NumeroBienAsignado { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Estado { get; set; }
        public string Clasificacion { get; set; }
        public DateTime? FechaDeAdquisicion { get; set; }
        public DateTime? FechaCompra { get; set; }
        public string Costo { get; set; }
        public string PorcentajeDepreciacion { get; set; }
        public DateTime FechaFinConsulta { get; set; }
        public string DepreciacionAcumulada { get; set; }
        public string ValorDepreciadoFecha { get; set; }
        public int? Cantidad { get; set; }
    }
}
