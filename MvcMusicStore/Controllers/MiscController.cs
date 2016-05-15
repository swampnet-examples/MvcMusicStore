using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class MiscController : Controller
    {
		private MusicStoreDB _db = new MusicStoreDB();

		// GET: Misc
		public ActionResult Index()
        {
			var albums = _db.Albums.Include(a => a.Artist).Include(a => a.Genre);
			return View(albums.ToList());
		}

		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Album album = _db.Albums.Find(id);
			if (album == null)
			{
				return HttpNotFound();
			}
			ViewBag.ArtistId = new SelectList(_db.Artists, "ArtistId", "Name", album.ArtistId);
			ViewBag.GenreId = new SelectList(_db.Genres, "GenreId", "Name", album.GenreId);
			return View(album);
		}

		public ActionResult Test()
		{
			return View();
		}


		public ActionResult SomePartial(string message)
		{
			return View();
		}
	}
}