using Microsoft.AspNetCore.Mvc;
using QTChinnok.AspMvc.Modules.Session;
using TModel = QTChinnok.AspMvc.Models.App.Album;

namespace QTChinnok.AspMvc.Controllers.App
{
    public class AlbumsController : Controller
    {
        private readonly Logic.Contracts.App.IAlbumsAccess _dataAccess;
        private readonly Logic.Contracts.Base.IArtistsAccess _artistsAccess;

        public AlbumsController(Logic.Contracts.App.IAlbumsAccess dataAccess, Logic.Contracts.Base.IArtistsAccess artistsAccess)
        {
            _dataAccess = dataAccess;
            _artistsAccess = artistsAccess;
        }

        // GET: Items
        public async Task<ActionResult> Index()
        {
            var session = new SessionWrapper(HttpContext.Session);
            var filterText = session.Get<string>("FilterText");

            if (string.IsNullOrEmpty(filterText))
            {
                var entities = await _dataAccess.GetAllAsync();
                var models = entities.Select(e => TModel.Create(e)).ToArray();

                return View(models);
            }
            else
            {
                return RedirectToAction(nameof(Filter), new { text = filterText });
            }
        }
        public async Task<ActionResult> Filter(string text)
        {
            var session = new SessionWrapper(HttpContext.Session);
            var entities = await _dataAccess.GetAllAsync();
            var models = entities.Select(e => TModel.Create(e)).ToArray();

            if (string.IsNullOrEmpty(text) == false)
            {
                models = models.Where(m => m.ToString()!.Contains(text, StringComparison.CurrentCultureIgnoreCase)).ToArray();
            }

            ViewBag.FilterText = text;
            session.Set<string>("FilterText", text);
            return View("Index", models);
        }

        // GET: Items/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = default(TModel);
            var entity = await _dataAccess.GetByIdAsync(id);

            if (entity != null)
            {
                model = TModel.Create(entity);
            }
            return model != null ? View(model) : NotFound();
        }

        // GET: Items/Create
        public async Task<ActionResult> Create()
        {
            var artists = await _artistsAccess.GetAllAsync();
            var entity = _dataAccess.Create();
            var model = TModel.Create(entity);

            model.Artists = artists.Select(a => Models.Base.Artist.Create(a)).ToList();

            return View(model);
        }

        // POST: Items/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TModel model)
        {
            try
            {
                var entity = _dataAccess.Create();

                entity.CopyFrom(model);
                entity = await _dataAccess.InsertAsync(entity);
                await _dataAccess.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var artists = await _artistsAccess.GetAllAsync();

                ViewBag.Error = ex.Message;
                model.Artists = artists.Select(a => Models.Base.Artist.Create(a)).ToList();
                return View(model);
            }
        }

        // GET: Items/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = default(TModel);
            var entity = await _dataAccess.GetByIdAsync(id);

            if (entity != null)
            {
                var artists = await _artistsAccess.GetAllAsync();

                model = TModel.Create(entity);
                model.Artists = artists.Select(a => Models.Base.Artist.Create(a)).ToList();
            }
            return model != null ? View(model) : NotFound();
        }

        // POST: Items/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, TModel model)
        {
            try
            {
                var entity = await _dataAccess.GetByIdAsync(id);

                if (entity != null)
                {
                    entity.CopyFrom(model);

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

        // GET: Items/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var model = default(TModel);
            var entity = await _dataAccess.GetByIdAsync(id);

            if (entity != null)
            {
                model = TModel.Create(entity);
            }
            return model != null ? View(model) : RedirectToAction(nameof(Index));
        }

        // POST: Items/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, TModel model)
        {
            try
            {
                await _dataAccess.DeleteAsync(id);
                await _dataAccess.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}
