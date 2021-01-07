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
    public class RehberInfoController : ApiController
    {
        private Rehber_v3Entities db = new Rehber_v3Entities();

        // GET: api/RehberInfoes
        public IQueryable<RehberInfo> GetRehberInfo()
        {
            return db.RehberInfo;
        }

        // GET: api/RehberInfoes/5
        [ResponseType(typeof(RehberInfo))]
        public IHttpActionResult GetRehberInfo(int id)
        {
            RehberInfo rehberInfo = db.RehberInfo.Find(id);
            if (rehberInfo == null)
            {
                return NotFound();
            }

            return Ok(rehberInfo);
        }

        // PUT: api/RehberInfoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRehberInfo(int id, RehberInfo rehberInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rehberInfo.Id)
            {
                return BadRequest();
            }

            db.Entry(rehberInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RehberInfoExists(id))
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

        // POST: api/RehberInfoes
        [ResponseType(typeof(RehberInfo))]
        public IHttpActionResult PostRehberInfo(RehberInfo rehberInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RehberInfo.Add(rehberInfo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rehberInfo.Id }, rehberInfo);
        }

        // DELETE: api/RehberInfoes/5
        [ResponseType(typeof(RehberInfo))]
        public IHttpActionResult DeleteRehberInfo(int id)
        {
            RehberInfo rehberInfo = db.RehberInfo.Find(id);
            if (rehberInfo == null)
            {
                return NotFound();
            }

            db.RehberInfo.Remove(rehberInfo);
            db.SaveChanges();

            return Ok(rehberInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RehberInfoExists(int id)
        {
            return db.RehberInfo.Count(e => e.Id == id) > 0;
        }
    }
}