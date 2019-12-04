using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZdAdoConnectorMvc.Models;
using ZdAdoConnectorMvc.Providers;

namespace ZdAdoConnectorMvc.Controllers
{
    public class WorkItemController : Controller
    {
        private readonly AdoProvider _adoProvider;

        public WorkItemController(AdoProvider adoProvider) => _adoProvider = adoProvider;

        // GET: WorkItem/Create
        public ActionResult Create() => View();

        // POST: WorkItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkItem/Delete/5
        public ActionResult Delete(int id) => View();

        // POST: WorkItem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkItem/Details/5
        public ActionResult Details(int id = 1) // TESTING !!!!!!!
        {
            List<AdoWorkItem> adoWorkItems = _adoProvider.GetWorkItems(new int[] { id });

            AdoWorkItem adoWorkItem = adoWorkItems.ToArray()[0];

            return View(adoWorkItem);
        }

        // GET: WorkItem/Edit/5
        public ActionResult Edit(int id) => View();

        // POST: WorkItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkItem
        public ActionResult Index() => View();
    }
}