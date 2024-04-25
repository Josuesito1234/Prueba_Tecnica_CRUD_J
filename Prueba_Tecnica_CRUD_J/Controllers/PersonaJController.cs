using Prueba_Tecnica_CRUD_J.BL;
using Prueba_Tecnica_CRUD_J.EN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prueba_Tecnica_CRUD_J.Controllers
{
    public class PersonaJController : Controller
    {
        // GET: PersonaJController
        public async Task<ActionResult> Index()
        {
            var perj = await PersonaJBL.GetAll();
            return View(perj);
        }

        // GET: PersonaJController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var use = await PersonaJBL.GetById(id);
            return View(use);
        }

        // GET: PersonaJController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaJController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaJ personaj)
        {
            try
            {
                var perj = await PersonaJBL.Create(personaj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaJController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var perj = await PersonaJBL.GetById(id);
            return View(perj);
        }

        // POST: PersonaJController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaJ personaj)
        {
            try
            {
                var perj = await PersonaJBL.Update(personaj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaJController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var perj = await PersonaJBL.GetById(id);
            return View(perj);
        }

        // POST: PersonaJController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(PersonaJ personaj)
        {
            try
            {
                var perj = await PersonaJBL.Delete(personaj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
