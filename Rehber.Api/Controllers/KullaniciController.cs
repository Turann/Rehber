using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Ajax.Utilities;
using Rehber.DAL;

namespace Rehber.Api.Controllers
{
    public class KullaniciController : ApiController
    {
        private Rehber_v3Entities db = new Rehber_v3Entities();

        // GET: api/Kullanici
        public IQueryable<Kullanici> GetKullanici()
        {
            return db.Kullanici;
        }

        // GET: api/Kullanici/5
        [ResponseType(typeof(Kullanici))]
        public IHttpActionResult GetKullanici(int id)
        {
            Kullanici kullanici = db.Kullanici.Find(id);
            if (kullanici == null)
            {
                return NotFound();
            }

            return Ok(kullanici);
        }

        // PUT: api/Kullanici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKullanici(int id, Kullanici kullanici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kullanici.Id)
            {
                return BadRequest();
            }

            db.Entry(kullanici).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KullaniciExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Kullanici
        [ResponseType(typeof(Kullanici))]
        public IHttpActionResult PostKullanici(Kullanici kullanici)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kullanici.Add(kullanici);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kullanici.Id }, kullanici);
        }

        // DELETE: api/Kullanici/5
        [ResponseType(typeof(Kullanici))]
        public IHttpActionResult DeleteKullanici(int id)
        {
            Kullanici kullanici = db.Kullanici.Find(id);
            if (kullanici == null)
            {
                return NotFound();
            }

            db.Kullanici.Remove(kullanici);
            db.SaveChanges();

            return Ok(kullanici);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KullaniciExists(int id)
        {
            return db.Kullanici.Count(e => e.Id == id) > 0;
        }
    }
}