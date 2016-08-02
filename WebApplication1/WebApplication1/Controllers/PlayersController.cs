using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Domain.Creature;
using WebApplication1.Infrastructure;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class PlayersController : Controller
    {
        internal PlayerServices playerservices = new PlayerServices();
        private AppDbContext db = AppDbContext.Create();

        // GET: Players
        public ActionResult Index()
        {
            var players = db.Players.Include(p => p.ParentFaction).Include(p => p.WieldedWeapon);
            return View(players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = new Player(playerservices.GetPlayer(id ?? default(int)));
            //Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            ViewBag.FactionId = new SelectList(db.Factions, "Id", "Name");
            ViewBag.WieldedWeaponId = new SelectList(db.Items, "Id", "Name");
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
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FactionId = new SelectList(db.Factions, "Id", "Name", player.FactionId);
            ViewBag.WieldedWeaponId = new SelectList(db.Items, "Id", "Name", player.WieldedWeaponId);
            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactionId = new SelectList(db.Factions, "Id", "Name", player.FactionId);
            ViewBag.WieldedWeaponId = new SelectList(db.Items, "Id", "Name", player.WieldedWeaponId);
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
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FactionId = new SelectList(db.Factions, "Id", "Name", player.FactionId);
            ViewBag.WieldedWeaponId = new SelectList(db.Items, "Id", "Name", player.WieldedWeaponId);
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
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
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
