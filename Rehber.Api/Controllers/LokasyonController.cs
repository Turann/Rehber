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
using Rehber.DAL;

namespace Rehber.Api.Controllers
{
    public class LokasyonController : ApiController
    {
        private Rehber_v3Entities db = new Rehber_v3Entities();

        // GET: api/Lokasyon
        public IQueryable<Lokasyon> GetLokasyon()
        {
            return db.Lokasyon;
        }

        // GET: api/Lokasyon/5
        [ResponseType(typeof(Lokasyon))]
        public IHttpActionResult GetLokasyon(int id)
        {
            Lokasyon lokasyon = db.Lokasyon.Find(id);
            if (lokasyon == null)
            {
                return NotFound();
            }

            return Ok(lokasyon);
        }

        // PUT: api/Lokasyon/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLokasyon(int id, Lokasyon lokasyon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lokasyon.Id)
            {
                return BadRequest();
            }

            db.Entry(lokasyon).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LokasyonExists(id))
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

        // POST: api/Lokasyon
        [ResponseType(typeof(Lokasyon))]
        public IHttpActionResult PostLokasyon(Lokasyon lokasyon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Lokasyon.Add(lokasyon);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lokasyon.Id }, lokasyon);
        }

        // DELETE: api/Lokasyon/5
        [ResponseType(typeof(Lokasyon))]
        public IHttpActionResult DeleteLokasyon(int id)
        {
            Lokasyon lokasyon = db.Lokasyon.Find(id);
            if (lokasyon == null)
            {
                return NotFound();
            }

            db.Lokasyon.Remove(lokasyon);
            db.SaveChanges();

            return Ok(lokasyon);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LokasyonExists(int id)
        {
            return db.Lokasyon.Count(e => e.Id == id) > 0;
        }
    }
}