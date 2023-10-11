using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace AM.UI.WEB.Controllers
{
    public class BouquetController : Controller
    {
        private readonly IServiceBouquet _serviceBouquet;

        public BouquetController(IServiceBouquet serviceBouquet)
        {
            _serviceBouquet = serviceBouquet;

        }
        // GET: FlightController
        /* public ActionResult Index(DateTime? dateDepart)
         {
             if (dateDepart == null)
             {
                 return View(_flightService.GetAll().ToList());

             }
             return View(_flightService.GetFlightByDate((DateTime)dateDepart));
         }

         // GET: FlightController/Details/5
        
        */

        public ActionResult Details(int id)
        {
            var flight = _serviceBouquet.GetById((int)id);
            if (flight == null)
            {
                return NotFound();
            }
            return View(flight);
        }

       




        /*

        // GET: FlightController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = _flightService.GetById((int)id);
            if (flight == null)
            {
                return NotFound();
            }
            ViewBag.Planes = new SelectList(_planeService.GetAll().ToList(), 
                    "PlaneId", 
                    "Information",
                    flight.PlaneId  
                    );
            return View(flight);
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Flight flight)
        {
            try
            {
                _flightService.Update(flight);
                _flightService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var flight = _flightService.GetById((int)id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                var flight = _flightService.GetById((int)id);
                _flightService.Delete(flight);
                _flightService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    
        */
    }
}
