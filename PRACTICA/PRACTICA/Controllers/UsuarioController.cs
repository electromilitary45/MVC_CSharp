using Microsoft.AspNetCore.Mvc;

namespace PRACTICA.Controllers
{
    public class UsuarioController : Controller
    {
        //------------- VISTA LSITADO DE USUARIOS--------------
        //peticion para utilizarse
        public IActionResult Listado()
        {
            return View();
        } 

        //------------- VISTA CREAR USUARIO-------------
        public IActionResult Create()
        {
            return View();
        }

        //------------- VISTA EDITAR USUARIO-------------

        public IActionResult Modifica(int id)
        {
            ViewData["id"] = id;
            return View();
        }
        //minuto 5:14
    }//fin class UsuarioController
}//fin namespace PRACTICA.Controllers
