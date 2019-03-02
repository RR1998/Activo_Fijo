using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivoFijo.AuxiliaryClasses
{
    class ConsultaDepreciacion
    {
        public int NumeroBienAsignado { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Estado { get; set; }
        public string Clasificacion { get; set; }
        public DateTime? FechaDeAdquisicion { get; set; }
        public DateTime? FechaCompra { get; set; }
        public decimal Costo { get; set; }
        public decimal PorcentajeDepreciacion { get; set; }
        public DateTime FechaFinConsulta { get; set; }
        public decimal DepreciacionAcumulada { get; set; }
        public decimal ValorDepreciadoFecha { get; set; }
        public int? Cantidad { get; set; }
    }
}
