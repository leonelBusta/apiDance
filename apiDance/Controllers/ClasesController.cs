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
using apiDance.Models;

namespace apiDance.Controllers
{
    public class ClasesController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Clases
        public IQueryable<Clases> GetClases()
        {
            return db.Clases;
        }

        // GET: api/Clases/5
        [ResponseType(typeof(Clases))]
        public IHttpActionResult GetClases(int id)
        {
            Clases clases = db.Clases.Find(id);
            if (clases == null)
            {
                return NotFound();
            }

            return Ok(clases);
        }

        // PUT: api/Clases/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClases(int id, Clases clases)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clases.idClase)
            {
                return BadRequest();
            }

            db.Entry(clases).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClasesExists(id))
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

        // POST: api/Clases
        [ResponseType(typeof(Clases))]
        public IHttpActionResult PostClases(Clases clases)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Clases.Add(clases);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = clases.idClase }, clases);
        }

        // DELETE: api/Clases/5
        [ResponseType(typeof(Clases))]
        public IHttpActionResult DeleteClases(int id)
        {
            Clases clases = db.Clases.Find(id);
            if (clases == null)
            {
                return NotFound();
            }

            db.Clases.Remove(clases);
            db.SaveChanges();

            return Ok(clases);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClasesExists(int id)
        {
            return db.Clases.Count(e => e.idClase == id) > 0;
        }
    }
}