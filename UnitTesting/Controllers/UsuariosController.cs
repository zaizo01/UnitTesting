using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTesting.Models;

namespace UnitTesting.Controllers
{
    public class UsuariosController : Controller
    {
        public List<Usuario> GetUsuarios()
        {

            List<Usuario> Usuarios = new List<Usuario> {
            new Usuario { IdUser = 1,
            Name = "Juan",
            lastname = "Perez",
            password = "1234",
            date = DateTime.Parse(DateTime.Now.ToLongDateString())
            },

            new Usuario { IdUser = 2,
            Name = "Pedro",
            lastname = "Guzman",
            password = "1234",
            date = DateTime.Parse(DateTime.Now.ToLongDateString())
            },

            new Usuario { IdUser = 2,
            Name = "Mario",
            lastname = "Alvarez",
            password = "1234",
            date = DateTime.Parse(DateTime.Now.ToLongDateString())
            }
 
            };
            return Usuarios;
        }
    

    public ActionResult ModeloUsuarios() {

        List<Usuario> Usuarios = GetUsuarios();
        return View(Usuarios);
    
        }

        public ActionResult ListaUsuarios() {
            List<Usuario> Usuarios = GetUsuarios();
            ViewBag.Usuarios = Usuarios;
            return View();
        }

        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(String name, String pass)
        {
            List<Usuario> Usuarios = GetUsuarios();
            if (name != null && pass != null) { 
                foreach(Usuario user in Usuarios)
                {
                    if (user.Name == name && user.password == pass) return RedirectToAction("ModeloUsuarios","Usuarios");
                }
            }
            ViewBag.Mensaje = "Datos no correcto";
            return RedirectToAction("Login", "Usuarios");
        }
    }

}
