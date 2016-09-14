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
using SliceOfHeaven.Models;

namespace SliceOfHeaven.Controllers
{
    public class specialsController : ApiController
    {
        private SliceOfHeavenContext db = new SliceOfHeavenContext();

        // GET: api/specials
        public IQueryable<specials> Getspecials()
        {
            return db.specials;
        }

        // GET: api/specials/5
        [ResponseType(typeof(specials))]
        public IHttpActionResult Getspecials(int id)
        {
            specials specials = db.specials.Find(id);
            if (specials == null)
            {
                return NotFound();
            }

            return Ok(specials);
        }

        // PUT: api/specials/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putspecials(int id, specials specials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != specials.id)
            {
                return BadRequest();
            }

            db.Entry(specials).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!specialsExists(id))
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

        // POST: api/specials
        [ResponseType(typeof(specials))]
        public IHttpActionResult Postspecials(specials specials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.specials.Add(specials);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = specials.id }, specials);
        }

        // DELETE: api/specials/5
        [ResponseType(typeof(specials))]
        public IHttpActionResult Deletespecials(int id)
        {
            specials specials = db.specials.Find(id);
            if (specials == null)
            {
                return NotFound();
            }

            db.specials.Remove(specials);
            db.SaveChanges();

            return Ok(specials);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool specialsExists(int id)
        {
            return db.specials.Count(e => e.id == id) > 0;
        }
    }
}