using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mantencion.Models
{
    public class Tareas
    {
        public int id_registro { set; get; }
        [Required]
        public DateTime fecha { set; get;}
        
        [Required]
        public int id_turno { set; get; }
        [Required]
        public string actividad { set; get; }
        [Required]
        public bool log_terminado { set; get; }
        [Required]
        public string id_usuario { set; get; }
        [Required]
        public DateTime fec_registro { get; set; }
        public static DateTime Fecha { get => _fecha; set => _fecha = value; }
        public static int Id_turno { get => _id_turno; set => _id_turno = value; }

        private static DateTime _fecha;
        private static int _id_turno;
    }
}
