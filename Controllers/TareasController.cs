using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mantencion.Models;

namespace Mantencion.Controllers
{
    public class TareasController : Controller
    {
        TareasDataAccessLayer tareasDataAccessLayer = null;
        public TareasController()
        {
            tareasDataAccessLayer = new TareasDataAccessLayer();
        }
        public IActionResult Index()
        {
            IEnumerable<Tareas> tareas = tareasDataAccessLayer.ObtenerTodasLasTareas(System.DateTime.Now, 1);
            return PartialView(tareas);
        }

        [HttpPost]
        public IActionResult Datos(DateTime fecha, int turno)
        {
            IEnumerable<Tareas> tareas = tareasDataAccessLayer.ObtenerTodasLasTareas(fecha, turno);
            if (tareas.Count() == 0)
            {
                return PartialView("Datos", tareas);
            }
            else
            {
                Mantencion.Models.Tareas.Fecha = fecha;
                Mantencion.Models.Tareas.Id_turno = turno;
                return PartialView("Datos", tareas);
            }
            
        }

        public IActionResult ModalAction(int id)
        {
            Tareas tarea = tareasDataAccessLayer.ObtenerTarea(id);
            return View("Editar", tarea);
        }

        public IActionResult ModalCreate()
        {
            return PartialView("Crear");
        }

        public ActionResult Detalle(int id)
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Tareas tarea)
        {
            try
            {
                tarea.id_usuario = HttpContext.Session.GetString("Usuario");
                tareasDataAccessLayer.Agregar_Tarea(tarea);
                IEnumerable<Tareas> tareas = tareasDataAccessLayer.ObtenerTodasLasTareas(tarea.fecha, tarea.id_turno);
                return PartialView("Datos", tareas);
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Editar(Tareas tarea)
        {
            if (Mantencion.Models.Tareas.Id_turno == 0)
            {
                tarea.id_usuario = HttpContext.Session.GetString("Usuario");
                tareasDataAccessLayer.Editar_Tarea(tarea);
                IEnumerable<Tareas> tareas = tareasDataAccessLayer.ObtenerTodasLasTareas(System.DateTime.Now, 1);
                return PartialView("Datos", tareas);
            }
            else
            {
                tarea.id_usuario = HttpContext.Session.GetString("Usuario");
                tareasDataAccessLayer.Editar_Tarea(tarea);
                IEnumerable<Tareas> tareas = tareasDataAccessLayer.ObtenerTodasLasTareas(Mantencion.Models.Tareas.Fecha, Mantencion.Models.Tareas.Id_turno);
                return PartialView("Datos", tareas);
            }
        }

        
    }
}
