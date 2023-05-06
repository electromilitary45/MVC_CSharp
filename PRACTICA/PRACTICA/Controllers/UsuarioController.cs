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
        public IActionResult Nuevo()
        {
            return View();
        }

        //------------- VISTA EDITAR USUARIO-------------

        //[Route("/Usuario/Modifica/{id}")] 
        public IActionResult Modifica(int id)
        {
            //String datos = id ;
            //return view ("Modifica", datos);

            ViewData["id"] = id;
            return View();
        }
        //minuto 5:14
    }//fin class UsuarioController
}//fin namespace PRACTICA.Controllers
