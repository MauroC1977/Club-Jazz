using jazzclub.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace jazzclub.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
            
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            mantenimientousuario ma = new mantenimientousuario();
            usuario usu = new usuario
            {
                nombre = collection["nombre"],
                celular = collection["celular"],
                email = collection["email"],
                ciudad = collection["ciudad"],
                fecharegistro = collection["fecharegistro"]
            };
            if (ModelState.IsValid)
                return View("Exito");
            else
                return View("Index");
            ma.Alta(usu);
            return RedirectToAction("Registro");
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            mantenimientousuario ma = new mantenimientousuario();
            usuario usu = ma.Recuperar(id);
            return View(usu);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        
       

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            mantenimientousuario ma = new mantenimientousuario();
            usuario usu = ma.Recuperar(id);
            return View(usu);
            
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            mantenimientousuario ma = new mantenimientousuario();
            usuario usu = new usuario
            {   ID = id,
                nombre = collection["nombre"].ToString(),
                celular = collection["celular"].ToString(),
                email = collection["email"].ToString(),
                ciudad = collection["ciudad"].ToString(),
                fecharegistro = collection["fecharegistro"].ToString()
            };
            ma.Modificar(usu);
            return RedirectToAction("Index");
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            mantenimientousuario ma = new mantenimientousuario();
            usuario usu = ma.Recuperar(id);
            return View(usu);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            
            {
                mantenimientousuario ma = new mantenimientousuario();
                ma.Borrar(id);
                return RedirectToAction("Index");
            }
        }
    }
}
