using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using parte8_Guia_HttpHelper.Models;

namespace parte8_Guia_HttpHelper.Controllers
{
    public class formularioController : Controller
    {
        private readonly parte9_GuiaDbContext contexto;

        public formularioController (parte9_GuiaDbContext _contexto)
        {
            contexto = _contexto;
        }

        public IActionResult Index()
        {
            //Realizando consulta a la base de datos
            var listadoFormulario = (from e in contexto.formulario
                                    select new
                                    {
                                        nombre = e.nombre_usuario,
                                        contrasenia = e.contrasenia,
                                        genero = e.genero,
                                        direccion = e.direccion,
                                        pasatiempo = e.pasatiempo,
                                        cursos = e.cursos,
                                        conocimientos = e.conocimientos
                                    }).ToList();
            ViewData["listadoFormulario"] = listadoFormulario;

            return View();
        }

        public IActionResult CrearFormulario(formulario nuevoFormulario)
        {
            contexto.Add(nuevoFormulario);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
