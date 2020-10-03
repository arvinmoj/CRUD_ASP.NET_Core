using System;
using CRUD.Models;
using System.Linq;
using CRUD.Database;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUD.Controllers
{
    public class CRUDController : Controller
    {
        private readonly CRUDdatabaseContext _databaseContext;

        public CRUDController(CRUDdatabaseContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var displaydata = _databaseContext.Datas.ToList();

            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create (Data data)
        {

            if (ModelState.IsValid)
            {
                _databaseContext.Add(data);
                await _databaseContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var details = await _databaseContext.Datas.FindAsync(id);

            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Data data) 
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Update(data);
                await _databaseContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var details = await _databaseContext.Datas.FindAsync(id);

            return View(details);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var details = await _databaseContext.Datas.FindAsync(id);

            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var details = await _databaseContext.Datas.FindAsync(id);
            _databaseContext.Datas.Remove(details);
            await _databaseContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
