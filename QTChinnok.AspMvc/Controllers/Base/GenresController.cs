#if GENERATEDCODE_ON
global using IGenre = QTChinnok.Logic.Contracts.Base.IGenresAccess;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QTChinnok.AspMvc.Controllers.Base
{
    public class GenresController : Controller
    {
        private readonly IGenre _dataAccess;

        public GenresController(IGenre dataAccess)
        {
            _dataAccess = dataAccess;
        }

        // GET: GenresController
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var entities = await _dataAccess.GetAllAsync();
            var models = entities.Select(e => Models.Base.Genre.Create(e)).ToArray();

            return View(models);
        }

        // GET: GenresController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var entity = await _dataAccess.GetByIdAsync(id);

            return entity == null ? NotFound() : View(Models.Base.Genre.Create(entity));
        }

        // GET: GenresController/Create
        public ActionResult Create()
        {
            var model = new Models.Base.Genre() { Name = string.Empty };

            return View(model);
        }

        // POST: GenresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Models.Base.Genre model)
        {
            try
            {
                var entity = new Logic.Models.Base.Genre() { Name = model.Name };

                await _dataAccess.InsertAsync(entity);
                await _dataAccess.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;

                return View(model);
            }
        }

        // GET: GenresController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var entity = await _dataAccess.GetByIdAsync(id);

            return entity == null ? NotFound() : View(Models.Base.Genre.Create(entity));
        }

        // POST: GenresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Models.Base.Genre model)
        {
            try
            {
                var entity = await _dataAccess.GetByIdAsync(id);

                if (entity != null)
                {
                    entity.Name = model.Name;

                    await _dataAccess.UpdateAsync(entity);
                    await _dataAccess.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }

        // GET: GenresController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var entity = await _dataAccess.GetByIdAsync(id);

            return entity == null ? NotFound() : View(Models.Base.Genre.Create(entity));
        }

        // POST: GenresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Models.Base.Genre model)
        {
            try
            {
                await _dataAccess.DeleteAsync(id);
                await _dataAccess.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}
#endif