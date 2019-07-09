using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mantencion.Models;
using Microsoft.AspNetCore.Http;

namespace Mantencion.Controllers
{
    public class ControlController : Controller
    {
        ControlDataAccessLayer controlDataAccessLayer = null;
        public ControlController()
        {
            controlDataAccessLayer = new ControlDataAccessLayer();
        }
        public IActionResult Index()
        {
            IEnumerable<Control> control = controlDataAccessLayer.ObtenerTodosLosConsumos(System.DateTime.Now, 1,1);
            return PartialView(control);
        }

        [HttpPost]
        public IActionResult Datos(DateTime fecha, int turno, int tipo_consumo)
        {
            IEnumerable<Control> control = controlDataAccessLayer.ObtenerTodosLosConsumos(fecha, turno,tipo_consumo);
            if (control.Count() == 0)
            {
                return PartialView("Datos", control);
            }
            else
            {
                Mantencion.Models.Control.Fecha = fecha;
                Mantencion.Models.Control.Id_turno = turno;
                Mantencion.Models.Control.Tipo_consumo = tipo_consumo;
                return PartialView("Datos", control);
            }
        }

        public IActionResult ModalAction(int id)
        {
            Control control = controlDataAccessLayer.ObtenerControl(id);
            return View("Editar", control);
        }

        public IActionResult ModalCreate()
        {
            return PartialView("Crear");
        }

        [HttpPost]
        public IActionResult Crear(Control co)
        {
            try
            {
                co.id_usuario = HttpContext.Session.GetString("Usuario");
                controlDataAccessLayer.Agregar_Control(co);
                IEnumerable<Control> control = controlDataAccessLayer.ObtenerTodosLosConsumos(co.fecha, co.id_turno, co.id_tipo_consumo);
                return PartialView("Datos", control);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Editar(Control co)
        {
            if (Mantencion.Models.Control.Id_turno == 0)
            {
                co.id_usuario = HttpContext.Session.GetString("Usuario");
                controlDataAccessLayer.Editar_Control(co);
                IEnumerable<Control> control = controlDataAccessLayer.ObtenerTodosLosConsumos(System.DateTime.Now, 1, 1);
                return PartialView("Datos", control);
            }
            else
            {
                co.id_usuario = HttpContext.Session.GetString("SessionUsuario");
                controlDataAccessLayer.Editar_Control(co);
                IEnumerable<Control> control = controlDataAccessLayer.ObtenerTodosLosConsumos(Mantencion.Models.Control.Fecha, Mantencion.Models.Control.Id_turno, Mantencion.Models.Control.Tipo_consumo);
                return PartialView("Datos", control);
            }
        }
    }
}
