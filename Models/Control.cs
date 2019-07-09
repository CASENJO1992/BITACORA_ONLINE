using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mantencion.Models
{
    public class Control
    {
        public int id_registro { set; get; }
        public DateTime fecha { set; get; }
        public int id_turno { set; get; }
        public int id_tipo_consumo { set; get; }
        public int consumo_entrada { set; get; }
        public int consumo_salida { set; get; }
        public int consumo_total { get; set; }
        public string id_usuario { set; get; }
        public DateTime fec_registro { set; get; }
        public static DateTime Fecha { get => _fecha; set => _fecha = value; }
        public static int Id_turno { get => _id_turno; set => _id_turno = value; }
        public static int Tipo_consumo { get => _tipo_consumo; set => _tipo_consumo = value; }

        private static DateTime _fecha;
        private static int _id_turno;
        private static int _tipo_consumo;
    }
}
