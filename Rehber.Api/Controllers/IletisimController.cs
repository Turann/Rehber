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
    public class IletisimController : ApiController
    {
        private Rehber_v3Entities db = new Rehber_v3Entities();

        // GET: api/Iletisim
        public IQueryable<Iletisim> GetIletisim()
        {
            return db.Iletisim;
        }

        // GET: api/Iletisim/5
        [ResponseType(typeof(Iletisim))]
        public IHttpActionResult GetIletisim(int id)
        {
            Iletisim iletisim = db.Iletisim.Find(id);
            if (iletisim == null)
            {
                return NotFound();
            }

            return Ok(iletisim);
        }

        // PUT: api/Iletisim/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIletisim(int id, Iletisim iletisim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != iletisim.Id)
            {
                return BadRequest();
            }

            db.Entry(iletisim).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IletisimExists(id))
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

        // POST: api/Iletisim
        [ResponseType(typeof(Iletisim))]
        public IHttpActionResult PostIletisim(Iletisim iletisim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Iletisim.Add(iletisim);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = iletisim.Id }, iletisim);
        }

        // DELETE: api/Iletisim/5
        [ResponseType(typeof(Iletisim))]
        public IHttpActionResult DeleteIletisim(int id)
        {
            Iletisim iletisim = db.Iletisim.Find(id);
            if (iletisim == null)
            {
                return NotFound();
            }

            db.Iletisim.Remove(iletisim);
            db.SaveChanges();

            return Ok(iletisim);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IletisimExists(int id)
        {
            return db.Iletisim.Count(e => e.Id == id) > 0;
        }
    }
}