using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication1.Domain.Creature;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class PlayersController : Controller
    {
        internal PlayerServices playerservices = new PlayerServices();
        internal FactionServices factionservices = new FactionServices();
        internal WeaponServices weaponservices = new WeaponServices();

        // GET: Players
        public ActionResult Index()
        {
            var players = playerservices.Enumerate();
            return View(players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = playerservices.Get(id ?? default(int));
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            ViewBag.FactionId = new SelectList(factionservices.Enumerate(), "Id", "Name");
            ViewBag.WieldedWeaponId = new SelectList(weaponservices.Enumerate(), "Id", "Name");
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Active,Name,WieldedWeaponId,HP,FactionId")] Player player)
        {
            if (ModelState.IsValid)
            {
                playerservices.Add(player);
                return RedirectToAction("Index");
            }

            ViewBag.FactionId = new SelectList(factionservices.Enumerate(), "Id", "Name", player.FactionId);
            ViewBag.WieldedWeaponId = new SelectList(weaponservices.Enumerate(), "Id", "Name", player.WieldedWeaponId);
            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = playerservices.Get(id ?? default(int));
            if (player == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactionId = new SelectList(factionservices.Enumerate(), "Id", "Name", player.FactionId);
            ViewBag.WieldedWeaponId = new SelectList(weaponservices.Enumerate(), "Id", "Name", player.WieldedWeaponId);
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Active,Name,WieldedWeaponId,HP,FactionId")] Player player)
        {
            if (ModelState.IsValid)
            {
                playerservices.Update(player);
                return RedirectToAction("Index");
            }
            ViewBag.FactionId = new SelectList(factionservices.EnumerateAll(), "Id", "Name", player.FactionId);
            ViewBag.WieldedWeaponId = new SelectList(weaponservices.EnumerateAll(), "Id", "Name", player.WieldedWeaponId);
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = playerservices.Get(id ?? default(int));
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            playerservices.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
